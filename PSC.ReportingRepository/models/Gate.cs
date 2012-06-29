using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public class Gate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Gate() { }
        public Gate(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
