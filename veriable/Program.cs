using System;

namespace veriable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        // KONSOLDA BELLİ Bİ YERİ YÜRÜTMEK İÇİN YAPILACAKLAR
        // 1. dotnet new console
        // 2. dotnet restore
        // 3.dotnet run
            byte b=5;       //1 byte
            sbyte c=5;      //1 byte
            short d=5;      //2 byte
            ushort e=5;     //2 byte

            Int16 i16= 2;   //2 byte
            int i=2;        //4 byte
            

            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);
        // OBJECT HER TÜRDEN VERİ TANIMI YAPILABİLİR
            Object A3=0;
            Object A4=0.15;
            Object A5= "SGDH";    

        // STRİNG 
            //string.Empty -> bellekte bir nesne yaratmaz. String alanında Empty alanına (field)a referans gösterir
            string s1= string.Empty;
            string ad = "rabia";
            string soyad = "top";
            string tamIsım= ad +" "+soyad;
            Console.WriteLine(tamIsım);    

        // DEĞİŞKEN DÖNÜŞÜMLERİ   
            string str20="20";
            int int20 = 22;

            string yeniDeger= str20 +int20.ToString();

            Console.WriteLine(yeniDeger);  //çıktı:2020

            int yeniIntDeger= int20 + Convert.ToInt32(str20);
            Console.WriteLine(yeniIntDeger); // çıktı:42

            //int değerinin diğer çevirme yöntemi pars

            int yeniIntDeger2= int20 + int.Parse(str20);
           
            Console.WriteLine(yeniIntDeger2);

        // datetime 
        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);
        
        //saat
        string hour= DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);

        }
    }
}