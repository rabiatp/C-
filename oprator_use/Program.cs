using System;

namespace operator_use
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // MANTIKSAL OPERATÖRLER
            // ||, &&, !

            bool workSuccess = true;
            bool workCompleted = false;

            if(workSuccess && workCompleted)
                Console.WriteLine(" transaction successful ");

            if( workSuccess || workCompleted)
                Console.WriteLine(" transaction great ");
            
            if( workCompleted &&! workSuccess )
                Console.WriteLine(" transaction fine ");

            // İLİŞKİSEL OPERATÖRLER        
            // <, >, <=, >=, ==, !=

            int a=3;
            int b=4;
            bool sonuc= a<b;

            Console.WriteLine(sonuc);
            

        }
    }   
}