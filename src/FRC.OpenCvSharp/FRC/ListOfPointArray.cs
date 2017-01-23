using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCvSharp.FRC
{
    /// <summary>
    /// The class contains a List of Point Arrays to be used for finding objects in OpenCV
    /// </summary>
    /// <remarks>
    /// This class should be stored outside your main loop, and created only once. Reuse this for every image created
    /// </remarks>
    public class ListOfPointArray : IList<Point[]>, IDisposable
    #if !NET35
        , IReadOnlyList<Point[]>
    #endif
    {
        private List<Point[]> _points;
        private NativeList<IntPtr> _sizes;
        private NativeList<GCHandle> _gcHandles;
        private VectorOfVectorPoint _nativeVector;
        private bool _copied = false;

        internal VectorOfVectorPoint NativeVector
        {
            get
            {
                _copied = false;
                return _nativeVector;
            }
        }

        internal VectorOfVectorPoint NativeVectorDraw => _nativeVector;

        /// <summary>
        /// Disposes of this object. After calling this, it cannot be used again
        /// </summary>
        public void Dispose()
        {
            _nativeVector.Dispose();
        }

        /// <summary>
        /// Creates a new ListOfPointArray
        /// </summary>
        public ListOfPointArray()
        {
            _points = new List<Point[]>();
            _sizes = new NativeList<IntPtr>();
            _gcHandles = new NativeList<GCHandle>();
            _nativeVector = new VectorOfVectorPoint();
        }

        /// <summary>
        /// Creates a new ListOfPointArray with the specified starting capacity
        /// </summary>
        /// <param name="capacity"></param>
        public ListOfPointArray(int capacity)
        {
            _points = new List<Point[]>(capacity);
            _sizes = new NativeList<IntPtr>(capacity);
            _gcHandles = new NativeList<GCHandle>(capacity);
            _nativeVector = new VectorOfVectorPoint(capacity);
        }

        /// <summary>
        /// Gets an enumerator for this list
        /// </summary>
        /// <returns>The enumerator</returns>
        public List<Point[]>.Enumerator GetEnumerator()
        {
            CopyFromNative();
            return _points.GetEnumerator();
        }

        /// <summary>
        /// Gets an enumerator for this list
        /// </summary>
        /// <returns>The enumerator</returns>
        IEnumerator<Point[]> IEnumerable<Point[]>.GetEnumerator()
        {
            CopyFromNative();
            return GetEnumerator();
        }

        /// <summary>
        /// Gets an enumerator for this list
        /// </summary>
        /// <returns>The enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            CopyFromNative();
            return GetEnumerator();
        }

        /// <summary>
        /// Adds a new item to this list (Not supported, throws an InvalidOperationException)
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Add(Point[] item)
        {
            throw new InvalidOperationException("Add not supported");
        }

        /// <summary>
        /// Clears all items from the list
        /// </summary>
        public void Clear()
        {
            _copied = false;
            _points.Clear();
            _sizes.Clear();
        }

        /// <summary>
        /// Gets if the list contains a specific item
        /// </summary>
        /// <param name="item">The item to check</param>
        /// <returns>True if the item exists</returns>
        public bool Contains(Point[] item)
        {
            CopyFromNative();
            return _points.Contains(item);
        }

        /// <summary>
        /// Copies all data to the specified array
        /// </summary>
        /// <param name="array">The array to copy to</param>
        /// <param name="arrayIndex">The array index to start at</param>
        public void CopyTo(Point[][] array, int arrayIndex)
        {
            CopyFromNative();
            _points.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Removes an item from this list (Not supported, throws an InvalidOperationException)
        /// </summary>
        /// <param name="item">The item to remove</param>
        public bool Remove(Point[] item)
        {
            throw new InvalidOperationException("Remove not supported");
        }

        /// <summary>
        /// Gets the number of items in the list
        /// </summary>
        public int Count
        {
            get
            {
                CopyFromNative();
                return _points.Count;
            }
        }

        /// <summary>
        /// Return true
        /// </summary>
        public bool IsReadOnly => true;

        /// <summary>
        /// Gets the index of the requested item
        /// </summary>
        /// <param name="item">The item to look for</param>
        /// <returns>Its index in the array</returns>
        public int IndexOf(Point[] item)
        {
            CopyFromNative();
            return _points.IndexOf(item);
        }


        /// <summary>
        /// Inserts a new item to this list (Not supported, throws an InvalidOperationException)
        /// </summary>
        /// <param name="index">The index to add at</param>
        /// <param name="item">The item to add</param>
        public void Insert(int index, Point[] item)
        {
            throw new InvalidOperationException("Insert not supported");
        }

        /// <summary>
        /// Removes an item from this list (Not supported, throws an InvalidOperationException)
        /// </summary>
        /// <param name="index">The index to add at</param>
        public void RemoveAt(int index)
        {
            throw new InvalidOperationException("RemoveAt not supported");
        }

        /// <summary>
        /// Gets the Point[] at the specified index
        /// </summary>
        /// <param name="index">The index to get from</param>
        /// <returns>The item at the index</returns>
        public Point[] this[int index]
        {
            get
            {
                CopyFromNative();
                return _points[index];
            }
            set
            {
                throw new InvalidOperationException("Set not supported");
            }
        }

        private void CopyFromNative()
        {
            if (_copied) return;
            _copied = true;
            var size = _nativeVector.Size1;
            _sizes.Clear();
            _sizes.Capacity = size;
            _sizes.Count = size;
            unsafe
            {
                fixed (IntPtr* p = _sizes._items)
                {
                    NativeMethods.vector_vector_Point_getSize2Ptr(_nativeVector.CvPtr, p);
                }
            }
            _points.Clear();
            if (_points.Capacity < size)
            {
                _points.Capacity = size;
            }
            _gcHandles.Clear();
            _gcHandles.Capacity = size;
            _gcHandles.Count = size;
            for (int i = 0; i < size; i++)
            {
                Point[] points = new Point[_sizes[i].ToInt32()];
                _gcHandles[i] = GCHandle.Alloc(points, GCHandleType.Pinned);
                _sizes[i] = _gcHandles[i].AddrOfPinnedObject();
                _points.Add(points);
            }
            unsafe
            {
                fixed (IntPtr* p = _sizes._items)
                {
                    NativeMethods.vector_vector_Point_copy2(_nativeVector.CvPtr, p);
                }
            }
            foreach (GCHandle h in _gcHandles._items)
            {
                if (h.IsAllocated)
                {
                    h.Free();
                }
            }
        }
    }
}
