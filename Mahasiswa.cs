using System;
using System.Collections.Generic;

namespace Minggu6
{
    public class Mahasiswa
    {
        public NamaMahasiswa nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
        public List<MataKuliah> matakuliah { get; set; }

        public Mahasiswa() { }
    }

    public class NamaMahasiswa
    {
        public string depan { get; set; }
        public string belakang { get; set; }

        public NamaMahasiswa() { }
    }

    public class MataKuliah
    {
        public string NamaMataKuliah { get; set; }
        public string KodeMataKuliah { get; set; }
        public MataKuliah() { }
    }
}
