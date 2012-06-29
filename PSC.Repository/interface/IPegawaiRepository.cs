using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public interface IPegawaiRepository
    {
        void AddPegawai(AddPegawai p);
        void UpdatePegawai(UpdatePegawai p);
        void DeletePegawai(int id);
    }
}
