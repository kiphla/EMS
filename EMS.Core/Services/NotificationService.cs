using EMS.Core.Models;
using EMS.Core.Utilities;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System;

namespace EMS.Core.Services
{
    public class NotificationService
    {
        public void Add(Notification item)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Notifications (Title, Description, CreatedDate, IsOngoing, IsActive) VALUES (@Title, @Description, @CreatedDate, @IsOngoing, @IsActive)";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", item.Title);
                    command.Parameters.AddWithValue("@Description", item.Description);
                    command.Parameters.AddWithValue("@CreatedDate", item.CreatedDate);
                    command.Parameters.AddWithValue("@IsOngoing", item.IsOngoing ? 1 : 0);
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
                string query = "DELETE FROM Notifications WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Notification GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Notifications WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Notification
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = Convert.ToString(reader["Title"]),
                                Description = Convert.ToString(reader["Description"]),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                IsOngoing = Convert.ToInt32(reader["IsOngoing"]) == 1,
                                IsActive = Convert.ToInt32(reader["IsActive"]) == 1
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Notification> GetAll()
        {
            var notifications = new List<Notification>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Notifications WHERE IsActive = 1";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notifications.Add(new Notification
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = Convert.ToString(reader["Title"]),
                                Description = Convert.ToString(reader["Description"]),
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                                IsOngoing = Convert.ToInt32(reader["IsOngoing"]) == 1,
                                IsActive = Convert.ToInt32(reader["IsActive"]) == 1
                            });
                        }
                    }
                }
            }
            return notifications;
        }

        public void Terminate(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Notifications SET IsActive = 0 WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}