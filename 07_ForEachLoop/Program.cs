using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Each Döngüsü

            //foreach(1;2;3;4)

            //1:değişken türü
            //2:değişken adı
            //3:in 
            //4:liste,koleksiyon dizi

            //string[] cities = { "Milano", "Roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = {45,78,985,635,74,11,22,33,41,205,6578,1039 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 1039 };
            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 1039 };
            //int sum = 0;
            //foreach (int i in numbers)
            //{
            //    sum += i;

            //}
            //Console.WriteLine(sum);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,8
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //For each döngüsü sadece dizilerle değil listelerle de çalışabilir

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region örnek sınav sistemi uygulaması

            Console.Write("********** C# eğitim kampı sınav uygulaması***********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç tane öğrenci var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];


            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;


            }

            //Sınav Ortalamaları Kısmı

            for(int i=0; i<studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                //Öğrencilerin Ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci bu dersten kalmıştır");
                }
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine();

            #endregion



            Console.Read();




        }
    }
}
