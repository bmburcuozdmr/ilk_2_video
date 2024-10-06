using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("*******Fiyat Listesi*******");
            //Console.WriteLine("Kasiyer: Burcu Özdemir");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("---Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("---Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("---Patates Birim Fiyatı: " + patatoPrice + "TL");
            //Console.WriteLine("---Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //double appleWeight, orangeWeight, strawberryWeight, patatoWeight, tomatoWeight;
            //appleWeight = 1.245;
            //orangeWeight = 2.65;
            //strawberryWeight = 0.75;
            //patatoWeight = 4.859;
            //tomatoWeight = 3.745;


            //Console.WriteLine();
            //Console.WriteLine("*******Tartılan Gramaj Değerleriniz*******");
            //Console.WriteLine();

            //Console.WriteLine(appleWeight + "KG---Elma");
            //Console.WriteLine(orangeWeight + "KG---Portakal");
            //Console.WriteLine(strawberryWeight + "KG---Çilek");
            //Console.WriteLine(patatoWeight + "KG---Patates");
            //Console.WriteLine(tomatoWeight + "KG---Domates");

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, patatoTotalPrice, tomatoTotalPrice, shoppingTotalPrice;

            //appleTotalPrice = applePrice * appleWeight;
            //orangeTotalPrice = orangePrice * orangeWeight;
            //strawberryTotalPrice = strawberryPrice * strawberryWeight;
            //patatoTotalPrice = patatoPrice * patatoWeight;
            //tomatoTotalPrice = tomatoPrice * tomatoWeight;
            //shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;





            //Console.WriteLine();
            //Console.WriteLine("*******Toplam Tutarlar*******");
            //Console.WriteLine();
            //Console.WriteLine("Aldığınız Elmanın toplam ücreti: " + appleTotalPrice + "TL");
            //Console.WriteLine("Aldığınız Portakalın toplam ücreti: " + orangeTotalPrice + "TL");
            //Console.WriteLine("Aldığınız Çileğin toplam ücreti: " + strawberryTotalPrice + "TL");
            //Console.WriteLine("Aldığınız Patatesin toplam ücreti: " + patatoTotalPrice + "TL");
            //Console.WriteLine("Aldığınız Domatesin toplam ücreti: " + tomatoTotalPrice + "TL");
            //Console.WriteLine("Kasaya Ödenecek: " + shoppingTotalPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Yine Bekleriz.");


            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //string passengerName, passengerSurname, passengerDistrict; 
            //string passengerCity, passengerIdentityNumber,passengerAge;

            //////Console.Write("Yolcu Adı: ");
            //////passengerName = Console.ReadLine();

            //////Console.Write("Yolcu Soyadı: ");
            //////passengerSurname = Console.ReadLine();

            //////Console.Write("İlçe Bilgisi: ");
            //////passengerDistrict = Console.ReadLine();

            //////Console.Write("Şehir Bilgisi: ");
            //////passengerCity = Console.ReadLine();

            //////Console.Write("Tc Kimlik Numarası:");
            //////passengerIdentityNumber = Console.ReadLine();


            //////Console.Write("Yolcu Yaşı: ");
            //////passengerAge = Console.ReadLine();

            //////Console.WriteLine("---------------");
            //////Console.WriteLine("Yolcu  TC: " + passengerIdentityNumber + " " + "Yolcu Adı-Soyadı: " + passengerName + " " + passengerSurname + " Lokasyon Bilgisi: " + passengerDistrict + "-" + passengerCity + " Yolcu Yaşı: " + passengerAge);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 3000;
            //computerPrice = 30000;
            //chairPrice = 7500;
            //tvPrice = 20000;
            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Aldığınız Ayakkabı sayısını girin: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Aldığınız Bilgisayar sayısını girin:");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Aldığınız Sandalye sayısını girin:");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Aldığınız TV sayısını girin:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesPrice*shoesCount+computerPrice*computerCount+chairPrice*chairCount+tvPrice*tvCount;
            //Console.WriteLine("Toplam Tutar: " + totalPrice + "TL");








            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;

            //Console.Write("Birinci Sınav notunu gir: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("İkinci Sınav notunu gir: ");
            //exam2=double.Parse(Console.ReadLine());
            //Console.Write("Üçüncü Sınav notunu gir: ");
            //exam3=double.Parse(Console.ReadLine());

            //result=(exam1+ exam2+exam3)/3;
            //Console.WriteLine("ORTALAMA: "+result);








            #endregion

            #region Klavyeden Karakter İşlemleri

            //char gender;

            //Console.Write("Cinsiyet Seç: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçilen Cinsiyet: " + gender);





            #endregion





            Console.Read();


        }
    }
}
