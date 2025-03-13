using System;

namespace FormulatrixTraining
{
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
