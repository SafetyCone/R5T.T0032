using System;

using R5T.T0032;
using R5T.T0032.X001;


namespace System
{
    public static class IFileExtensionExtensions
    {
#pragma warning disable IDE1006 // Naming Styles

        [Obsolete("See R5T.Z0044.")]
        public static string bin(this IFileExtension _)
        {
            return FileExtensions.bin;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Binary(this IFileExtension _)
        {
            return FileExtensions.Binary;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string dat(this IFileExtension _)
        {
            return FileExtensions.dat;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Data(this IFileExtension _)
        {
            return FileExtensions.Data;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string json(this IFileExtension _)
        {
            return FileExtensions.json;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Json(this IFileExtension _)
        {
            return FileExtensions.Json;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string tmp(this IFileExtension _)
        {
            return FileExtensions.tmp;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Temporary(this IFileExtension _)
        {
            return FileExtensions.Temporary;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string txt(this IFileExtension _)
        {
            return FileExtensions.txt;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Text(this IFileExtension _)
        {
            return FileExtensions.Text;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}
