using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            // For (x; y; z) => x: baslangic degeri, y: bitis degeri, z:artis/azalis degeri

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen bir sayı girin: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++) 
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları
            //for (int i = 1; i <= 100; i++) 
            //{
            //    if (i % 5 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 1'den 10'a kadar olan sayilarin toplamini ekrana yazdir..
            //int total = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            // 1 ile 20 arasindaki (1 ve 20 dahil degil) cift sayilarin toplamini ekrana yazdir..
            //int total = 0;
            //for (int i = 2; i < 20; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        total += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine($"-------\n" +total);

            // 1 ile 50 arasında (1 ve 50 dahil) 7'ye tam bölünen kaç tam sayı olduğunu hesapla..
            //int counter = 0;
            //for (int i = 1; i <= 50; i++) 
            //{
            //    if(i % 7 == 0)
            //    {
            //        counter++;
            //    }   
            //}
            //Console.WriteLine(counter);
            #endregion

            #region Bakteri Sorusu
            // Bir bakteri türü her saatin sonunda kendini 2ye bölerek çoğalmaktadır. Yani başlangıçta 1 tane var. 1. saatin sonunda 2 tane, 2. saatin sonunda 4 şeklinde.. 24 saatin sonunda bu ortamda kaç tane bakteri olduğunu hesaplayan programı yazın..
            //int counter = 1;
            //for(int i = 1; i <=24; i++)
            //{
            //    counter *= 2;
            //    Console.WriteLine(i + ". saat sonunda toplam bakteri sayısı: " + counter);
            //}
            #endregion

            #region While Döngüsü
            //while (kosul) { islemler }

            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // 1 ile 10 arasında 3'e tam bölünen sayıları yazdır..
            //int counter = 1;
            //while (counter <= 10)
            //{
            //    if (counter % 3 == 0)
            //    {
            //        Console.WriteLine(counter);
            //    }
            //    counter++;

            //}

            // 1 ile 10 arasındaki sayilarin toplamini hesapla..
            //int i = 0, sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu
            // Klavyeden girilen sayının basamakları toplamını hesaplayan kodu yazın..
            // Analiz : Girilen string ifadeyi for döngüsüne alıp length boyunca döndürerek her indexteki değeri inte parse edip toplayacağım..
            Console.WriteLine("Lütfen basamakları toplamının hesaplanmasını istediğiniz sayiyi girin: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {
                sum += (num % 10);
                num = num / 10;
            }

            Console.WriteLine(sum);
            #endregion

            Console.Read();
        }
    }
}