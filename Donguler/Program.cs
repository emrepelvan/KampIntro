using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Proglamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";
            

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


            //array = dizi

            string[] kurslar = new string[] {"Yazılım geliştirici yetiştirme kampı" , "Proglamaya başlangıç için temel kurs" , "Java" , "Python" , "C++"};

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            //foreach - dizi temelli yapıları tek tek dönmeye yarar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);  
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
