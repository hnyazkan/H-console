using System;

namespace programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
           Console.WriteLine("İsminizi Giriniz");
           string name = Console.ReadLine();
           Console.WriteLine("Soyadınızı Giriniz");
           string surname = Console.ReadLine();

           Console.WriteLine("Hello " + name + " " + surname );
           
        }
    }
}
