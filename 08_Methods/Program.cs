using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //() 
            //Geriye değer döndürmeyen metotlar
            //customer---->Listele,ekle,sil,güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //Belirli işlemleri tekrardan kurtarmak için kullanılabilir

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");
            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void sum(int number1,int number2,int number3)
            //{
            //    int result=number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke:" + countryName + " -Başkent:" + capital + " -Bayrak Rengi:" + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));
            //Console.WriteLine(countryCard("Türkiye","Ankara","Kırmızı-Beyaz"));

            //hem kullanıcıdan verileri yazmasını isteyebilirsin hem de direkt countryCard olarak verileri yazıp ekranda okutabilirsin


            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result=number1+  number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));

            #endregion


            #region örnek uygulama

            string ExamResult(string student, int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti" + " -->Ortalama: " + result;
                }
                else
                {
                    return student + "isimli öğrenci sınavı geçemedi" + " -->Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali",25,41,85));
            Console.WriteLine(ExamResult("Ayşe",36,88,33));

            #endregion


            Console.Read();

        }
    }
}
