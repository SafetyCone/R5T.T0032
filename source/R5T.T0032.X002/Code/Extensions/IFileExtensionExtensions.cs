using System;

using R5T.T0032;
using R5T.T0032.X002;


namespace System
{
    public static class IFileExtensionExtensions
    {
#pragma warning disable IDE1006 // Naming Styles
        
        public static string bmp(this IFileExtension _)
        {
            return ImageFileExtensions.bmp;
        }

        public static string Bitmap(this IFileExtension _)
        {
            return ImageFileExtensions.Bitmap;
        }

        public static string jpeg(this IFileExtension _)
        {
            return ImageFileExtensions.jpeg;
        }

        public static string Jpeg(this IFileExtension _)
        {
            return ImageFileExtensions.Jpeg;
        }

        public static string jpg(this IFileExtension _)
        {
            return ImageFileExtensions.jpg;
        }

        public static string Jpg(this IFileExtension _)
        {
            return ImageFileExtensions.Jpg;
        }

        public static string JpegStandard(this IFileExtension _)
        {
            return ImageFileExtensions.JpegStandard;
        }

        public static string png(this IFileExtension _)
        {
            return ImageFileExtensions.png;
        }

        public static string Png(this IFileExtension _)
        {
            return ImageFileExtensions.Png;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}
