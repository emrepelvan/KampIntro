using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection metodun kullanacağı hangi kredi türü olacağını ve hangi log injection yapılıyor.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
           
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
