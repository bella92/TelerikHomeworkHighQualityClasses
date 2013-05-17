using System;

namespace Utils
{
    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("File name can't be null!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string fileExtension = fileName.Substring(indexOfLastDot + 1);
            return fileExtension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("File name can't be null!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            return fileNameWithoutExtension;
        }
    }
}