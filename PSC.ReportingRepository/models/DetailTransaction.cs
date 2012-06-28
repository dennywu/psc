using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public class DetailTransaction
    {
        public DateTime Tanggal { get; set; }
        public string TransactionNo { get; set; }
        public string FlightNo { get; set; }
        public string Maskapai { get; set; }
        public decimal Amount { get; set; }

        public DetailTransaction(string tanggal, string transactionNo, string flightNo, string maskapai, decimal amount)
        {
            string[] date = tanggal.Split('-');
            this.Tanggal = new DateTime(int.Parse(date[0]),int.Parse(date[1]),int.Parse(date[2]));
            this.TransactionNo = transactionNo;
            this.FlightNo = flightNo;
            this.Maskapai = maskapai;
            this.Amount = amount;
        }
    }
}
