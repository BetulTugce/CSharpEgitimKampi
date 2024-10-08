using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 tane yıldız oluşturma..
            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 tane yıldız oluşturma..
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region  Alt Alta 10 tane yıldız oluştur ve her satırında 10 tane yıldız olsun..
            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region Dik Üçgen
            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region Ters Dik Üçgen
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = i; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //2.yol
            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region Dik Üçgen ve Ters Dik Üçgen Beraber
            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region Piramit
            //for (int i = 1; i <= 5; i++)
            //{
            //    // Boşluklar
            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit
            //for (int i = 5; i >= 1; i--)
            //{
            //    // Boşluklar
            //    for (int j = 5 - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi

            Console.Write("Baklava diliminin boyutunu girin: ");
            int n = int.Parse(Console.ReadLine());

            // Üst yarıyı çiz
            for (int i = 1; i <= n; i++)
            {
                // Boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                // Yıldızlar
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Alt yarıyı çiz
            for (int i = n - 1; i >= 1; i--)
            {
                // Boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                // Yıldızlar
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            Console.Read();
        }
    }
}
