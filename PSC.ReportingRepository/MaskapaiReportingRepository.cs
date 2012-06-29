using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.ReportingRepository
{
    public class MaskapaiReportingRepository : IMaskapaiReportingRepository
    {
        MySqlDataReader reader;
        public MaskapaiReportingRepository()
        {
        }

        public IList<Maskapai> GetAllMaskapai()
        {
            reader = reader.Query("SELECT m.*,t.amount FROM maskapai m inner join jenis_penerbangan t on m.jenisid = t.id");
            IList<Maskapai> maskapai = new List<Maskapai>();
            while (reader.Read())
            {
                maskapai.Add(new Maskapai(reader["id"].ToInt(), reader["name"].ToString(), reader["jenisid"].ToInt(),reader["amount"].ToDecimal()));
            }
            return maskapai;
        }
        public Maskapai GetById(int id)
        {
            reader = reader.Query("SELECT m.*,t.amount FROM maskapai m inner join jenis_penerbangan t on m.jenisid = t.id where m.id = '" + id + "'");
            Maskapai maskapai = new Maskapai();
            while (reader.Read())
            {
                maskapai = new Maskapai(reader["id"].ToInt(), reader["name"].ToString(), reader["jenisid"].ToInt(),reader["amount"].ToDecimal());
            }
            return maskapai;
        }
    }
}
