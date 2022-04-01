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
            Mahasiswa objHasilBacaMatkul = KuliahMahasiswa.ReadJson();
            Console.WriteLine("Nama " + objHasilBaca.nama.depan + " " + objHasilBaca.nama.belakang + " dengan nim " + objHasilBaca.nim + " dari fakultas " + objHasilBaca.fakultas);
            Console.WriteLine();

            for (int i = 0; i < objHasilBacaMatkul.matakuliah.Count; i++)
            {
                MataKuliah matkul = objHasilBacaMatkul.matakuliah[i];
                Console.WriteLine("MK " + (i + 1) + " " +matkul.KodeMataKuliah + " - " + matkul.NamaMataKuliah);
            }
        }
    }
}