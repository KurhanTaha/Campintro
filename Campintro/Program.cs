using System;


namespace Campintro
{

    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Hello World!";
            int NumberOfStudent = 148;
            // double ondalıklı sayı tutar
            double FaizOrani = 148.5;
            bool HasItSigned = false;
            double dollarbugün = 7.45;
            double dollardun = 7.35;

            if (dollardun > dollarbugün)
            {
                Console.WriteLine("azalış oku");
            }
            else if (dollarbugün == dollardun)
            {
                Console.WriteLine("Değişmez oku");
            }
            else
            {
                Console.WriteLine("Artış oku");
            }


            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine(NumberOfStudent);

            if (HasItSigned == true)
            {
                Console.WriteLine("Settings button");
            }
            else
            {
                Console.WriteLine("Sign in button");
            }
        

        }



    }

}

