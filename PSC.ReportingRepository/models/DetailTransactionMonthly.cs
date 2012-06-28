using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public class DetailTransactionMonthly
    {
        public string Tanggal { get; set; }
        public decimal Amount { get; set; }

        public DetailTransactionMonthly(string tanggal, decimal amount)
        {
            this.Tanggal = tanggal;
            this.Amount = amount;
        }
    }
}
