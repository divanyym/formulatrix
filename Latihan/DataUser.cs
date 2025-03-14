using System;

namespace Formulatrix
{
    public struct DataUser
    {
        public string Name { get; }
        public string Address { get; }
        public int Age { get; }
        public double Height { get; }
        public bool Intern { get; }
        public char Gender { get; }

        public DataUser(string name, string address, int age, double height, bool intern, char gender)
        {
            Name = name;
            Address = address;
            Age = age;
            Height = height;
            Intern = intern;
            Gender = char.ToUpper(gender);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Umur: {Age} tahun");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"intern: {(Intern ? "Ya" : "Tidak")}");
            Console.WriteLine($"Jenis Kelamin: {Gender}");
        }
    }
}
