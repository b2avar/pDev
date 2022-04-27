using System;
using System.Collections;

namespace DemoPhonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // İsimler ve numaralar rasgele yazılmıştır.
            List.phonebookList.Add(new PhonebookList("Aslı", "Taşpınar", "5551115555"));
            List.phonebookList.Add(new PhonebookList("Bayram", "Yılmaz", "5552225555"));
            List.phonebookList.Add(new PhonebookList("Ceyda", "Öztürk", "5553335555"));
            List.phonebookList.Add(new PhonebookList("Deniz", "Sönmez", "5553335555"));
            List.phonebookList.Add(new PhonebookList("Ersin", "Öztürk", "5553335555"));

            bool conTinue = true;
            while (conTinue)
            {

                switch (GetChoose())
                {
                    case 1:
                        Controls.Add();
                        break;
                    case 2:
                        Controls.Delete();
                        break;
                    case 3:
                        Controls.Update();
                        break;
                    case 4:
                        Controls.ListDirectory();
                        break;
                    case 5:
                        Controls.Search();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? (y/n)");
                char answer = char.Parse(Console.ReadLine());
                if(answer != 'y'){
                    
                    conTinue = false;
                    Console.WriteLine("İşlem tamamlandı");
                }
                else if(answer == 'n'){

                    Console.WriteLine("İşlem tamamlandı");
                }
            }

            Console.WriteLine("Güncel Liste:");
            Console.WriteLine("**********************************************");
            Controls.ListDirectory();
        }



        static int GetChoose()
        {
            try
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("*******************************************");

                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                sbyte chooseOption = Convert.ToSByte(Console.ReadLine());



                if (chooseOption > 0 && chooseOption < 6)
                {
                    return chooseOption;

                }
                Console.WriteLine("Seçim bulunamadı!");
                Console.WriteLine("Lütfen yapmak istediğiniz işleme göre ekranda bulunan numaralardan birini giriniz!");
                Console.WriteLine();
                return GetChoose();
            }
            catch
            {
                Console.WriteLine("Seçim bulunamadı!");
                Console.WriteLine("Lütfen yapmak istediğiniz işleme göre ekranda bulunan numaralardan birini giriniz!");
                Console.WriteLine();
                return GetChoose();
            }
        }
    }
}
