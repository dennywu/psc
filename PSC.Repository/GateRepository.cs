using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.Repository
{
    public class GateRepository : IGateRepository
    {
        public void AddGate(AddGate p)
        {
            string cmd = string.Format("INSERT INTO gate (gatename) values('{0}')",
                    p.Name);
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
            conn.Close();
        }
        public void UpdateGate(UpdateGate m)
        {
            string cmd = string.Format("UPDATE gate set gatename='{0}' where id='{1}'",
                    m.Name, m.Id);
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
            conn.Close();
        }
        public void DeleteGate(int id)
        {
            string cmd = string.Format("DELETE from gate where id = '" + id + "'");
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            conn.Open();
            MySqlCommand command = new MySqlCommand(cmd, conn);
            command.ExecuteReader();
            conn.Close();
        }
    }
}
