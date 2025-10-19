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
    public class SoilDataManager : BaseDataManager<SoilData>, IDataManager<SoilData>, IExportable
    {
        protected override string TableName => "SoilData";

        protected override string InsertQuery =>
            "INSERT INTO SoilData (DateTime, Location, PH, Moisture, Nitrogen, Phosphorus, Sulphur) " +
            "VALUES (@DateTime, @Location, @PH, @Moisture, @Nitrogen, @Phosphorus, @Sulphur)";

        protected override void SetInsertParameters(SqliteCommand command, SoilData item)
        {
            command.Parameters.AddWithValue("@DateTime", item.DateTime);
            command.Parameters.AddWithValue("@Location", item.Location);
            command.Parameters.AddWithValue("@PH", item.PHLevel);
            command.Parameters.AddWithValue("@Moisture", item.MoistureLevel);
            command.Parameters.AddWithValue("@Nitrogen", item.NitrogenLevel);
            command.Parameters.AddWithValue("@Phosphorus", item.PhosphorusLevel);
            command.Parameters.AddWithValue("@Sulphur", item.SulphurLevel);
        }

        protected override SoilData MapToModel(SqliteDataReader reader)
        {
            return new SoilData
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                DateTime = reader.GetDateTime(reader.GetOrdinal("DateTime")),
                Location = reader.GetString(reader.GetOrdinal("Location")),
                PHLevel = reader.GetDouble(reader.GetOrdinal("PH")),
                MoistureLevel = reader.GetDouble(reader.GetOrdinal("Moisture")),
                NitrogenLevel = reader.GetDouble(reader.GetOrdinal("Nitrogen")),
                PhosphorusLevel = reader.GetDouble(reader.GetOrdinal("Phosphorus")),
                SulphurLevel = reader.GetDouble(reader.GetOrdinal("Sulphur"))
            };
        }

        public override SoilData? GetById(int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM SoilData WHERE Id = @Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new SoilData
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DateTime = Convert.ToDateTime(reader["DateTime"]),
                                Location = reader["Location"]?.ToString() ?? string.Empty,
                                PHLevel = Convert.ToDouble(reader["PH"]),
                                MoistureLevel = Convert.ToDouble(reader["Moisture"]),
                                NitrogenLevel = Convert.ToDouble(reader["Nitrogen"]),
                                PhosphorusLevel = Convert.ToDouble(reader["Phosphorus"]),
                                SulphurLevel = Convert.ToDouble(reader["Sulphur"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public override List<SoilData> GetAll()
        {
            var data = new List<SoilData>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM SoilData";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new SoilData
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DateTime = Convert.ToDateTime(reader["DateTime"]),
                                Location = reader["Location"]?.ToString() ?? string.Empty,
                                PHLevel = Convert.ToDouble(reader["PH"]),
                                MoistureLevel = Convert.ToDouble(reader["Moisture"]),
                                NitrogenLevel = Convert.ToDouble(reader["Nitrogen"]),
                                PhosphorusLevel = Convert.ToDouble(reader["Phosphorus"]),
                                SulphurLevel = Convert.ToDouble(reader["Sulphur"])
                            });
                        }
                    }
                }
            }
            return data;
        }

        public List<SoilData> FilterByDate(DateTime startDate, DateTime endDate)
        {
            return GetAll().Where(x => x.DateTime >= startDate && x.DateTime <= endDate).ToList();
        }

        public List<SoilData> FilterByLocation(string location)
        {
            return GetAll().Where(x => x.Location == location).ToList();
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
            csv.AppendLine("Id,DateTime,Location,PHLevel,MoistureLevel,NitrogenLevel,PhosphorusLevel,SulphurLevel");

            foreach (var item in data)
            {
                csv.AppendLine($"{item.Id},{item.DateTime},{item.Location},{item.PHLevel},{item.MoistureLevel},{item.NitrogenLevel},{item.PhosphorusLevel},{item.SulphurLevel}");
            }

            return csv.ToString();
        }
    }
}