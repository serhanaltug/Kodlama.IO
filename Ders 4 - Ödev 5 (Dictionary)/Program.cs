using System;

namespace Ders_4_Odev_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = MyDictionary<int, string>();

            myDictionary.Add(1, "Serhan");
            myDictionary.Add(2, "Zeynep");
            myDictionary.Add(5, "Ahmet");
        }
    }
}
