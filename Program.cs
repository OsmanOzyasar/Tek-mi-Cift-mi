using System;

namespace Pratik2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            string? sayı = Console.ReadLine();
            int sayı_ = 0;

            int.TryParse(sayı, out sayı_);

            if(sayı_ > 10)
            {
                Console.WriteLine("Sayı 10 dan büyüktür");

                if(sayı_ % 2  == 0)
                {
                    Console.WriteLine("Sayı çifttir");
                }
                else
                {
                    Console.WriteLine("Sayı Tektir");
                }
            }
            else
            {
                Console.WriteLine("Sayı 10 dan küçüktür");


                if (sayı_ % 2 == 0)
                {
                    Console.WriteLine("Sayı çifttir");
                }
                else
                {
                    Console.WriteLine("Sayı Tektir");
                }
            }
        }
    }
}