using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.Repository
{
    public class TransactionPassengerRepository : ITransactionPassengerRepository
    {
        public TransactionPassengerRepository() { }

        public void AddTransactionPassenger(TransactionPassenger t)
        {
            string date = string.Format("{0}-{1}-{2}", t.Tanggal.Year, t.Tanggal.Month, t.Tanggal.Day);
            string cmd = string.Format("INSERT INTO passanger (notransaction,tanggal,jenis,gate,maskapai,amount,passengername,flightno) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    t.TransactionNo, date, t.JenisPenerbangan, t.Gate, t.Maskapai, t.Amount, t.PassengerName, t.FlightNo);
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
        }
    }
}
