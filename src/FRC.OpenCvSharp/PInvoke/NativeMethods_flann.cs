using OpenCvSharp.PInvoke.NativeLibraryUtilties;
using System;
using System.Runtime.InteropServices;
using System.Text;
using OpenCvSharp.Flann;

#pragma warning disable 1591

namespace OpenCvSharp
{
    partial class NativeMethods
    {
        #region Index
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_Index_newDelegate(IntPtr features, IntPtr @params, int distType);
        [NativeDelegate("flann_Index_new")] public static flann_Index_newDelegate flann_Index_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_Index_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_Index_delete")] public static flann_Index_deleteDelegate flann_Index_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_Index_knnSearch1Delegate(IntPtr obj, [In] float[] queries, int queriesLength, [Out] int[] indices, [Out] float[] dists, int knn, IntPtr @params);
        [NativeDelegate("flann_Index_knnSearch1")] public static flann_Index_knnSearch1Delegate flann_Index_knnSearch1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_Index_knnSearch2Delegate(IntPtr obj, IntPtr queries, IntPtr indices, IntPtr dists, int knn, IntPtr @params);
        [NativeDelegate("flann_Index_knnSearch2")] public static flann_Index_knnSearch2Delegate flann_Index_knnSearch2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_Index_knnSearch3Delegate(IntPtr obj, IntPtr queries, [Out] int[] indices, [Out] float[] dists, int knn, IntPtr @params);
        [NativeDelegate("flann_Index_knnSearch3")] public static flann_Index_knnSearch3Delegate flann_Index_knnSearch3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_Index_radiusSearch1Delegate(IntPtr obj, [In] float[] queries, int queriesLength, [Out] int[] indices, int indicesLength, [Out] float[] dists, int dists_length, float radius, int maxResults, IntPtr @params);
        [NativeDelegate("flann_Index_radiusSearch1")] public static flann_Index_radiusSearch1Delegate flann_Index_radiusSearch1;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_Index_radiusSearch2Delegate(IntPtr obj, IntPtr queries, IntPtr indices, IntPtr dists, float radius, int maxResults, IntPtr @params);
        [NativeDelegate("flann_Index_radiusSearch2")] public static flann_Index_radiusSearch2Delegate flann_Index_radiusSearch2;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_Index_radiusSearch3Delegate(IntPtr obj, IntPtr queries, [Out] int[] indices, int indicesLength, [Out] float[] dists, int distsLength, float radius, int maxResults, IntPtr @params);
        [NativeDelegate("flann_Index_radiusSearch3")] public static flann_Index_radiusSearch3Delegate flann_Index_radiusSearch3;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_Index_saveDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string filename);
        [NativeDelegate("flann_Index_save")] public static flann_Index_saveDelegate flann_Index_save;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int flann_Index_veclenDelegate(IntPtr obj);
        [NativeDelegate("flann_Index_veclen")] public static flann_Index_veclenDelegate flann_Index_veclen;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int flann_Index_sizeDelegate(IntPtr obj);
        [NativeDelegate("flann_Index_size")] public static flann_Index_sizeDelegate flann_Index_size;
        */
        #endregion
        #region IndexParams
        #region IndexParams
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_IndexParams_newDelegate();
        [NativeDelegate("flann_IndexParams_new")] public static flann_IndexParams_newDelegate flann_IndexParams_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_IndexParams_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_IndexParams_delete")] public static flann_IndexParams_deleteDelegate flann_IndexParams_delete;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_IndexParams_getStringDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string defaultVal, [MarshalAs(UnmanagedType.LPStr)] StringBuilder result);
        [NativeDelegate("flann_IndexParams_getString")] public static flann_IndexParams_getStringDelegate flann_IndexParams_getString;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int flann_IndexParams_getIntDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string key, int defaultVal);
        [NativeDelegate("flann_IndexParams_getInt")] public static flann_IndexParams_getIntDelegate flann_IndexParams_getInt;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate double flann_IndexParams_getDoubleDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string key, double defaultVal);
        [NativeDelegate("flann_IndexParams_getDouble")] public static flann_IndexParams_getDoubleDelegate flann_IndexParams_getDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_IndexParams_setStringDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string key, [MarshalAs(UnmanagedType.LPStr)] string value);
        [NativeDelegate("flann_IndexParams_setString")] public static flann_IndexParams_setStringDelegate flann_IndexParams_setString;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_IndexParams_setIntDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string key, int value);
        [NativeDelegate("flann_IndexParams_setInt")] public static flann_IndexParams_setIntDelegate flann_IndexParams_setInt;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_IndexParams_setDoubleDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string key, double value);
        [NativeDelegate("flann_IndexParams_setDouble")] public static flann_IndexParams_setDoubleDelegate flann_IndexParams_setDouble;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_IndexParams_setFloatDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string key, float value);
        [NativeDelegate("flann_IndexParams_setFloat")] public static flann_IndexParams_setFloatDelegate flann_IndexParams_setFloat;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_IndexParams_setBoolDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string key, int value);
        [NativeDelegate("flann_IndexParams_setBool")] public static flann_IndexParams_setBoolDelegate flann_IndexParams_setBool;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_IndexParams_setAlgorithmDelegate(IntPtr obj, int value);
        [NativeDelegate("flann_IndexParams_setAlgorithm")] public static flann_IndexParams_setAlgorithmDelegate flann_IndexParams_setAlgorithm;
        #endregion
        #region LinearIndexParams
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_LinearIndexParams_newDelegate();
        [NativeDelegate("flann_LinearIndexParams_new")] public static flann_LinearIndexParams_newDelegate flann_LinearIndexParams_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_LinearIndexParams_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_LinearIndexParams_delete")] public static flann_LinearIndexParams_deleteDelegate flann_LinearIndexParams_delete;
        #endregion
        #region KDTreeIndexParams
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_KDTreeIndexParams_newDelegate(int trees);
        [NativeDelegate("flann_KDTreeIndexParams_new")] public static flann_KDTreeIndexParams_newDelegate flann_KDTreeIndexParams_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_KDTreeIndexParams_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_KDTreeIndexParams_delete")] public static flann_KDTreeIndexParams_deleteDelegate flann_KDTreeIndexParams_delete;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* flann_KDTreeIndexParams_treesDelegate(IntPtr obj);
        [NativeDelegate("flann_KDTreeIndexParams_trees")] public static flann_KDTreeIndexParams_treesDelegate flann_KDTreeIndexParams_trees;
        */
        #endregion
        #region KMeansIndexParams
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_KMeansIndexParams_newDelegate(
            int branching, int iterations, [MarshalAs(UnmanagedType.I4)] FlannCentersInit centers_init, float cb_index);
        [NativeDelegate("flann_KMeansIndexParams_new")] public static flann_KMeansIndexParams_newDelegate flann_KMeansIndexParams_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_KMeansIndexParams_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_KMeansIndexParams_delete")] public static flann_KMeansIndexParams_deleteDelegate flann_KMeansIndexParams_delete;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* flann_KMeansIndexParams_branchingDelegate(IntPtr obj);
        [NativeDelegate("flann_KMeansIndexParams_branching")] public static flann_KMeansIndexParams_branchingDelegate flann_KMeansIndexParams_branching;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* flann_KMeansIndexParams_iterationsDelegate(IntPtr obj);
        [NativeDelegate("flann_KMeansIndexParams_iterations")] public static flann_KMeansIndexParams_iterationsDelegate flann_KMeansIndexParams_iterations;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate FlannCentersInit* flann_KMeansIndexParams_centers_initDelegate(IntPtr obj);
        [NativeDelegate("flann_KMeansIndexParams_centers_init")] public static flann_KMeansIndexParams_centers_initDelegate flann_KMeansIndexParams_centers_init;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* flann_KMeansIndexParams_cb_indexDelegate(IntPtr obj);
        [NativeDelegate("flann_KMeansIndexParams_cb_index")] public static flann_KMeansIndexParams_cb_indexDelegate flann_KMeansIndexParams_cb_index;
        */
        #endregion
        #region CompositeIndexParams
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_CompositeIndexParams_newDelegate(int trees, int branching, int iterations, FlannCentersInit centers_init, float cb_index);
        [NativeDelegate("flann_CompositeIndexParams_new")] public static flann_CompositeIndexParams_newDelegate flann_CompositeIndexParams_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_CompositeIndexParams_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_CompositeIndexParams_delete")] public static flann_CompositeIndexParams_deleteDelegate flann_CompositeIndexParams_delete;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* flann_CompositeIndexParams_treesDelegate(IntPtr obj);
        [NativeDelegate("flann_CompositeIndexParams_trees")] public static flann_CompositeIndexParams_treesDelegate flann_CompositeIndexParams_trees;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* flann_CompositeIndexParams_branchingDelegate(IntPtr obj);
        [NativeDelegate("flann_CompositeIndexParams_branching")] public static flann_CompositeIndexParams_branchingDelegate flann_CompositeIndexParams_branching;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate int* flann_CompositeIndexParams_iterationsDelegate(IntPtr obj);
        [NativeDelegate("flann_CompositeIndexParams_iterations")] public static flann_CompositeIndexParams_iterationsDelegate flann_CompositeIndexParams_iterations;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate FlannCentersInit* flann_CompositeIndexParams_centers_initDelegate(IntPtr obj);
        [NativeDelegate("flann_CompositeIndexParams_centers_init")] public static flann_CompositeIndexParams_centers_initDelegate flann_CompositeIndexParams_centers_init;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* flann_CompositeIndexParams_cb_indexDelegate(IntPtr obj);
        [NativeDelegate("flann_CompositeIndexParams_cb_index")] public static flann_CompositeIndexParams_cb_indexDelegate flann_CompositeIndexParams_cb_index;
        */
        #endregion
        #region AutotunedIndexParams
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_AutotunedIndexParams_newDelegate(float targetPrecision, float build_weight, float memory_weight, float sample_fraction);
        [NativeDelegate("flann_AutotunedIndexParams_new")] public static flann_AutotunedIndexParams_newDelegate flann_AutotunedIndexParams_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_AutotunedIndexParams_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_AutotunedIndexParams_delete")] public static flann_AutotunedIndexParams_deleteDelegate flann_AutotunedIndexParams_delete;
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* flann_AutotunedIndexParams_target_precisionDelegate(IntPtr obj);
        [NativeDelegate("flann_AutotunedIndexParams_target_precision")] public static flann_AutotunedIndexParams_target_precisionDelegate flann_AutotunedIndexParams_target_precision;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* flann_AutotunedIndexParams_build_weightDelegate(IntPtr obj);
        [NativeDelegate("flann_AutotunedIndexParams_build_weight")] public static flann_AutotunedIndexParams_build_weightDelegate flann_AutotunedIndexParams_build_weight;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* flann_AutotunedIndexParams_memory_weightDelegate(IntPtr obj);
        [NativeDelegate("flann_AutotunedIndexParams_memory_weight")] public static flann_AutotunedIndexParams_memory_weightDelegate flann_AutotunedIndexParams_memory_weight;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate float* flann_AutotunedIndexParams_sample_fractionDelegate(IntPtr obj);
        [NativeDelegate("flann_AutotunedIndexParams_sample_fraction")] public static flann_AutotunedIndexParams_sample_fractionDelegate flann_AutotunedIndexParams_sample_fraction;
        */
        #endregion
        #region SavedIndexParams
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_SavedIndexParams_newDelegate([MarshalAs(UnmanagedType.LPStr)] string filename);
        [NativeDelegate("flann_SavedIndexParams_new")] public static flann_SavedIndexParams_newDelegate flann_SavedIndexParams_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_SavedIndexParams_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_SavedIndexParams_delete")] public static flann_SavedIndexParams_deleteDelegate flann_SavedIndexParams_delete;
        /*
        //[return: MarshalAs(UnmanagedType.LPStr)]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string flann_SavedIndexParams_filename_getDelegate(IntPtr obj);
        [NativeDelegate("flann_SavedIndexParams_filename_get")] public static flann_SavedIndexParams_filename_getDelegate flann_SavedIndexParams_filename_get;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_SavedIndexParams_filename_setDelegate(IntPtr obj, [MarshalAs(UnmanagedType.LPStr)] string filename);
        [NativeDelegate("flann_SavedIndexParams_filename_set")] public static flann_SavedIndexParams_filename_setDelegate flann_SavedIndexParams_filename_set;
        */
        #endregion
        #region SearchParams
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr flann_SearchParams_newDelegate(int checks, float eps, int sorted);
        [NativeDelegate("flann_SearchParams_new")] public static flann_SearchParams_newDelegate flann_SearchParams_new;
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void flann_SearchParams_deleteDelegate(IntPtr obj);
        [NativeDelegate("flann_SearchParams_delete")] public static flann_SearchParams_deleteDelegate flann_SearchParams_delete;
        #endregion

        #endregion
        /*
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int flann_hierarchicalClusteringDelegate(IntPtr features, IntPtr centers, IntPtr @params);
        [NativeDelegate("flann_hierarchicalClustering")] public static flann_hierarchicalClusteringDelegate flann_hierarchicalClustering;
        */
    }
}
