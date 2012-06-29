using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public interface IPegawaiReportingRepository
    {
        IList<Pegawai> GetAll();
        Pegawai GetPegawaiById(int id);
    }
}
