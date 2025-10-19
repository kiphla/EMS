using EMS.Core.Models;
using EMS.Core.Utilities;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System;

namespace EMS.Core.Services
{
    public class TaskService
    {
        public void Add(TaskItem item)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Tasks (Title, Description, CreatedDate, IsActive) VALUES (@Title, @Description, @CreatedDate, @IsActive)";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", item.Title);
                    command.Parameters.AddWithValue("@Description", item.Description);
                    command.Parameters.AddWithValue("@CreatedDate", item.CreatedDate);
                    command.Parameters.AddWithValue("@IsActive", item.IsActive ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remove(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Tasks WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public TaskItem GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Tasks WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TaskItem
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = Convert.ToString(reader["Title"]),
                                Description = Convert.ToString(reader["Description"]),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                IsActive = Convert.ToInt32(reader["IsActive"]) == 1
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<TaskItem> GetAll()
        {
            var tasks = new List<TaskItem>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Tasks WHERE IsActive = 1";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tasks.Add(new TaskItem
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = Convert.ToString(reader["Title"]),
                                Description = Convert.ToString(reader["Description"]),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                IsActive = Convert.ToInt32(reader["IsActive"]) == 1
                            });
                        }
                    }
                }
            }
            return tasks;
        }

        public void Complete(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Tasks SET IsActive = 0 WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}