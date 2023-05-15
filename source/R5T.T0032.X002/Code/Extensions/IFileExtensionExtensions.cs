using System;

using R5T.T0032;
using R5T.T0032.X002;


namespace System
{
    public static class IFileExtensionExtensions
    {
#pragma warning disable IDE1006 // Naming Styles

        [Obsolete("See R5T.Z0044.")]
        public static string bmp(this IFileExtension _)
        {
            return ImageFileExtensions.bmp;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Bitmap(this IFileExtension _)
        {
            return ImageFileExtensions.Bitmap;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string jpeg(this IFileExtension _)
        {
            return ImageFileExtensions.jpeg;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Jpeg(this IFileExtension _)
        {
            return ImageFileExtensions.Jpeg;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string jpg(this IFileExtension _)
        {
            return ImageFileExtensions.jpg;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Jpg(this IFileExtension _)
        {
            return ImageFileExtensions.Jpg;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string JpegStandard(this IFileExtension _)
        {
            return ImageFileExtensions.JpegStandard;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string png(this IFileExtension _)
        {
            return ImageFileExtensions.png;
        }

        [Obsolete("See R5T.Z0044.")]
        public static string Png(this IFileExtension _)
        {
            return ImageFileExtensions.Png;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}
