using System;

namespace console_ap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin:");
            string surname = Console.ReadLine();
            Console.WriteLine("merhaba"+name+" "+surname);
        }
    }
}