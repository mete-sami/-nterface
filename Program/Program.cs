using System.IO;

namespace CSharpReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string[] lines = File.ReadAllLines("/Users/cagatayyildiz/Desktop/projects/oop-tutorial/CSharpWriteReadFile/user.txt");



            string[] lines2 = File.ReadAllLines("user.txt");

        }
    }
}
