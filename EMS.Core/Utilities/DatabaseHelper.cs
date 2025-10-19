using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace EMS.Core.Utilities
{
    public static class DatabaseHelper
    {
        private static readonly string _dbPath;
        private static readonly string _connectionString;

        static DatabaseHelper()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string solutionRoot = Directory.GetParent(baseDir).Parent.Parent.Parent.Parent.FullName;

            string dataFolder = Path.Combine(solutionRoot, "Data");
            _dbPath = Path.Combine(dataFolder, "ems.db");

            Directory.CreateDirectory(dataFolder);

            _connectionString = $"Data Source={_dbPath}";
        }

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(_connectionString);
        }

        public static void InitializeDatabase()
        {
            if (!File.Exists(_dbPath))
            {
                File.Create(_dbPath).Close();
            }
        }

        public static string GetDatabasePath() => _dbPath;
    }
}
