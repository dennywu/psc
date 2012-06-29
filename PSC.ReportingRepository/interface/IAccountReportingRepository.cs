using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public interface IAccountReportingRepository
    {
        Account FindAccountByUsername(string username);
    }
}
