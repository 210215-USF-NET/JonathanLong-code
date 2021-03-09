using System; //using is like an import keyword (importing packages)
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); //Write things to the console 
            //How to write to the console
            //string name = Console.ReadLine(); //Read things to the console 
            //Console.WriteLine($"Hello {name}!");
           Random rnd = new Random();
           int num = rnd.Next(1, 13);
           Console.WriteLine(num);


        }
    }
}
