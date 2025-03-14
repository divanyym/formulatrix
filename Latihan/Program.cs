using System;

namespace Formulatrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== FORMULATRIX TRAINING ===");

            const int user = 3;
            DataControl author = new DataControl(user);

            author.InputData();
            author.ShowData();
        }
    }
}
