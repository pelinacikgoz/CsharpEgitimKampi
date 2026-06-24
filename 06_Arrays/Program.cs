using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2.4.6.8
            //sarı,kırmızı,mavi,turuncu

            //değişkentürü[] DiziAdı= new değişkentürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);
            //eğer tam sayılı bir dizide atama yapmadığın bir değeri çağırırsan cevap sıfıra eşit olur


            ////dynamic array
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i=0;i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber=myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //maxnumber değerim en büyük değer olana kadar sürekli değişiyor


            //string[] persons = { "Ali", "Ahmet", "Ayşe", "buse", "Cem", "Deniz" };
            //Console.WriteLine(persons.Length);

            //lenght kullanarak dizide kaç adet değer olduğunu görebilirsin

            //int[] numbers = { 45, 85, 21, 65, 89, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i=0;i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Array.Sort metodu ile dizi içerisinde yazılmış sayıları küçükten büyüğe olacak eşkilde yeniden sıralayabilirsin

            //int[] numbers = { 45, 85, 21, 65, 89, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Reverse metodu dizinin tersten yazılmasını sağlar



            #endregion

            #region Dizi metotlar

            //string[] customers = { "Ali", "Buse", "Ayşegül", "merve","çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //indexof ile istenilen ifadenin kaçıncı indexte olduğunu bulabilirsin

            //int[] numbers = { 45, 85, 96, 78, 89, 10, 22, 46 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());
            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for(int i=0;i< cities.Length;i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //eğer metnin içine dinamik bir değişken veya matematiksel bir işlem eklemek isteniliyorsa, başına $ işareti konulur
            ///{i+1} i $ işaret olmadan yazdırsaydık direkt metin olarak yazılırdı, ama istenilen işlem metin içinde ekstra matematiksel bir işlem yapılmasıdır
            ///


            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39,220};

            //Console.WriteLine("Çift sayılar");

            //for(int i=0;i<numbers.Length;i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
               
            //}

            //Console.WriteLine("Tek sayılar");

            //for(int i=0;i< numbers.Length;i++)
            //{
            //    if (numbers[i] %2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();


        }
    }
}
