using System;
using System.Text.Json;
using System.IO;

namespace Minggu6
{
    public class program
    {
        public static void Main(string[] args)
        {
            Mahasiswa objHasilBaca = DataMahasiswa.ReadJSON();
            Console.WriteLine("nama " + objHasilBaca.nama.depan + " " + objHasilBaca.nama.belakang + " dengan nim " + objHasilBaca.nim + " dari fakultas " + objHasilBaca.fakultas);
        }
    }
}