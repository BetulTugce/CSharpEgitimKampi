using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If/Else If/Else
            //Console.Write("Parola: ");
            //string password = Console.ReadLine();
            //if (password != "Betul123*")
            //{
            //    Console.WriteLine("Parola yanlış!");
            //}
            //else 
            //{
            //    Console.WriteLine("Parola doğru!");
            //}

            //string capital, country;
            //Console.Write("Başkent: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülke: ");
            //country = Console.ReadLine();

            //if (capital.ToLower() == "ankara" && country.ToLower() == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi!");
            //}

            //Console.Write("Sayı girin: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number >= 0)
            //{
            //    Console.WriteLine("Pozitif");
            //}
            //else 
            //{
            //    Console.WriteLine("Negatif");
            //}

            //double exam1, exam2, exam3, average;
            //Console.Write("1.Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2.Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3.Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //if (average < 0) 
            //{
            //    Console.WriteLine("Sınav notları negatif olamaz!\n Lütfen girdilerinizi kontrol edin.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not Ortalaması: {average}");

            //    if (average > 0 && average <= 50)
            //    {
            //        Console.WriteLine("Öğrenci Durumu: Zayıf");
            //    }
            //    else if (average > 50 && average <= 70)
            //    {
            //        Console.WriteLine("Öğrenci Durumu: Orta");
            //    }
            //    else if (average > 70 && average <= 84)
            //    {
            //        Console.WriteLine("Öğrenci Durumu: İyi");
            //    }
            //    else if (average > 84)
            //    {
            //        Console.WriteLine("Öğrenci Durumu: Çok İyi");
            //    }
            //}

            //Console.WriteLine("Şehir: ");
            //string city = Console.ReadLine().ToLower();
            //if (city == "adana" | city == "ankara" | city == "trabzon")
            //{
            //    Console.WriteLine("Mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Mevcut değil.");
            //}

            //Console.WriteLine("Kullanıcı adı: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adını yanlış girdiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz!");
            //}

            #endregion

            #region Mod İşlemleri

            //Console.Write("Bölünecek sayı ve bölen sayıyı girin: ");
            //int num = int.Parse(Console.ReadLine());
            //int divisor = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{num}/5={num / divisor}\nKalan={num % divisor}");
            //Console.Read();

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} çift sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} tek sayıdır.");
            //}
            #endregion

            #region Char Değişkeni ile Karar Yapısı Örnek
            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if(team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if(team == 't' || team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}

            #endregion

            #region Örnek Uygulama
            //Console.WriteLine("***** Eğitim Kampı Lokanta *****\n------------------------------------\n1-Ana Yemekler\n2-Çorbalar\n3-Pizzalar\n4-Tatlılar\n5-İçecekler\n");

            //Console.Write("Hangi alanda sipariş vermek istiyorsanız sıra numarasını girin: ");
            //char menuItem = char.Parse(Console.ReadLine());

            //if (menuItem == '1')
            //{
            //    Console.WriteLine("\nAna Yemekler\n------------------\n");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Köri Soslu Kremalı Mantarlı Tavuk");
            //    Console.WriteLine("3-Fırında Somon");
            //    Console.WriteLine("4-Tepsi Kebabı");
            //    Console.WriteLine("5-Perde Pilavı");
            //    Console.WriteLine("6-Fırında Sebzeli Güveç");
            //    Console.WriteLine("------------------\n");
            //}
            //else if (menuItem == '2')
            //{
            //    Console.WriteLine("\nÇorbalar\n------------------\n");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Tarhana Çorbası");
            //    Console.WriteLine("3-Domates Çorbası");
            //    Console.WriteLine("4-Ezogelin Çorbası");
            //    Console.WriteLine("5-Düğün Çorbası");
            //    Console.WriteLine("6-Brokoli Çorbası");
            //    Console.WriteLine("------------------\n");
            //}
            //else if (menuItem == '3')
            //{
            //    Console.WriteLine("\nPizzalar\n------------------\n");
            //    Console.WriteLine("1-Karışık Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Marinara Pizza");
            //    Console.WriteLine("4-Dört Peynirli Pizza");
            //    Console.WriteLine("5-Deniz Ürünlü Pizza");
            //    Console.WriteLine("6-Hawaii Pizza");
            //    Console.WriteLine("------------------\n");
            //}
            //else if (menuItem == '4')
            //{
            //    Console.WriteLine("\nTatlılar\n------------------\n");
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Tavuk Göğsü");
            //    Console.WriteLine("4-Şekerpare");
            //    Console.WriteLine("5-Profiterol");
            //    Console.WriteLine("6-Ekler");
            //    Console.WriteLine("------------------\n");
            //}
            //else if (menuItem == '5')
            //{
            //    Console.WriteLine("\nİçecekler\n------------------\n");
            //    Console.WriteLine("1-Limonata");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Portakal Suyu");
            //    Console.WriteLine("4-Ayran");
            //    Console.WriteLine("5-Çay");
            //    Console.WriteLine("6-Türk Kahvesi");
            //    Console.WriteLine("7-Su");
            //    Console.WriteLine("------------------\n");
            //}
            #endregion

            #region Switch Case
            //Console.WriteLine("Lütfen bir ay girin (Örnek: Ocak ise 1/Şubat ise 2): ");
            //int monthNum = int.Parse(Console.ReadLine());

            //switch (monthNum)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz giriş!");
            //        break;
            //}
            #endregion

            #region Hesap Makinesi - Switch Case
            //double num1, num2, result = 0;
            //Console.Write("1.Sayı: ");
            //num1 = double.Parse(Console.ReadLine());
            //Console.Write("2.Sayı: ");
            //num2 = double.Parse(Console.ReadLine());
            //Console.Write("İşlem: ");
            //char symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz işlem");
            //        break;
            //}
            //Console.WriteLine(result);
            #endregion

            Console.ReadLine();
        }
    }
}
