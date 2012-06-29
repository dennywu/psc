using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace PSC.ReportingRepository
{
    public class AccountReportingRepository : IAccountReportingRepository
    {
        MySqlDataReader reader;
        public AccountReportingRepository()
        {
        }
        public Account FindAccountByUsername(string username)
        {
            reader = reader.Query("SELECT * FROM user where username = '" + username + "'");
            Account acc = new Account();
            while (reader.Read())
            {
                acc = new Account(int.Parse(reader["userid"].ToString()), reader["username"].ToString(), reader["password"].ToString(), int.Parse(reader["role"].ToString()));
            }
            return acc;
        }
    }
}
