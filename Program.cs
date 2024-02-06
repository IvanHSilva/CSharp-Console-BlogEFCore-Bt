using BlogEFCore.Data;

namespace BlogEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            using (var context = new DataContext()) { };
        }
    }
}
