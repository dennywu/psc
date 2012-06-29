using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSC.ReportingRepository;

namespace PSC.Security
{
    public class AuthService : IAuthService
    {
        IAccountReportingRepository accRepo;
        public AuthService()
        {
            accRepo = new AccountReportingRepository();
        }
        public Account Login(string username, string password)
        {
            Account acc = accRepo.FindAccountByUsername(username);
            if (acc == null || acc.Password != password)
                throw new ApplicationException("Username atau Password anda salah");
            return acc;
        }
    }
}
