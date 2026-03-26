using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("*********Yemek Kategorileri*******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("********* Yemek Kategorileri*********");
            #endregion
            #region StringDeğişkenler
            //String = Değişkenin_türü  değişken_adı;

            //string name;
            //name = "Baran";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Baran";
            //customerSurname = "Erçel";
            //customerPhone = "+90 555 555 55 55";
            //customerEmail = "deneme@gmail.com";
            //district ="Merkez";
            //city = "Elazığ";


            //Console.WriteLine("****** Rezervasyon Kartı ********");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri : " + customerName+ " " + customerSurname);

            #endregion
            #region IntDeğişkenler

            ////int
            //int number = 25;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola Fiyatı: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;


            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalCokePrice = cokePrice * cokeCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalFriesPrice = friesPrice * friesCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalLemonadePrice = lemonadePrice * lemonadeCount;
            Console.WriteLine("Hamburger Toplam Fiyatı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Toplam Fiyatı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Toplam Fiyatı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Toplam Fiyatı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Toplam Fiyatı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Toplam Fiyatı: " + totalLemonadePrice + " TL");
            Console.WriteLine();
            totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}

//Yazdırma Komutları 





