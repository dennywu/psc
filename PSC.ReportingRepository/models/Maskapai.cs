using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public class Maskapai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int JenisId { get; set; }
        public decimal Amount { get; set; }

        public Maskapai() { }
        public Maskapai(int id, string name, int jenisId,decimal amount)
        {
            this.Id = id;
            this.Name = name;
            this.JenisId = jenisId;
            this.Amount = amount;
        }
    }
}
