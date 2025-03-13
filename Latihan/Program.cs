using System; // Menggunakan namespace System untuk akses fungsi standar seperti Console.

namespace Formulatrix
{
    // Struktur untuk menyimpan data pengguna
    public struct DataPengguna
    {
        public string Nama { get; }
        public string Alamat { get; }
        public int Umur { get; }
        public double TinggiBadan { get; }
        public bool Pelajar { get; }
        public char JenisKelamin { get; }

        public DataPengguna(string nama, string alamat, int umur, double tinggiBadan, bool pelajar, char jenisKelamin)
        {
            Nama = nama;
            Alamat = alamat;
            Umur = umur;
            TinggiBadan = tinggiBadan;
            Pelajar = pelajar;
            JenisKelamin = char.ToUpper(jenisKelamin);
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"\nNama: {Nama}");
            Console.WriteLine($"Alamat: {Alamat}");
            Console.WriteLine($"Umur: {Umur} tahun");
            Console.WriteLine($"Tinggi Badan: {TinggiBadan} cm");
            Console.WriteLine($"Pelajar: {(Pelajar ? "Ya" : "Tidak")}");
            Console.WriteLine($"Jenis Kelamin: {JenisKelamin}");
        }
    }
}
