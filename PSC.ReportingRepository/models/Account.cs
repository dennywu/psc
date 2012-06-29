using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }

        public Account() { }
        public Account(int id, string username, string password, int role)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
    }
}
