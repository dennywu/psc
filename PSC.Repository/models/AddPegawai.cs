using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.Repository
{
    public class AddPegawai
    {
        public string Name { get; set; }
        public string NIP { get; set; }
        public string TTL { get; set; }
        public string Agama { get; set; }
        public string Alamat { get; set; }
        public string Telpon { get; set; }

        public AddPegawai(){}
        public AddPegawai(string name, string nip, string ttl, string agama, string alamat, string telp)
        {
            this.Name = name;
            this.NIP = nip;
            this.TTL = ttl;
            this.Agama = agama;
            this.Alamat = alamat;
            this.Telpon = telp;
        }
    }
}
