using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            method m = new method();

            Console.WriteLine("*******************************************");
            Console.WriteLine("************  TELEFON REHBERİ  ************");
            Console.WriteLine("*******************************************\n");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak\n");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : "); string operation = Console.ReadLine();
            Console.WriteLine( );
            switch (operation)
            {
                case "1":
                    m.FirstOperation();
                    break;
                case "2":
                    m.SecondOperation();
                    break;
                case "3":
                    m.ThirdOperation();
                    break;
                case "4":
                    m.FourthOperation();
                    break;
                case "5":
                    m.FifthOperation();
                    break;
                default:
                    Console.WriteLine("Lütfen yukarıdaki işlemlerden birini seçiniz ! ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
