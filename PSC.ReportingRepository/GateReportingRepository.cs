using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PSC.ReportingRepository
{
    public class GateReportingRepository : IGateReportingRepository
    {
        MySqlDataReader reader;
        public GateReportingRepository()
        {
        }

        public IList<Gate> GetAllGate()
        {
            reader = reader.Query("SELECT * FROM gate");
            IList<Gate> gates = new List<Gate>();
            while (reader.Read())
            {
                gates.Add(new Gate(reader["id"].ToInt(), reader["gatename"].ToString()));
            }
            reader.Close();
            return gates;
        }
        public Gate GetById(int id)
        {
            reader = reader.Query("SELECT * FROM gate where id = '" + id + "'");
            Gate gate = new Gate();
            while (reader.Read())
            {
                gate = new Gate(reader["id"].ToInt(), reader["gatename"].ToString());
            }
            reader.Close();
            return gate;
        }
    }
}
