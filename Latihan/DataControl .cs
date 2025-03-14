using System;

namespace Formulatrix
{
    public class DataControl
    {
        private readonly DataUser[] _input; //Array untuk menyimpan data user, hanya bisa diisi saat pertama dibuat
        public static int TotalUsers { get; private set; } = 0;

        public DataControl(int userCount)
        {
            _input = new DataUser[userCount]; //Inisialisasi array dengan jumlah elemen sesuai input
        }

        public void InputData()
        {
            for (int i = 0; i < _input.Length; i++)
            {
                Console.WriteLine($"\nData ke-{i + 1}:");

                string name = InputString("Name");
                string address = InputString("Address");
                int age = InputInt("Age");
                double height = InputDouble("Tinggi Badan (cm)");
                bool intern = InputBool("Apakah Anda sedang intern di Formulatrix? (true/false)");
                char gender = InputChar("Jenis Kelamin (L/P)");

                _input[i] = new DataUser(name, address, age, height, intern, gender);
                TotalUsers++; //increment total user
            }
        }

        public void ShowData()
        {
            Console.WriteLine("\n=== DATA TELAH TERSIMPAN ===");
            foreach (var input in _input)
            {
                input.ShowInfo();
            }
        }

        private static string InputString(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine() ?? "Empty"; //akan memunculkan kosong jika user langsung mengklik enter
        }
        

        private static int InputInt(string prompt)
        {
            Console.Write($"{prompt}: ");
            return int.TryParse(Console.ReadLine(), out int value) ? value : 0;
        }

        private static double InputDouble(string prompt)
        {
            Console.Write($"{prompt}: ");
            return double.TryParse(Console.ReadLine(), out double value) ? value : 0.0;
        }

        private static bool InputBool(string prompt)
        {
            Console.Write($"{prompt}: ");
            return bool.TryParse(Console.ReadLine(), out bool value) && value;
        }

        private static char InputChar(string prompt)
        {
            Console.Write($"{prompt}: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }
    }
}
