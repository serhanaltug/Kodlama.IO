using System;
using System.Collections.Generic;

namespace Ders_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            ILoggerService fileLoggerService = new FileLoggerService();

            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);



            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
