using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //interfaceleri birbirinin alternatifi olan kod içerikleri farklı olan içerikleri tutmak için kullanırız.
        //loglama kim ne zaman hangi operasyonu çağırdı?
        //loglar veritabanında tutulabilir , sms olarak atılabilir, dosyada tutulabilir,mail göndermek loglamanın alternatifleridir.
        void Hesapla();
        void BiseyYap();
      
    }
}
