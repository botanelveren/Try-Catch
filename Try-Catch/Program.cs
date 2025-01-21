using System;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            string girdi = Console.ReadLine();

            try
            {
                int sayi = int.Parse(girdi);
                Console.WriteLine("Sayının karesi: " + (sayi * sayi));
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }
    }
}