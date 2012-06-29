using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public class AddMaskapai
    {
        public string Name { get; set; }
        public int JenisId { get; set; }
        public string JenisName { get; set; }
        public decimal Amount { get; set; }

        public AddMaskapai() { }
        public AddMaskapai(string name, int jenisId, string jenisname, decimal amount)
        {
            this.Name = name;
            this.JenisId = jenisId;
            this.JenisName = jenisname;
            this.Amount = amount;
        }
    }
}
