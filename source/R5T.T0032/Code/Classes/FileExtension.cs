using System;

using R5T.T0032;


namespace System
{
    public class FileExtension : IFileExtension
    {
        #region Static

        public static FileExtension Instance { get; } = new FileExtension();

        #endregion
    }
}
