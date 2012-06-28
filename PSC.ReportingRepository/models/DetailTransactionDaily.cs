using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public class DetailTransactionDaily
    {
        public DateTime Tanggal { get; set; }
        public decimal Amount { get; set; }

        public DetailTransactionDaily(string tanggal,decimal amount)
        {
            string[] date = tanggal.Split('-');
            this.Tanggal = new DateTime(int.Parse(date[0]),int.Parse(date[1]),int.Parse(date[2]));
            this.Amount = amount;
        }
    }
}
