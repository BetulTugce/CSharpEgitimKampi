using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dongusu
            // foreach döngüsü 4 adet parametre alır.
            // 1.parametre : Değişken türü
            // 2.parametre : Değişken adı
            // 3.parametre : In
            // 4.parametre : Liste, Koleksiyon veya Dizi

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Bursa", "Antalya" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            // Bir dizideki çift sayıları yazdır.
            //int[] numbers = { 13, 25, 38, 42, 51, 67, 76, 84, 974, 1024};

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            // Bir dizi içinde yer alan sayıların toplamını hesapla.
            //int[] numbers = { 13, 25, 38, 42, 51, 67, 76, 84, 974, 1024 };

            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            // Listeler bir koleksiyon öğesidir.
            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 8
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            // Klavyeden öğrenci sayısı ve öğrencilerin isimlerini ve sınav notlarını alarak ortalamalarını hesapla.

            Console.Write("Öğrenci sayısı: ");
            int totalStudent = int.Parse(Console.ReadLine());

            string[] studentNames = new string[totalStudent];
            double[] studentExamAvg = new double[totalStudent];

            for (int i = 0; i < totalStudent; i++)
            {
                Console.WriteLine($"{i + 1}. öğrencinin adı: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin, ");
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"{j}.Sınav Notu: ");
                    totalExamResult += double.Parse(Console.ReadLine());
                }

                studentExamAvg[i] = (totalExamResult / 3);
            }

            for (int i = 0;i < totalStudent; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin not ortalaması : {studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} dersten kaldı!");
                }
            }
            #endregion

            Console.Read();
        }
    }
}
