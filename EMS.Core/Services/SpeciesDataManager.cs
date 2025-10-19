using EMS.Core.Models;
using EMS.Core.Interfaces;
using EMS.Core.Utilities;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;

namespace EMS.Core.Services
{
    public class SpeciesDataManager : IDataManager<SpeciesData>, IExportable
    {
        public void Add(SpeciesData item)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO SpeciesData (SpeciesId, DateTime, Location, Population) VALUES (@SpeciesId, @DateTime, @Location, @Population)";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SpeciesId", item.SpeciesId);
                    command.Parameters.AddWithValue("@DateTime", item.DateTime);
                    command.Parameters.AddWithValue("@Location", item.Location);
                    command.Parameters.AddWithValue("@Population", item.Population);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remove(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM SpeciesData WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public SpeciesData? GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM SpeciesData WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new SpeciesData
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                SpeciesId = Convert.ToInt32(reader["SpeciesId"]),
                                DateTime = Convert.ToDateTime(reader["DateTime"]),
                                Location = reader["Location"]?.ToString() ?? string.Empty,
                                Population = Convert.ToInt32(reader["Population"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<SpeciesData> GetAll()
        {
            var data = new List<SpeciesData>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM SpeciesData";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new SpeciesData
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                SpeciesId = Convert.ToInt32(reader["SpeciesId"]),
                                DateTime = Convert.ToDateTime(reader["DateTime"]),
                                Location = reader["Location"]?.ToString() ?? string.Empty,
                                Population = Convert.ToInt32(reader["Population"])
                            });
                        }
                    }
                }
            }
            return data;
        }

        public List<SpeciesData> FilterByDate(DateTime startDate, DateTime endDate)
        {
            return GetAll().Where(x => x.DateTime >= startDate && x.DateTime <= endDate).ToList();
        }

        public List<SpeciesData> FilterByLocation(string location)
        {
            return GetAll().Where(x => x.Location == location).ToList();
        }

        public void AddSpecies(Species species)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Species (SpeciesName) VALUES (@SpeciesName)";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SpeciesName", species.SpeciesName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Species> GetAllSpecies()
        {
            var speciesList = new List<Species>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Species";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            speciesList.Add(new Species
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                SpeciesName = reader["SpeciesName"]?.ToString() ?? string.Empty
                            });
                        }
                    }
                }
            }
            return speciesList;
        }

        public List<SpeciesData> FilterBySpecies(int id)
        {
            return GetAll().Where(x => x.SpeciesId == id).ToList();
        }

        public List<SpeciesData> FilterByPopulationRange(int min, int max)
        {
            return GetAll().Where(x => x.Population >= min && x.Population <= max).ToList();
        }

        public string ExportToCsv(DateTime? startDate, DateTime? endDate, string location)
        {
            var data = GetAll();
            var species = GetAllSpecies().ToDictionary(s => s.Id, s => s.SpeciesName);

            if (startDate.HasValue && endDate.HasValue)
            {
                data = data.Where(x => x.DateTime >= startDate.Value && x.DateTime <= endDate.Value).ToList();
            }

            if (!string.IsNullOrEmpty(location))
            {
                data = data.Where(x => x.Location == location).ToList();
            }

            var csv = new StringBuilder();
            csv.AppendLine("Id,SpeciesName,DateTime,Location,Population");

            foreach (var item in data)
            {
                var speciesName = species.ContainsKey(item.SpeciesId) ? species[item.SpeciesId] : "Unknown";
                csv.AppendLine($"{item.Id},{speciesName},{item.DateTime},{item.Location},{item.Population}");
            }

            return csv.ToString();
        }
    }
}