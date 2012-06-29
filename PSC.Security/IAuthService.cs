using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSC.ReportingRepository;

namespace PSC.Security
{
    public interface IAuthService
    {
        Account Login(string username, string password);
    }
}
