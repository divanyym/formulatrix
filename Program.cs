using System;

namespace FormulatrixTraining
{
    // Struct untuk menyimpan data pengguna
    public struct UserData
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }  // Menggunakan double untuk tinggi badan
        public bool IsStudent { get; set; } // Menggunakan bool untuk status pelajar
        public char Gender { get; set; }    // Menggunakan char untuk jenis kelamin (L/P)

        public void DisplayInfo()
        {
            Console.WriteLine($"\nNama: {Nama}");
            Console.WriteLine($"Alamat: {Alamat}");
            Console.WriteLine($"Umur: {Age} tahun");
            Console.WriteLine($"Tinggi Badan: {Height} cm");
            Console.WriteLine($"Pelajar: {(IsStudent ? "Ya" : "Tidak")}");
            Console.WriteLine($"Jenis Kelamin: {Gender}");
        }
    }

    class UserDataProcessor
    {
        private UserData[] _users;

        public UserDataProcessor(int totalUsers)
        {
            _users = new UserData[totalUsers];
        }

        public void CollectUserData()
        {
            for (int i = 0; i < _users.Length; i++)
            {
                Console.WriteLine($"\nData ke-{i + 1}:");

                Console.Write("Nama: ");
                _users[i].Nama = Console.ReadLine() ?? "Tidak diketahui";

                Console.Write("Alamat: ");
                _users[i].Alamat = Console.ReadLine() ?? "Tidak diketahui";

                Console.Write("Umur: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    age = 0; // Default jika input salah
                }
                _users[i].Age = age;

                Console.Write("Tinggi Badan (cm): ");
                if (!double.TryParse(Console.ReadLine(), out double height))
                {
                    height = 0.0; // Default jika input salah
                }
                _users[i].Height = height;

                Console.Write("Apakah Anda seorang pelajar? (true/false): ");
                if (!bool.TryParse(Console.ReadLine(), out bool isStudent))
                {
                    isStudent = false; // Default jika input salah
                }
                _users[i].IsStudent = isStudent;

                Console.Write("Jenis Kelamin (L/P): ");
                char gender = Console.ReadKey().KeyChar;
                _users[i].Gender = char.ToUpper(gender); // Mengonversi ke huruf besar

                Console.WriteLine(); // Pindah baris setelah input char
            }
        }

        public void DisplayAllUserData()
        {
            Console.WriteLine("\n=== DATA TELAH TERSIMPAN ===");
            for (int i = 0; i < _users.Length; i++)
            {
                Console.WriteLine($"\nData ke-{i + 1}:");
                _users[i].DisplayInfo();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== FORMULATRIX TRAINING ===");

            const int totalUsers = 3;
            UserDataProcessor processor = new UserDataProcessor(totalUsers);

            processor.CollectUserData();
            processor.DisplayAllUserData();
        }
    }
}
