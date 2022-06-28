using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    internal class method
    {
        List<data> Data = new List<data>();  

        public method()
        {
            Data.Add(new data("Mehmet", "Aydın", "1234"));
            Data.Add(new data("Feriha", "Yılmaz", "2345"));
            Data.Add(new data("Havva", "Aydın", "3456"));
            Data.Add(new data("Seval", "Topal", "4567"));
            Data.Add(new data("Nur", "Gül", "7891"));
        }

        public void FirstOperation()
        {
            data data1 = new data();
            Console.Write("İsim giriniz              : ");
            data1.Name = Console.ReadLine();
            Console.Write("Soyisim giriniz           : ");
            data1.Surname = Console.ReadLine();
            Console.Write("Telefon numarası giriniz  : ");
            data1.Phone = Console.ReadLine(); Console.WriteLine();

            Data.Add(data1);
            Console.WriteLine("Başarıyla kaydedildi. \n");
            Console.WriteLine("İsim : " + Data[Data.Count - 1].Name);
            Console.WriteLine("Soyisim : " + Data[Data.Count - 1].Surname);
            Console.WriteLine("Telefon Numarası : " + Data[Data.Count - 1].Phone);
        }

        public void SecondOperation()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını/soyadını giriniz : ");
            string input = Console.ReadLine();
            int cont = 2;
            do
            {
                foreach (var item in Data)
                {
                    if ((Data.IndexOf(item) == Data.Count - 1) &&
                        !(input.ToLower() == item.Name.ToLower() || input.ToLower() == item.Surname.ToLower()))
                    { 
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        cont = Convert.ToInt32(Console.ReadLine());

                        switch (cont)
                        {
                            case 1:
                                Console.WriteLine("İşleminiz sonlandırıldı.");
                                break;
                            case 2:
                                SecondOperation();
                                cont = 1;
                                break;
                        }
                    }
                    else if (input.ToLower() == item.Name.ToLower() || input.ToLower() == item.Surname.ToLower())
                    {
                        Console.Write(item.Name + " " + item.Surname + " : " + item.Phone + " kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n) : ");
                        char answer = Convert.ToChar(Console.ReadLine());

                        if (answer == 'y')
                        {
                            Console.WriteLine(item.Name + " " + item.Surname + " : " + item.Phone + " kişi silindi .\n");
                            cont = 1;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("İşlem iptal edildi.");
                            cont = 1;
                            break;
                        }
                    }
                }
            } while (cont == 2);
        }

        public void ThirdOperation()
        {
            int cont = 2;
            do
            {
                Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını/soyadını giriniz : ");
                string input = Console.ReadLine();

                foreach (var item in Data)
                {
                    if ((Data.IndexOf(item) == Data.Count - 1) &&
                        !(input.ToLower() == item.Name.ToLower() ||
                        input.ToLower() == item.Surname.ToLower()))
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için : (2)");
                        cont = Convert.ToInt32(Console.ReadLine());

                        switch (cont)
                        {
                            case 1:
                                Console.WriteLine("İşlem sonlandırıldı . ");
                                break;
                            case 2:
                                ThirdOperation();
                                cont = 1;
                                break;
                        }
                    }
                    else if (input.ToLower() == item.Name.ToLower() ||
                            input.ToLower() == item.Surname.ToLower())
                    {
                        Console.Write(item.Name + " " + item.Surname + ":" + item.Phone + " kişi bilgileri güncellenmek üzere, onaylıyor musunuz ?(y/n) : ");
                        char answer = Convert.ToChar(Console.ReadLine());

                        if (answer == 'y')
                        {
                            Console.Write("Lütfen güncel isim giriniz             : ");
                            item.Name = Console.ReadLine();
                            Console.Write("Lütfen güncel soyisim giriniz          : ");
                            item.Surname = Console.ReadLine();
                            Console.Write("Lütfen güncel telefon numarası giriniz : ");
                            item.Phone = Console.ReadLine();
                            Console.WriteLine(item.Name + " " + item.Surname + " : " + item.Phone + " kişi olarak güncellendi\n");
                            cont = 1;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("İşlem iptal edildi.");
                            cont = 1;
                            break;
                        }
                    }
                }
            } while (cont == 2);
        }

        public void FourthOperation()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " : " + item.Phone);

            }
            Console.WriteLine("\n"+ Data.Count + " adet kayıt vardır.");

        }

        public void FifthOperation()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz .\n");
            Console.WriteLine("İsim/soyisme göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int n = Convert.ToInt32(Console.ReadLine()); 

            if (n == 1)
            {
                Console.Write("İsim/soyisim giriniz : ");
                string input = Console.ReadLine();

                foreach (var item in Data)
                {
                    if ((Data.IndexOf(item) == Data.Count - 1) &&
                    !(input.ToLower() == item.Name.ToLower() || input.ToLower() == item.Surname.ToLower()))
                    {                     
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                    }
                    else if (input.ToLower() == item.Name.ToLower() || input.ToLower() == item.Surname.ToLower())
                    {
                        Console.WriteLine("\nİsim: " + item.Name + "\nSoyisim: " + item.Surname + "\nTelefon Numarası: " + item.Phone);
                    }
                }
            }
            else if (n == 2)
            {
                Console.Write("Telefon numarasını giriniz : ");
                string phoneNumber = Console.ReadLine();

                foreach (var item in Data)
                {
                    if ((Data.IndexOf(item) == Data.Count - 1) && (phoneNumber != item.Phone))
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                    }
                    else if (phoneNumber == item.Phone)
                    {
                        Console.WriteLine("\nİsim: " + item.Name + "\nSoyisim: " + item.Surname + "\nTelefon Numarası: " + item.Phone);
                    }
                }
            }
        }
    }
}
