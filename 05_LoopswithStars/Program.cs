using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopswithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region alt alta 10 tane yıldız oluşturma

            //for(int i=1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion


            #region yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region alt alta 10 tane yıldız oluşturma ve her satırda 10 tane yıldız

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion


            #region dik üçgen oluşturma

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ters dik üçgen oluşturma

            //for (int i = 5; i>= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Baklava şekli oluşturma
            //2 şekilde yazıldı

            //for(int i=1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k = 4; k >= 1; k--)
            //{
            //    for(int m=1;m<=k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //üst kısım
            //int n= 5;
            //for(int i=1;i<=n;i++)
            //{
            //    for(int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}



            //alt kısım
            //for(int i= n - 1; i >= 1; i--)
            //{
            //    for(int j=1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1;k<=(2* i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}


            #endregion


            #region piramit oluşturma


            //int n = 5;
            //for(int i = 1; i <= n; i++)
            //{
            //    //boşluklar için
            //    for(int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar için
            //    for(int k=1;k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}


            //baklava diliminin üst kısmı gibi de yazılabilir
            //int n = 5;
            //for(int i=1;i<=n;i++)
            //{
            //    for(int j=1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion


            #region ters piramit oluşturma

           // int n = 5;
            

           //for(int i=n; i >= 1; i--)
           // {
           //     for(int j = n - i; j > 0; j--)
           //     {
           //         Console.Write(" ");
           //     }
           //     for(int k = 1; k <= 2 * i - 1; k++)
           //     {
           //         Console.Write("*");
           //     }
           //     Console.WriteLine();
           // }


            #endregion



            Console.Read();



        }
    }
}
