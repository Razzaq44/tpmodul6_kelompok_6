using System;
using System.Collections.Generic;

namespace Minggu6
{
    public class Mahasiswa
    {
        public NamaMahasiswa nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public Mahasiswa() { }
    }

    public class NamaMahasiswa
    {
        public string depan { get; set; }
        public string belakang { get; set; }

        public NamaMahasiswa() { }
    }
}
