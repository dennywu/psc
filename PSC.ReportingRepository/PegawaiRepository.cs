using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.ReportingRepository
{
    public class PegawaiRepository : IPegawaiRepository
    {
        MySqlDataReader reader;
        public PegawaiRepository() { }
        public IList<Pegawai> GetAll()
        {
            reader = reader.Query("SELECT * FROM pegawai");
            IList<Pegawai> pegawai = new List<Pegawai>();
            while (reader.Read())
            {
                pegawai.Add(new Pegawai(reader["id"].ToInt(),reader["nama"].ToString(), reader["nip"].ToString(), reader["ttl"].ToString(), reader["agama"].ToString(),reader["alamat"].ToString(),reader["notelp"].ToString()));
            }
            return pegawai;
        }
    }
}
