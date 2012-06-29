using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public interface IMaskapaiRepository
    {
        void AddMaskapai(AddMaskapai p);
        void UpdateMaskapai(UpdateMaskapai m);
        void DeleteMaskapai(int id);
    }
}
