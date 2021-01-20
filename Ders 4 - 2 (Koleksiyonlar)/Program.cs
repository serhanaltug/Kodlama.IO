using System;
using System.Collections.Generic;

namespace Ders_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Serhan", "Engin", "Murat", "Kerem" };
            Console.WriteLine(isimler[0]);
            isimler.Add("İlker");
        }
    }
}
