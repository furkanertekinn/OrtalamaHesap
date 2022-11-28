using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not Ortalaması Sistemine Hoşgeldiniz");

            Console.Write("İsim Giriniz : ");
            string isim = Console.ReadLine();

            Console.Write("Soyisim Giriniz : ");
            string soyisim = Console.ReadLine();

            Console.Write("Not 1 değerini giriniz : ");
            string not1 = Console.ReadLine();

            Console.Write("Not 2 değerini giriniz : ");
            string not2 = Console.ReadLine();

            Console.Write("Not 3 değerini giriniz : ");
            string not3 = Console.ReadLine();

            decimal notDecimal1 = Convert.ToDecimal(not1);
            decimal notDecimal2 = Convert.ToDecimal(not2);
            decimal notDecimal3 = Convert.ToDecimal(not3);

            decimal ortalama = (notDecimal1 + notDecimal2 + notDecimal3) / 3;

            if (100<=ortalama)
            {
                Console.WriteLine("Notlarınızı Kontrol Ediniz.." + ortalama);
            }

            else if (ortalama<=100 && ortalama>=90 )
            {
                Console.WriteLine("Başarılı Tebrikler " + ortalama);
            }

            else if (ortalama<90 && ortalama>=70)
            {
                Console.WriteLine("İyi ile geçtiniz" + ortalama);
            }

            else if (ortalama< 70 && ortalama >= 45)
            {
                Console.WriteLine("Orta ile geçtiniz "+ ortalama);
            }

            else if (ortalama<45)
            {
                Console.WriteLine("Kaldınız :( " + ortalama);
            }

            else 
            {
                Console.WriteLine("Lütfen Not Değerlerinizi Kontrol Ediniz..");
            }

            Console.WriteLine("İyi Günler Dileriz..");
            Console.ReadLine();

        }
    }
}
