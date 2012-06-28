using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public interface IReportRepository
    {
        IList<DetailTransaction> GetDetailTransactionByDate(string from, string to);
        IList<DetailTransactionDaily> GetDetailTransactionDailyByDate(string from, string to);
        IList<DetailTransactionMonthly> GetDetailTransactionMonthlyByDate(string from, string to);
    }
}
