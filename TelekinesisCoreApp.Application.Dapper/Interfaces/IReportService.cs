using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelekinesisCoreApp.Application.Dapper.ViewModels;

namespace TelekinesisCoreApp.Application.Dapper.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetReportAsync(string fromDate, string toDate);
    }
}
