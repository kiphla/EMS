using System;

namespace EMS.Core.Interfaces
{
    public interface IExportable
    {
        string ExportToCsv(DateTime? startDate, DateTime? endDate, string location);
    }
}