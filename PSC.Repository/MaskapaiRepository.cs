using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.Repository
{
    public class MaskapaiRepository : IMaskapaiRepository
    {
        public MaskapaiRepository() { }
        public void AddMaskapai(AddMaskapai p)
        {
            string cmd = string.Format("INSERT INTO maskapai (name,jenisid) values('{0}','{1}')",
                    p.Name, p.JenisId);
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
        }
        public void UpdateMaskapai(UpdateMaskapai m)
        {
            string cmd = string.Format("UPDATE maskapai set name='{0}', jenisid='{1}' where id='{2}'",
                    m.Name, m.JenisId, m.Id);
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
        }
        public void DeleteMaskapai(int id)
        {
            string cmd = string.Format("DELETE from maskapai where id = '"+ id +"'");
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
        }
    }
}
