using EMS.Core.Models;
using EMS.Core.Interfaces;
using EMS.Core.Services.BaseServices;
using EMS.Core.Utilities;
using Microsoft.Data.Sqlite;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace EMS.Core.Services
{
    public class HydrologyDataManager : BaseDataManager<HydrologyData>, IDataManager<HydrologyData>, IExportable
    {
        protected override string TableName => "HydrologyData";

        protected override string InsertQuery =>
            "INSERT INTO HydrologyData (DateTime, Location, WaterLevel, Rainfall, Salinity, PH, DissolvedOxygen, Turbidity, Temperature) " +
            "VALUES (@DateTime, @Location, @WaterLevel, @Rainfall, @Salinity, @PH, @DissolvedOxygen, @Turbidity, @Temperature)";

        protected override void SetInsertParameters(SqliteCommand command, HydrologyData item)
        {
            command.Parameters.AddWithValue("@DateTime", item.DateTime);
            command.Parameters.AddWithValue("@Location", item.Location);
            command.Parameters.AddWithValue("@WaterLevel", item.WaterLevel);
            command.Parameters.AddWithValue("@Rainfall", item.Rainfall);
            command.Parameters.AddWithValue("@Salinity", item.Salinity);
            command.Parameters.AddWithValue("@PH", item.PHLevel);
            command.Parameters.AddWithValue("@DissolvedOxygen", item.DissolvedOxygen);
            command.Parameters.AddWithValue("@Turbidity", item.Turbidity);
            command.Parameters.AddWithValue("@Temperature", item.Temperature);
        }

        protected override HydrologyData MapToModel(SqliteDataReader reader)
        {
            return new HydrologyData
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                DateTime = reader.GetDateTime(reader.GetOrdinal("DateTime")),
                Location = reader.GetString(reader.GetOrdinal("Location")),
                WaterLevel = reader.GetDouble(reader.GetOrdinal("WaterLevel")),
                Rainfall = reader.GetDouble(reader.GetOrdinal("Rainfall")),
                Salinity = reader.GetDouble(reader.GetOrdinal("Salinity")),
                PHLevel = reader.GetDouble(reader.GetOrdinal("PH")),
                DissolvedOxygen = reader.GetDouble(reader.GetOrdinal("DissolvedOxygen")),
                Turbidity = reader.GetDouble(reader.GetOrdinal("Turbidity")),
                Temperature = reader.GetDouble(reader.GetOrdinal("Temperature"))
            };
        }

        public override HydrologyData? GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM HydrologyData WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new HydrologyData
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DateTime = Convert.ToDateTime(reader["DateTime"]),
                                Location = reader["Location"]?.ToString() ?? string.Empty,
                                WaterLevel = Convert.ToDouble(reader["WaterLevel"]),
                                Rainfall = Convert.ToDouble(reader["Rainfall"]),
                                Salinity = Convert.ToDouble(reader["Salinity"]),
                                PHLevel = Convert.ToDouble(reader["PH"]),
                                DissolvedOxygen = Convert.ToDouble(reader["DissolvedOxygen"]),
                                Turbidity = Convert.ToDouble(reader["Turbidity"]),
                                Temperature = Convert.ToDouble(reader["Temperature"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public override List<HydrologyData> GetAll()
        {
            var data = new List<HydrologyData>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM HydrologyData";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new HydrologyData
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DateTime = Convert.ToDateTime(reader["DateTime"]),
                                Location = reader["Location"]?.ToString() ?? string.Empty,
                                WaterLevel = Convert.ToDouble(reader["WaterLevel"]),
                                Rainfall = Convert.ToDouble(reader["Rainfall"]),
                                Salinity = Convert.ToDouble(reader["Salinity"]),
                                PHLevel = Convert.ToDouble(reader["PH"]),
                                DissolvedOxygen = Convert.ToDouble(reader["DissolvedOxygen"]),
                                Turbidity = Convert.ToDouble(reader["Turbidity"]),
                                Temperature = Convert.ToDouble(reader["Temperature"])
                            });
                        }
                    }
                }
            }
            return data;
        }

        public List<HydrologyData> FilterByDate(DateTime startDate, DateTime endDate)
        {
            return GetAll().Where(x => x.DateTime >= startDate && x.DateTime <= endDate).ToList();
        }

        public List<HydrologyData> FilterByLocation(string location)
        {
            return GetAll().Where(x => x.Location == location).ToList();
        }

        public List<HydrologyData> FilterByPHRange(double minPH, double maxPH)
        {
            return GetAll().Where(x => x.PHLevel >= minPH && x.PHLevel <= maxPH).ToList();
        }

        public List<HydrologyData> FilterByWaterLevelRange(double min, double max)
        {
            return GetAll().Where(x => x.WaterLevel >= min && x.WaterLevel <= max).ToList();
        }

        public string ExportToCsv(DateTime? startDate, DateTime? endDate, string location)
        {
            var data = GetAll();

            if (startDate.HasValue && endDate.HasValue)
            {
                data = data.Where(x => x.DateTime >= startDate.Value && x.DateTime <= endDate.Value).ToList();
            }

            if (!string.IsNullOrEmpty(location))
            {
                data = data.Where(x => x.Location == location).ToList();
            }

            var csv = new StringBuilder();
            csv.AppendLine("Id,DateTime,Location,WaterLevel,Rainfall,Salinity,PHLevel,DissolvedOxygen,Turbidity,Temperature");

            foreach (var item in data)
            {
                csv.AppendLine($"{item.Id},{item.DateTime},{item.Location},{item.WaterLevel},{item.Rainfall},{item.Salinity},{item.PHLevel},{item.DissolvedOxygen},{item.Turbidity},{item.Temperature}");
            }

            return csv.ToString();
        }
    }
}