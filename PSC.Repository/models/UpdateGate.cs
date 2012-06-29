using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public class UpdateGate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UpdateGate() { }
        public UpdateGate(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
