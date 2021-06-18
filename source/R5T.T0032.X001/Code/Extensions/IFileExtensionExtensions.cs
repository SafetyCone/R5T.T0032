using System;

using R5T.T0032;
using R5T.T0032.X001;


namespace System
{
    public static class IFileExtensionExtensions
    {
#pragma warning disable IDE1006 // Naming Styles
        
        public static string bin(this IFileExtension _)
        {
            return FileExtensions.bin;
        }

        public static string Binary(this IFileExtension _)
        {
            return FileExtensions.Binary;
        }

        public static string dat(this IFileExtension _)
        {
            return FileExtensions.dat;
        }

        public static string Data(this IFileExtension _)
        {
            return FileExtensions.Data;
        }

        public static string json(this IFileExtension _)
        {
            return FileExtensions.json;
        }

        public static string Json(this IFileExtension _)
        {
            return FileExtensions.Json;
        }

        public static string tmp(this IFileExtension _)
        {
            return FileExtensions.tmp;
        }

        public static string Temporary(this IFileExtension _)
        {
            return FileExtensions.Temporary;
        }

        public static string txt(this IFileExtension _)
        {
            return FileExtensions.txt;
        }

        public static string Text(this IFileExtension _)
        {
            return FileExtensions.Text;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}
