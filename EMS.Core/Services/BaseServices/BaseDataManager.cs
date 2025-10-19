using EMS.Core.Models.BaseModels;
using EMS.Core.Interfaces;
using EMS.Core.Utilities;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace EMS.Core.Services.BaseServices
{
    public abstract class BaseDataManager<T> where T : EnvironmentalData
    {
        protected abstract string TableName { get; }
        protected abstract string InsertQuery { get; }
        protected abstract void SetInsertParameters(SqliteCommand command, T item);
        protected abstract T MapToModel(SqliteDataReader reader);

        public virtual void Remove(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = $"DELETE FROM {TableName} WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public virtual void Add(T item)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var command = new SqliteCommand(InsertQuery, connection))
                {
                    SetInsertParameters(command, item);
                    command.ExecuteNonQuery();
                }
            }
        }

        public virtual T? GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = $"SELECT * FROM {TableName} WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapToModel(reader);
                        }
                    }
                }
            }
            return null;
        }

        public virtual List<T> GetAll()
        {
            var items = new List<T>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = $"SELECT * FROM {TableName}";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(MapToModel(reader));
                        }
                    }
                }
            }
            return items;
        }
    }
}