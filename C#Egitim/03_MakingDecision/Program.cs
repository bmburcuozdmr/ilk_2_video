using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE
            // string password;
            // Console.Write("Lütfen Şifreyi Giriniz: ");
            //password= Console.ReadLine();
            // if(password=="abcd")
            // {
            //     Console.WriteLine("SIFRE DOGRU");
            // }
            // else
            // {
            //     Console.WriteLine("SIFRE YANLIS");
            // }

            //string capital, country;
            //Console.Write("Başkent Girin: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülke Girin: ");
            //country = Console.ReadLine();
            //if(capital=="ankara"&& country=="türkiye")
            //{
            //    Console.WriteLine("Veriler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler Yanlış");
            //}
            //int number;
            //Console.Write("Sayiyi tahmin et: ");
            //number = int.Parse(Console.ReadLine());
            //if(number==27)
            //{
            //    Console.WriteLine("TAHMİN DOĞRU");
            //}
            //else
            //{
            //    Console.WriteLine("TAHMİN HATASI");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!"; // iflere uymayan bir değer olursa hata! dönecek.

            //Console.Write("Birinci Sınav Notu: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci Sınav Notu: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Üçüncü Sınav Notu: ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + average);
            //if (average >= 0 & average <= 50)
            //{
            //    result = "Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average >= 85 & average <= 100)
            //      {
            //    result = "Mükemmel";

            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir girişi yapınız: ");
            //city= Console.ReadLine();
            //if(city=="diyarbakir" | city=="mardin" | city=="siirt" | city=="batman")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("mevcut değil");
            //}            
            //string nickname;
            //Console.Write("Kullanıcı adı: ");
            //nickname=Console.ReadLine();
            //if(nickname !="admin")
            //{
            //    Console.WriteLine("Geçersiz Kullanıcı Adı");
            //}
            //else 
            //{
            //    Console.WriteLine(" Kullanıcı Adı Doğru.");
            //}










            #endregion

            #region Mod işlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            // Console.Write("Lütfen 1.sayıyı giriniz: ");
            // int number1 = int.Parse(Console.ReadLine());
            // Console.Write("Lütfen 2.sayıyı giriniz: ");
            // int number2 = int.Parse(Console.ReadLine());
            // int result = number1 % number2;
            //Console.Write("1.Sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen Sayıyı girin: ");
            //int number =int.Parse( Console.ReadLine());
            //if(number%2==0)
            //{
            //    Console.WriteLine("Sayi Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Tektir");
            //}




            #endregion

            #region Char İle Karar Yapısı
            //char team;
            //Console.Write("Takımın Sembolünü gir: ");
            //team=char.Parse(Console.ReadLine());

            //if(team =='G' | team=='g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}



            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("*******C# Eğitim Kampı Restoranı*******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();
            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Büryan");
            //    Console.WriteLine("2-Hünkar Beğendi");
            //    Console.WriteLine("3-Topkapı Kebabı");
            //    Console.WriteLine("4-Lazanya");
            //    Console.WriteLine("5-Güveç");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Tarhana Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Bol Malzemos");
            //    Console.WriteLine("3-SucukSever");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Revani");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //}





            #endregion

            #region Switch-Case
            Console.Write("Lütfen ay giriniz: ");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1: Console.Write("Ocak"); break;
                case 2: Console.Write("Şubat"); break;
                case 3: Console.Write("Mart"); break;
                case 4: Console.Write("Nisan"); break;
                case 5: Console.Write("Mayıs"); break;
                case 6: Console.Write("Haziran"); break;
                case 7: Console.Write("Temmuz"); break;
                case 8: Console.Write("Ağustos"); break;
                case 9: Console.Write("Eylül"); break;
                case 10: Console.Write("Ekim"); break;
                case 11: Console.Write("Kasım"); break;
                case 12: Console.Write("Aralık"); break;
                default: Console.Write("Hatalı Değer"); break;

            }
            #endregion
            Console.Read();

        }
    }
}
