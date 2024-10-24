using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            /*void metotlar, geriye değer döndürmezler.*/
            //void CustomerList()
            //{
            //    Console.WriteLine("Betül");
            //    Console.WriteLine("Ada");
            //    Console.WriteLine("Murat");
            //    Console.WriteLine("Serkan");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1, y = 2, z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Geriye Deger Dondurmeyen String Parametreli Metotlar
            //void SayHello(string customerName)
            //{
            //    Console.WriteLine("Hello " + customerName);
            //}
            //SayHello("Betül");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surname}");
            //}
            //Console.Write("Ad: ");
            //string cName = Console.ReadLine();
            //Console.Write("Soyad: ");
            //string cSurname = Console.ReadLine();
            //CustomerCard(cName, cSurname);
            #endregion

            #region Geriye Deger Dondurmeyen Int Parametreli Metotlar
            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion

            #region Geriye Deger Donduren Metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Deger Donduren String Parametreli Metotlar
            //string CountryCard(string name, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + name + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke: ");
            //x = Console.ReadLine();
            //Console.Write("Başkent: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengi: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "İstanbul", "Kırmızı/Beyaz"));
            #endregion

            #region Geriye Deger Donduren Int Parametreli Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(34, 46));
            //Console.WriteLine(Sum(99, 40));
            #endregion

            #region Ornek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result >= 50)
                {
                    return student + " geçti.\n Not Ortalaması : " + result;
                }
                else
                {
                    return student + " kaldı!\n Not Ortalaması : " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine();
            Console.WriteLine(ExamResult("Ayşe", 36, 50, 33));
            Console.WriteLine();
            Console.WriteLine(ExamResult("Baran", 90, 78, 93));
            #endregion
            Console.Read();
        }
    }
}
