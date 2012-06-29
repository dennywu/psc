using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public interface IGateReportingRepository
    {
        IList<Gate> GetAllGate();
        Gate GetById(int id);
    }
}
