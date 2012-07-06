using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.ReportingRepository
{
    public static class ReportingRepositoryHelper
    {
        public static MySqlDataReader Query(this MySqlDataReader reader, string qry)
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            if(reader != null)
                reader.Dispose();
            reader = cmd.ExecuteReader();
            return reader;
        }
        public static int ToInt(this object data)
        {
            return int.Parse(data.ToString());
        }
        public static decimal ToDecimal(this object data)
        {
            return decimal.Parse(data.ToString());
        }
    }
}
