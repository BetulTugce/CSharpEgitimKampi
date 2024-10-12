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
            // Dizi, aynı veri tipindeki çok sayıda veriyi birarada tutmak için kullanılan yapılardır.
            // DegiskenTuru[] DiziAdi = new DegiskenTuru[ElemanSayisi]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = { "Ankara", "İstanbul", "Çankırı", "Yozgat", "İzmir" };
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = new int[7] { 4, 25, 27, 32, 33, 59, 60 };
            //Console.WriteLine(numbers[numbers.Length - 1]);

            // Tam sayı tipinde bir dizi tanımlandığında atama yapılmayan indeks otomatik olarak 0 değerini alır.. Zaten int tipindeki bir değişken varsayılan değeri 0'dır.

            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            // Bir int dizisindeki 3 e tam bölünen sayıları listele..
            //int[] nums = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 3 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //foreach (char c in symbols)
            //{
            //    Console.WriteLine(c);
            //}

            // Bir dizideki en büyük elemanı bul..
            //int[] myArrays = { 47, 85, 96, 41, 25, 635, 789, 86, 100 };

            //int maxNum = myArrays[0];
            //for (int i = 1; i < myArrays.Length; i++)
            //{
            //    if (myArrays[i] > maxNum)
            //    {
            //        maxNum = myArrays[i];
            //    }
            //}
            //Console.WriteLine("Dizideki en büyük eleman: " + maxNum);

            //string[] customers = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            //Console.WriteLine(customers.Length); // dizinin uzunlugu..

            //int[] numbers = { 45, 85, 41, 86, 10, 22, 35 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("------------------");
            //Array.Sort(numbers); // Diziyi küçükten büyüğe doğru sıralar..
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("------------------");
            //Array.Reverse(numbers); // Diziyi tersine çevirir..
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotları
            //string[] customers = { "Ali", "Buse", "Ayşe", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Kaya"); // dizide aranılan elemanın indexini verir..
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 61, 74, 10, 25, 36, 22 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "\nDizinin en küçük elemanı: " + numbers.Min());
            //Array.Resize(ref numbers, 6);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Kullanıcıdan değer alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"{i + 1}. şehri girin: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("--------------");
            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine("Dizinin elemanları toplamı: " + sum);
            //Console.WriteLine("Dizinin elemanları toplamı: " + numbers.Sum());

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Çift Sayılar\n--------------------");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) { Console.WriteLine(nums[i]); }
            }
            Console.WriteLine("Tek Sayılar\n--------------------");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0) { Console.WriteLine(nums[i]); }
            }
            #endregion

            Console.Read();
        }
    }
}
