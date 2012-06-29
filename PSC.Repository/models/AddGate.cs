using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public class AddGate
    {
        public string Name { get; set; }

        public AddGate() { }
        public AddGate(string name)
        {
            this.Name = name;
        }
    }
}
