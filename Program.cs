using System;

namespace FormulatrixTraining
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

    class PengelolaData
    {
        private readonly DataPengguna[] _pengguna;

        public PengelolaData(int jumlahPengguna)
        {
            _pengguna = new DataPengguna[jumlahPengguna];
        }

        public void KumpulkanData()
        {
            for (int i = 0; i < _pengguna.Length; i++)
            {
                Console.WriteLine($"\nData ke-{i + 1}:");

                string nama = InputString("Nama");
                string alamat = InputString("Alamat");
                int umur = InputInt("Umur");
                double tinggi = InputDouble("Tinggi Badan (cm)");
                bool pelajar = InputBool("Apakah Anda seorang pelajar? (true/false)");
                char jenisKelamin = InputChar("Jenis Kelamin (L/P)");

                _pengguna[i] = new DataPengguna(nama, alamat, umur, tinggi, pelajar, jenisKelamin);
            }
        }

        public void TampilkanSemuaData()
        {
            Console.WriteLine("\n=== DATA TELAH TERSIMPAN ===");
            foreach (var pengguna in _pengguna)
            {
                pengguna.TampilkanInfo();
            }
        }

        // Metode tambahan untuk validasi input
        private static string InputString(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine() ?? "Tidak diketahui";
        }

        private static int InputInt(string prompt)
        {
            Console.Write($"{prompt}: ");
            return int.TryParse(Console.ReadLine(), out int nilai) ? nilai : 0;
        }

        private static double InputDouble(string prompt)
        {
            Console.Write($"{prompt}: ");
            return double.TryParse(Console.ReadLine(), out double nilai) ? nilai : 0.0;
        }

        private static bool InputBool(string prompt)
        {
            Console.Write($"{prompt}: ");
            return bool.TryParse(Console.ReadLine(), out bool nilai) && nilai;
        }

        private static char InputChar(string prompt)
        {
            Console.Write($"{prompt}: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== FORMULATRIX TRAINING ===");

            const int jumlahPengguna = 3;
            PengelolaData pengelola = new PengelolaData(jumlahPengguna);

            pengelola.KumpulkanData();
            pengelola.TampilkanSemuaData();
        }
    }
}
