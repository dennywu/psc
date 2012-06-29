using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public interface IGateRepository
    {
        void AddGate(AddGate p);
        void UpdateGate(UpdateGate m);
        void DeleteGate(int id);
    }
}
