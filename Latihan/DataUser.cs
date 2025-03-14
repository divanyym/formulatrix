namespace Formulatrix
{
    public class DataUser : UserBase
    {
        public static int UserCount { get; private set; } = 0; // Static property untuk melacak jumlah user

        public DataUser(string name, string address, int age, double height, bool intern, char gender)
            : base(name, address, age, height, intern, gender)
        {
            UserCount++; // Increment setiap instance dibuat
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Age: {Age} tahun");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"intern: {(Intern ? "Ya" : "Tidak")}");
            Console.WriteLine($"Jenis Kelamin: {Gender}");
        }
    }
}
