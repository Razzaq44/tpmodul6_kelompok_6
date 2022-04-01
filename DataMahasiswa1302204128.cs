using System;
using System.Text.Json;
using System.IO;

namespace Minggu6
{
    public class DataMahasiswa
    {        
        public static Mahasiswa ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string pathAndFile = path + "/tp6_1_1302204128.json";
            string json = File.ReadAllText(pathAndFile);

            Mahasiswa objHasilDeserialisasi = JsonSerializer.Deserialize<Mahasiswa>(json);

            return objHasilDeserialisasi;
        }
    }
}