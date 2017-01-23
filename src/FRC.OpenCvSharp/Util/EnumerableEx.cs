using System;
using System.Linq;
using System.Collections.Generic;

namespace OpenCvSharp.Util
{

    /// <summary>
    /// IEnumerable&lt;T&gt; extension methods for .NET Framework 2.0 
    /// </summary>
    internal static class EnumerableEx
    {
        public static TResult[] SelectMatrix<TResult, TSource>(this TSource[,] array, Func<TSource, TResult> selector)
        {
            TResult[] arrs = new TResult[array.Length];
            int count = 0;
            foreach(TSource item in array)
            {
                arrs[count] = selector(item);
                count++;
            }
            return arrs;
        }

        public static T[][] SelectArrayArrayReadOnly<T>(this IEnumerable<IEnumerable<T>> enumerable)
        {
            T[][] e = enumerable as T[][];
            if (e != null)
            {
                return e;
            }
            var result = new List<T[]>();
            foreach (IEnumerable<T> source in enumerable)
            {
                T[] s = source as T[];
                if (s != null)
                {
                    result.Add(s);
                    continue;
                }
                result.Add(source.ToArray());
            }
            return result.ToArray();
        }

        /// <summary>
        /// Enumerable.Select -> ToArray
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IntPtr[] SelectPtrs<T>(this IEnumerable<T> enumerable) where T : DisposableCvObject
        {
            return enumerable.Select((obj) =>
            {
                if (obj == null)
                    throw new ArgumentException("enumerable contains null");
                obj.ThrowIfDisposed();
                return obj.CvPtr;
            }).ToArray();
        }
    }
}
