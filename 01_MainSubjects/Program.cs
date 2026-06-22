using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdırma komutları
            Console.WriteLine("Merhaba Dünya");
            Console.Write("Selam");

            Console.WriteLine("*********Yemek Kategorileri**********");
            Console.WriteLine("");
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine("");
            Console.WriteLine("*********Yemek Kategorileri**********");
            #endregion

            #region String Değişkenler
           
            //değişkenin_türü değişken_adı;

            //alfabetik türde değişkenler için string kullanılır

            string name;
            name = "Pelin";
            Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "Çınar";
            customerPhone = "+90 500 400 30 20 ";
            customerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("**********Reverzasyon Kartı************");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("iletişim: " + customerPhone);
            Console.WriteLine("Email Adres: " + customerEmail);
            Console.WriteLine("Adres: " + district + city);
            Console.WriteLine("------------------------------------------------");

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 400 300 80 70";
            customerEmail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("iletişim: " + customerPhone);
            Console.WriteLine("Email Adres: " + customerEmail);
            Console.WriteLine("Adres: " + district + city);
            Console.WriteLine("------------------------------------------------");


            #endregion

            #region Int değişkenler

            // int tam sayılar için kullanılır
            //int number = 24;
            //Console.WriteLine(number);

            int hamgurberPrice = 300;
            int cokePrice=35;
            int waterPrice = 10;
            int fricePrice = 50;
            int pizzaPrice = 250;
            int lemonade = 30;

            Console.WriteLine("*****************Restoran Menü Fiyatı******************");
            Console.WriteLine();
            Console.WriteLine("---Kola:" + cokePrice + " " + "TL");
            Console.WriteLine("---Su:" + waterPrice + " " + "TL");
            Console.WriteLine("---Limonata:" + lemonade + " " + "TL");
            Console.WriteLine("---Hambumger:" + hamgurberPrice + " " + "TL" );
            Console.WriteLine("---Patates kızartması:" + fricePrice + " " + "TL");
            Console.WriteLine("---Pizza:" + pizzaPrice + " " + "TL");
            Console.WriteLine();

            Console.WriteLine("*****************Restoran Menü Fiyatı******************");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friceCount;
            int pizzaCount;
            int lemonadeCount;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friceCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFricePrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            totalHamburgerPrice = hamgurberPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFricePrice = fricePrice * friceCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonade * lemonadeCount;

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Hamburger tutarı:" + totalHamburgerPrice + " " + "TL");
            Console.WriteLine("Kola tutarı:" + totalCokePrice + " " + "TL");
            Console.WriteLine("Su tutarı:" + totalWaterPrice + " " + "TL");
            Console.WriteLine("Patates kızartması tutarı:" + totalFricePrice + " " + "TL");
            Console.WriteLine("Pizza tutarı:" + totalPizzaPrice + " " + "TL");
            Console.WriteLine("Limonata tutarı:" + totalLemonadePrice + " " + "TL");

            Console.WriteLine();

            int totalPrice;
            totalPrice = totalHamburgerPrice + totalCokePrice + totalFricePrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;

            Console.WriteLine("Toplam Hesap Tutarı:" + totalPrice + " " + "TL");

            #endregion

            Console.Read();

        }

    }
}

