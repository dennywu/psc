using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public interface ITransactionPassengerRepository
    {
        void AddTransactionPassenger(TransactionPassenger t);
    }
}
