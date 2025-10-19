namespace EMS.Core.Utilities
{
    public static class FileHelper
    {
        public static void ExportToCsv(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        public static string ReadFromCsv(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
