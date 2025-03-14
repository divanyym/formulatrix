using System;

namespace Formulatrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== FORMULATRIX INTERN INFORTMATION CENTER ===");

            const int user = 3;
            DataControl author = new DataControl(user);

            author.InputData();
            author.ShowData();

            Console.WriteLine($"\nTotal User Count: {DataControl.TotalUsers}");
        }
    }
}
