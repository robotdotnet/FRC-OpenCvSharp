#if NET35
using System;
namespace OpenCvSharp.Util
{
    internal static class NET35Extensions
    {
        public static Type GetTypeInfo(this Type type)
        {
            return type;
        }
    }
}
#endif
