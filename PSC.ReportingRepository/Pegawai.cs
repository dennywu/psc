using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSC.ReportingRepository
{
    public class Pegawai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public string TTL { get; set; }
        public string Agama { get; set; }
        public string Alamat { get; set; }
        public string Telpon { get; set; }

        public Pegawai(){}
        public Pegawai(int id, string name, string nip, string ttl, string agama, string alamat, string telp)
        {
            this.Id = id;
            this.Name = name;
            this.NIP = nip;
            this.TTL = ttl;
            this.Agama = agama;
            this.Alamat = alamat;
            this.Telpon = telp;
        }
    }
}
