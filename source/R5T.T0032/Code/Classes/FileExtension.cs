using System;


namespace R5T.T0032
{
    public class FileExtension : IFileExtension
    {
        #region Static

        public static FileExtension Instance { get; } = new FileExtension();

        #endregion
    }
}
