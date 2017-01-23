﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenCvSharp.Util;

namespace OpenCvSharp
{
    /// <summary>
    /// The base class for camera response calibration algorithms.
    /// </summary>
    public abstract class CalibrateCRF : Algorithm
    {
        /// <summary>
        /// Recovers inverse camera response.
        /// </summary>
        /// <param name="src">vector of input images</param>
        /// <param name="dst">256x1 matrix with inverse camera response function</param>
        /// <param name="times">vector of exposure time values for each image</param>
        public virtual void Process(IEnumerable<Mat> src, OutputArray dst, IEnumerable<float> times)
        {
            if (src == null)
                throw new ArgumentNullException(nameof(src));
            if (dst == null)
                throw new ArgumentNullException(nameof(dst));
            if (times == null)
                throw new ArgumentNullException(nameof(times));
            dst.ThrowIfNotReady();
            
            IntPtr[] srcArray = src.SelectPtrs();
            float[] timesArray = times.ToArray();
            if (srcArray.Length != timesArray.Length)
                throw new OpenCvSharpException("src.Count() != times.Count");

            NativeMethods.photo_CalibrateCRF_process(ptr, srcArray, srcArray.Length, dst.CvPtr, timesArray);

            dst.Fix();
            GC.KeepAlive(src);
        }
    }
}
