using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.Repository
{
    public class PegawaiRepository : IPegawaiRepository
    {
        public PegawaiRepository() { }
        public void AddPegawai(AddPegawai p)
        {
            string cmd = string.Format("INSERT INTO pegawai (nip,nama,agama,ttl,alamat,notelp) values('{0}','{1}','{2}','{3}','{4}','{5}')",
                    p.NIP, p.Name, p.Agama, p.TTL, p.Alamat, p.Telpon);
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
        }
        public void UpdatePegawai(UpdatePegawai p)
        {
            string cmd = string.Format("UPDATE pegawai set nip='{0}', nama='{1}', agama='{2}', ttl='{3}', alamat='{4}', notelp='{5}' where id='{6}'",
                p.NIP, p.Name, p.Agama, p.TTL, p.Alamat, p.Telpon,p.Id);
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
        }
        public void DeletePegawai(int id)
        {
            string cmd = string.Format("DELETE from pegawai where id = " + id);
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
        }
    }
}
