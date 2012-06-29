using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.ReportingRepository
{
    public class PegawaiReportingRepository : IPegawaiReportingRepository
    {
        MySqlDataReader reader;
        public PegawaiReportingRepository() { }
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

        public Pegawai GetPegawaiById(int id)
        {
            reader = reader.Query("SELECT * FROM pegawai where id = '" + id + "'");
            Pegawai pegawai = new Pegawai();
            while (reader.Read())
            {
                pegawai = new Pegawai(reader["id"].ToInt(), reader["nama"].ToString(), reader["nip"].ToString(), reader["ttl"].ToString(), reader["agama"].ToString(), reader["alamat"].ToString(), reader["notelp"].ToString());
            }
            return pegawai;
        }
    }
}
