using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenCizme
{
    public class Program
    {
        static void Main(string[] args)
        {
            double kenar1, kenar2, kenar3;
            KullaniciKarsilama();
            kenar1 = KenarUzunluklarıAlma();
            Console.WriteLine("");
            kenar2 = KenarUzunluklarıAlma();
            Console.WriteLine("");
            kenar3 = KenarUzunluklarıAlma();
            if (UcgenKontrolEt(kenar1, kenar2, kenar3))
            {
                Hesapla(kenar1, kenar2, kenar3);
            }
            else
            {
                Console.WriteLine("Üçgen oluşturulamadı.");
            }
            Console.ReadLine();
        }

        private static void Hesapla(double kenar1, double kenar2, double kenar3)
        {
            if (kenar1 == kenar2 && kenar1 == kenar3)
            {
                Console.WriteLine("Eş kenar üçgen oluşturuldu.");
            }
            else if ((kenar1 == kenar2 && kenar1 != kenar3) || (kenar1 == kenar3 && kenar1 != kenar2) || (kenar3 == kenar2 && kenar1 != kenar3))
            {
                Console.WriteLine("İkiz kenar üçgen oluşturuldu.");
            }
            else
            {
                Console.WriteLine("Çeşit kenar üçgen oluşturuldu.");
            }
        }

        private static bool UcgenKontrolEt(double kenar1, double kenar2, double kenar3)
        {
            if (kenar1 + kenar2 > kenar3 && kenar1 + kenar3 > kenar2 && kenar3 + kenar2 > kenar1)
                return true;

            else return false;
        }

        private static void KullaniciKarsilama()
        {
            Console.WriteLine("Tarafınızdan belirlenen kenar uzunluklarında üçgen oluşturulucaktır.");
        }

        public static double KenarUzunluklarıAlma()
        {
            double kenar;
             try
            {
                Console.WriteLine("Oluşturmak istediğiniz üçgene ait kenar bilgilerini giriniz.");
                Console.Write("Kenar Uzunluğu : ");
                kenar = Convert.ToDouble(Console.ReadLine());
                if (kenar <= 0)
                {
                    Console.WriteLine("Üçgene ait kenar uzunluğu negatif olamaz. Lütfen pozitif bir değer giriniz.");
                    return KenarUzunluklarıAlma();
                }
                else
                {
                    return kenar;
                }
              
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı veri girişi yaptınız. Lütfen pozitif bir sayısal değeer giriniz.");
                return KenarUzunluklarıAlma();
            }

        }
    }
}
