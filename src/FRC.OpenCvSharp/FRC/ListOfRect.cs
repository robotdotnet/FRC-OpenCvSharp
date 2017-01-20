using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace OpenCvSharp.FRC
{
    public class ListOfRect : IList<Rect>, IReadOnlyList<Rect>, IDisposable
    {
        private List<Rect> _rects;
        private VectorOfRect _nativeVector;
        private bool _copied = false;

        internal VectorOfRect NativeVector
        {
            get
            {
                _copied = false;
                return _nativeVector;
            }
        }

        internal VectorOfRect NativeVectorDraw => _nativeVector;

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
        public ListOfRect()
        {
            _rects = new List<Rect>();
            _nativeVector = new VectorOfRect();
        }

        /// <summary>
        /// Creates a new ListOfPointArray with the specified starting capacity
        /// </summary>
        /// <param name="capacity"></param>
        public ListOfRect(int capacity)
        {
            _rects = new List<Rect>(capacity);
            _nativeVector = new VectorOfRect(capacity);
        }

        /// <summary>
        /// Gets an enumerator for this list
        /// </summary>
        /// <returns>The enumerator</returns>
        public List<Rect>.Enumerator GetEnumerator()
        {
            CopyFromNative();
            return _rects.GetEnumerator();
        }

        /// <summary>
        /// Gets an enumerator for this list
        /// </summary>
        /// <returns>The enumerator</returns>
        IEnumerator<Rect> IEnumerable<Rect>.GetEnumerator()
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
        public void Add(Rect item)
        {
            throw new InvalidOperationException("Add not supported");
        }

        /// <summary>
        /// Clears all items from the list
        /// </summary>
        public void Clear()
        {
            _copied = false;
            _rects.Clear();
        }

        /// <summary>
        /// Gets if the list contains a specific item
        /// </summary>
        /// <param name="item">The item to check</param>
        /// <returns>True if the item exists</returns>
        public bool Contains(Rect item)
        {
            CopyFromNative();
            return _rects.Contains(item);
        }

        /// <summary>
        /// Copies all data to the specified array
        /// </summary>
        /// <param name="array">The array to copy to</param>
        /// <param name="arrayIndex">The array index to start at</param>
        public void CopyTo(Rect[] array, int arrayIndex)
        {
            CopyFromNative();
            _rects.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Removes an item from this list (Not supported, throws an InvalidOperationException)
        /// </summary>
        /// <param name="item">The item to remove</param>
        public bool Remove(Rect item)
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
                return _rects.Count;
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
        public int IndexOf(Rect item)
        {
            CopyFromNative();
            return _rects.IndexOf(item);
        }


        /// <summary>
        /// Inserts a new item to this list (Not supported, throws an InvalidOperationException)
        /// </summary>
        /// <param name="index">The index to add at</param>
        /// <param name="item">The item to add</param>
        public void Insert(int index, Rect item)
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
        /// Gets the Rect at the specified index
        /// </summary>
        /// <param name="index">The index to get from</param>
        /// <returns>The item at the index</returns>
        public Rect this[int index]
        {
            get
            {
                CopyFromNative();
                return _rects[index];
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
            var size = _nativeVector.Size;
            _rects.Clear();

            unsafe
            {
                Rect* start = (Rect*)_nativeVector.ElemPtr.ToPointer();

                for (int i = 0; i < size; i++)
                {
                    _rects.Add(start[i]);
                }
            }
        }
    }
}
