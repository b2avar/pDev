using System;

namespace DemoPhonebook
{
    public static class Controls
    {
        // (1) Yeni Numara Kaydetmek
        public static void Add()
        {

            PhonebookList person = new PhonebookList();
            Console.Write("Lütfen ad giriniz             :");
            person.Name = Console.ReadLine();
            Console.Write("Lütfen soyad giriniz          :");
            person.Surname = Console.ReadLine();
            person.PhoneNumber = GetPhoneNumber();
            List.phonebookList.Add(new PhonebookList(person.Name, person.Surname, person.PhoneNumber));
        }

        // (2) Varolan Numarayı Silmek
        public static void Delete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını veya soyadını giriniz:");
            string param = GetName();
            int searchControl = 0;

            if (param == "iptal")
            {

                Console.WriteLine("Silme işlemi iptal edildi.");
            }
            else
            {

                foreach (var item in List.phonebookList)
                {
                    if (item.Name.ToLower() == param.ToLower() || item.Surname.ToLower() == param.ToLower())
                    {

                        searchControl++;
                        Console.WriteLine(item.Name + " " + item.Surname + " " + item.PhoneNumber);
                    }
                }

                if (searchControl > 1)
                {
                    Console.WriteLine("{0} kişi bulundu", searchControl);
                    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz:");
                    Console.Write("Ad :");
                    string paramName = GetName();
                    Console.Write("Soyad :");
                    string paramSurName = GetName();
                    int finalControl;

                    finalControl = int.Parse(CheckNameSurname(paramName, paramSurName));

                    if (finalControl == 1)
                    {
                        Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", paramName, paramSurName);
                        char conf = char.Parse(Console.ReadLine());
                        if (conf == 'y')
                        {
                            List.phonebookList.RemoveAll(c => c.Name.ToLower() == paramName.ToLower() && c.Surname.ToLower() == paramSurName.ToLower());
                            Console.WriteLine("Kişi silindi");
                        }
                        else
                        {

                            Console.WriteLine("Silme işlemi iptal edildi");
                        }
                    }


                }
                else
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", param);
                    char conf = char.Parse(Console.ReadLine());
                    if (conf == 'y')
                    {
                        List.phonebookList.RemoveAll(c => c.Name.ToLower() == param.ToLower() || c.Surname.ToLower() == param.ToLower());
                        Console.WriteLine("Kişi silindi");
                    }
                    else
                    {

                        Console.WriteLine("Silme işlemi iptal edildi");
                    }
                }
            }
        }

        // (3) Varolan Numarayı Güncelleme
        public static void Update()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını veya soyadını giriniz:");
            string param = GetName();
            int searchControl = 0;

            if (param == "iptal")
            {
                Console.WriteLine("Güncelleme işlemi iptal edildi.");
            }
            else
            {

                foreach (var item in List.phonebookList)
                {
                    if (item.Name.ToLower() == param.ToLower() || item.Surname.ToLower() == param.ToLower())
                    {

                        searchControl++;
                        Console.WriteLine(item.Name + " " + item.Surname + " " + item.PhoneNumber);
                    }
                }

                if (searchControl > 1)
                {
                    Console.WriteLine("{0} kişi bulundu", searchControl);
                    Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ve soyadını giriniz:");
                    Console.Write("Ad :");
                    string paramName = GetName();
                    Console.Write("Soyad :");
                    string paramSurName = GetName();
                    int finalControl;

                    finalControl = int.Parse(CheckNameSurname(paramName, paramSurName));

                    if (finalControl == 1)
                    {
                        Console.WriteLine("Lütfen yeni bir numara giriniz :");
                        string newNumber = Console.ReadLine();

                        Console.WriteLine("{0} {1} isimli kişinin telefon numarası güncellenmek üzere, onaylıyor musunuz ?(y/n)", paramName, paramSurName);
                        char conf = char.Parse(Console.ReadLine());
                        if (conf == 'y')
                        {
                            foreach (var item in List.phonebookList)
                            {
                                if (paramName.ToLower() == item.Name.ToLower() && paramSurName.ToLower() == item.Surname.ToLower())
                                {
                                    item.PhoneNumber = newNumber;
                                }
                            }
                            Console.WriteLine("Kişi güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Güncelleme işlemi iptal edildi");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen yeni bir numara giriniz :");
                    string newNumber = Console.ReadLine();

                    Console.WriteLine("{0} isimli kişinin telefon numarası güncellenmek üzere, onaylıyor musunuz ?(y/n)", param);
                    char conf = char.Parse(Console.ReadLine());
                    if (conf == 'y')
                    {
                        foreach (var item in List.phonebookList)
                        {
                            if (param.ToLower() == item.Name.ToLower())
                            {
                                item.PhoneNumber = newNumber;
                            }
                        }
                        Console.WriteLine("Kişi güncellendi.");
                    }
                    else
                    {
                        Console.WriteLine("Güncelleme işlemi iptal edildi");
                    }
                }
            }

        }

        // (4) Rehberi Listelemek
        public static void ListDirectory()
        {

            Console.WriteLine("Rehber Listeleniyor...");
            foreach (var item in List.phonebookList)
            {

                Console.WriteLine(item.Name + " " + item.Surname + " " + item.PhoneNumber);
            }
        }

        // (5) Rehberde Arama Yapmak
        public static void Search(){

            string choise = SeacrhException();

            if (choise == "1"){
                Console.WriteLine("Lütfen aramak istediğiniz kişiye ait ad veya soyad giriniz :");
                string NameofSurname = GetName();
                foreach (var item in List.phonebookList)
                {
                    if (item.Name.ToLower() == NameofSurname.ToLower() || item.Surname.ToLower() == NameofSurname.ToLower())
                    {
                        Console.WriteLine("Ad: {0}", item.Name);
                        Console.WriteLine("Soyad: {0}", item.Surname);
                        Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber);
                        Console.WriteLine("    -    ");
                    }
                }
            }

            else if (choise == "2"){

                Console.WriteLine("Lütfen aramak istediğiniz kişiye ait telefon numarası giriniz :");
                string phoneNumber = GetPhoneNumber();
                foreach (var item in List.phonebookList)
                {
                    if (phoneNumber == item.PhoneNumber)
                    {
                        Console.WriteLine("Ad: {0}", item.Name);
                        Console.WriteLine("Soyad: {0}", item.Surname);
                        Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber);
                        Console.WriteLine("    -    ");
                        Console.WriteLine(".\n.");
                    }
                }
            }
            
        }

        // Diğer Metotlar

        // Telefon numarası kontrol metodu
        public static string GetPhoneNumber()
        {

            try
            {
                Console.Write("Lütfen telefon numarası giriniz :");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber.Length != 10)
                {
                    Console.WriteLine("Lütfen 10 haneli telefon numarası girin.");
                    return GetPhoneNumber();
                }
                return phoneNumber;
            }
            catch
            {
                Console.WriteLine("Lütfen 10 haneli telefon numarası girin.");
                return GetPhoneNumber();
            }

        }

        // Ad veya Soyad kontrol metodu
        public static string GetName()
        {

            try
            {
                string param = Console.ReadLine();
                int control = 0;
                foreach (var item in List.phonebookList)
                {
                    if (param.ToLower() == item.Name.ToLower() || param.ToLower() == item.Surname.ToLower())
                    {
                        control++;
                        return param;
                    }
                }

                if (control == 0)
                {

                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    string value = Console.ReadLine();

                    try
                    {
                        if (value == "2")
                        {
                            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz:");
                            return GetName();
                        }
                        else
                        {
                            return "iptal";
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Yanlış bir işlem yaptınız");
                        return GetName();
                    }
                }

                return GetName();
            }

            catch
            {
                Console.WriteLine("Yanlış bir işlem yaptınız");
                return GetName();
            }
        }


        // Ad ve Soyad kontrol metodu
        public static string CheckNameSurname(string name, string surname)
        {

            foreach (var item in List.phonebookList)
            {
                if (name.ToLower() == item.Name.ToLower() && surname.ToLower() == item.Surname.ToLower())
                {
                    return "1";
                }
            }

            return CheckNameSurname(name, surname);
        }

        // Arama seçimi kontrol metodu
        public static string SeacrhException(){

                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz");
                Console.WriteLine("**********************************************");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2) ");

                string number = Console.ReadLine();

                if(number == "1"){

                    return number;
                }
                else if (number == "2"){

                    return number;
                }

                else
                {
                  Console.WriteLine("Hatalı bir seçim yaptınız!");
                  return SeacrhException();  
                }
        } 
    }
}
