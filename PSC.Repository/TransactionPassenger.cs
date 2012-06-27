using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public class TransactionPassenger
    {
        public string TransactionNo { get; set; }
        public DateTime Tanggal { get; set; }
        public string JenisPenerbangan { get; set; }
        public string Gate { get; set; }
        public string Maskapai { get; set; }
        public string Amount { get; set; }
        public string PassengerName { get; set; }
        public string FlightNo { get; set; }
    }
}
