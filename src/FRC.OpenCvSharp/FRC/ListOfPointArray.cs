using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCvSharp.FRC
{
    public class ListOfPointArray : IList<Point[]>, IReadOnlyList<Point[]>, IDisposable
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

        public void Dispose()
        {
            _nativeVector.Dispose();
        }

        public ListOfPointArray()
        {
            _points = new List<Point[]>();
            _sizes = new NativeList<IntPtr>();
            _gcHandles = new NativeList<GCHandle>();
            _nativeVector = new VectorOfVectorPoint();
        }

        public ListOfPointArray(int capacity)
        {
            _points = new List<Point[]>(capacity);
            _sizes = new NativeList<IntPtr>(capacity);
            _gcHandles = new NativeList<GCHandle>(capacity);
            _nativeVector = new VectorOfVectorPoint(capacity);
        }

        public List<Point[]>.Enumerator GetEnumerator()
        {
            CopyFromNative();
            return _points.GetEnumerator();
        }

        IEnumerator<Point[]> IEnumerable<Point[]>.GetEnumerator()
        {
            CopyFromNative();
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            CopyFromNative();
            return GetEnumerator();
        }

        public void Add(Point[] item)
        {
            throw new InvalidOperationException("Add not supported");
        }

        public void Clear()
        {
            _copied = false;
            _points.Clear();
            _sizes.Clear();
        }

        public bool Contains(Point[] item)
        {
            CopyFromNative();
            return _points.Contains(item);
        }

        public void CopyTo(Point[][] array, int arrayIndex)
        {
            _points.CopyTo(array, arrayIndex);
        }

        public bool Remove(Point[] item)
        {
            throw new InvalidOperationException("Remove not supported");
        }

        public int Count
        {
            get
            {
                CopyFromNative();
                return _points.Count;
            }
        }

        public bool IsReadOnly => true;
        public int IndexOf(Point[] item)
        {
            CopyFromNative();
            return _points.IndexOf(item);
        }

        public void Insert(int index, Point[] item)
        {
            throw new InvalidOperationException("Insert not supported");
        }

        public void RemoveAt(int index)
        {
            throw new InvalidOperationException("RemoveAt not supported");
        }

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
