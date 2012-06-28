using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.ReportingRepository
{
    public class ReportRepository : IReportRepository
    {
        MySqlDataReader reader;
        public ReportRepository() { }

        public IList<DetailTransaction> GetDetailTransactionByDate(string from, string to)
        {
            reader = reader.Query("SELECT *, DATE_FORMAT(DATE(tanggal),'%Y-%m-%e') as transactiondate FROM passanger where tanggal between '" + from + "' and '" + to + "'");
            IList<DetailTransaction> details = new List<DetailTransaction>();
            while (reader.Read())
            {
                details.Add(new DetailTransaction(reader["transactiondate"].ToString(), reader["notransaction"].ToString(), reader["flightno"].ToString(), reader["maskapai"].ToString(), reader["amount"].ToDecimal()));
            }
            return details;
        }
        public IList<DetailTransactionDaily> GetDetailTransactionDailyByDate(string from, string to)
        {
            reader = reader.Query("SELECT *,sum(amount) as total, DATE_FORMAT(DATE(tanggal),'%Y-%m-%e') as transactiondate FROM passanger where tanggal between '" + from + "' and '" + to + "' group by tanggal");
            IList<DetailTransactionDaily> details = new List<DetailTransactionDaily>();
            while (reader.Read())
            {
                details.Add(new DetailTransactionDaily(reader["transactiondate"].ToString(),reader["total"].ToDecimal()));
            }
            return details;
        }

        public IList<DetailTransactionMonthly> GetDetailTransactionMonthlyByDate(string from, string to)
        {
            reader = reader.Query("select max( tanggal) as tanggal, ym,sum(amount) as amount from "+
                                    "( SELECT tanggal,  DATE_FORMAT(DATE(tanggal),'%m-%Y') as ym, amount "+
					                "FROM passanger "+
                                    "WHERE DATE_FORMAT(DATE(tanggal),'%Y%m') between '"+ from +"' and '"+ to +"') as g "+
                                    "group by g.ym");
            IList<DetailTransactionMonthly> details = new List<DetailTransactionMonthly>();
            while (reader.Read())
            {
                details.Add(new DetailTransactionMonthly(reader["ym"].ToString(), reader["amount"].ToDecimal()));
            }
            return details;
        }
    }
}
