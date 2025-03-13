using System;

class Training
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== FORMULATRIX ===");

        // 📌 Menggunakan Array untuk menyimpan beberapa nama
        string[] nama = new string[3];
        string[] alamat = new string[3];
        int[] umur = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nData ke-{i + 1}:");
            
            Console.Write("Nama: ");
            nama[i] = Console.ReadLine() ?? "Tidak diketahui";

            Console.Write("Alamat: ");
            alamat[i] = Console.ReadLine() ?? "Tidak diketahui";

            Console.Write("Umur: ");
            if (!int.TryParse(Console.ReadLine(), out umur[i]))
            {
                umur[i] = 0; // Default jika input salah
            }
        }

        Console.WriteLine("\n=== DATA TELAH TERSIMPAN ===");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nData ke-{i + 1}:");
            Console.WriteLine($"Nama: {nama[i]}");
            Console.WriteLine($"Alamat: {alamat[i]}");
            Console.WriteLine($"Umur: {umur[i]} tahun");
        }
    }
}
