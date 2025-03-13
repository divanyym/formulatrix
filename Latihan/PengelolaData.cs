using System;

namespace FormulatrixTraining
{
    public class PengelolaData
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
}
