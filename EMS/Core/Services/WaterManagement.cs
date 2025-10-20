using System;
using System.Collections.Generic;
using System.Linq;
using EMS.Core.Models;
using EMS.Core.Repositories;

namespace EMS.Core.Services
{
    public class WaterManagement
    {
        private readonly WaterRepository _waterRepository;
        private readonly NotificationsRepository _notificationsRepository;

        public WaterManagement()
        {
            _waterRepository = new WaterRepository();
            _notificationsRepository = new NotificationsRepository();
        }

        public void AddWaterData(WaterData waterData)
        {
            _waterRepository.Add(waterData);
            CheckWaterConditionsAndNotify(waterData);
        }

        public List<WaterData> GetAllWaterData()
        {
            return _waterRepository.GetAll();
        }

        public WaterData? GetWaterDataById(int sampleId)
        {
            return _waterRepository.GetById(sampleId);
        }

        public List<WaterData> GetWaterDataInRange(DateTime startDate, DateTime endDate)
        {
            return _waterRepository.GetAll()
                .Where(w => w.date >= startDate && w.date <= endDate)
                .OrderBy(w => w.date)
                .ToList();
        }

        private void CheckWaterConditionsAndNotify(WaterData waterData)
        {
            // Check pH levels
            if (waterData.pH < 6.5 || waterData.pH > 8.5)
            {
                CreateWaterAlert("pH Level Alert",
                    $"Water pH level is {waterData.pH}, outside normal range (6.5-8.5)");
            }

            // Check dissolved oxygen
            if (waterData.dissolvedOxygen < 5)
            {
                CreateWaterAlert("Low Dissolved Oxygen",
                    $"Dissolved oxygen level is {waterData.dissolvedOxygen} mg/L, below minimum safe level");
            }

            // Check turbidity
            if (waterData.turbidity > 5)
            {
                CreateWaterAlert("High Turbidity",
                    $"Water turbidity is {waterData.turbidity} NTU, above acceptable level");
            }
        }

        private void CreateWaterAlert(string title, string description)
        {
            var notification = new Notification
            {
                userID = 1, // TODO: Get current user ID
                creationDate = DateTime.Now,
                terminationDate = DateTime.Now.AddDays(7),
                isActive = true,
                title = title,
                description = description
            };

            _notificationsRepository.Add(notification);
        }

        public Dictionary<string, double> CalculateAverages(List<WaterData> waterData)
        {
            if (waterData == null || !waterData.Any())
                return new Dictionary<string, double>();

            return new Dictionary<string, double>
            {
                { "pH", waterData.Average(w => w.pH) },
                { "DissolvedOxygen", waterData.Average(w => w.dissolvedOxygen) },
                { "Salinity", waterData.Average(w => w.salinity) },
                { "Turbidity", waterData.Average(w => w.turbidity) },
                { "Hardness", waterData.Average(w => w.hardness) },
                { "EutrophicPotential", waterData.Average(w => w.eutrophicPotential) }
            };
        }
    }
}
