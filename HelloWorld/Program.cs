using System; //using is like an import keyword (importing packages)

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //Write things to the console 
            //How to write to the console
            string name = Console.ReadLine(); //Read things to the console 
            Console.WriteLine($"Hello {name}!");

        }
    }
}
