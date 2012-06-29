using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public interface IMaskapaiReportingRepository
    {
        IList<Maskapai> GetAllMaskapai();
        Maskapai GetById(int id);
    }
}
