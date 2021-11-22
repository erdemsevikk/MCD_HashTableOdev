using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MCD_HashTableOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hashtable içerisine ENG - TR olarak data eklemeniz.
            /*
             * Yeni kayıt eklemek istiyormusunuz E/H
             * E : Yeni Kayıt ekleme işlemi devam etsin,
             * H : Tüm listeyi yazdırın.
             * 
             * Var lan bir key değeri ekliyor ise kullanıcıya bu değer daha önceden.. şeklinde sistemimizde bulunmaktadır
             * */

            Hashtable liste = new Hashtable();
           
            while (true)
            {

                baslangic:
                Console.WriteLine("Yeni kayıt eklemek istiyormusunuz ? E/H");
                string devam = Console.ReadLine();
                devam.ToLower();

                if (devam == "e")
                {
                    Console.WriteLine("Eklemek istediğiniz keyi yazınız.");
                    string key = Console.ReadLine();

                    if (liste.ContainsKey(key))
                    {
                        Console.WriteLine($" Bu değer daha önceden {liste[key]} şeklinde sistemimizde bulunmaktadır.");
                    }
                    else
                    {
                        Console.WriteLine("Eklemek istediğiniz değeri yazınız.");
                        string deger = Console.ReadLine();
                        liste.Add(key, deger);
                    }
                }

                else if(devam == "h")
                {
                    foreach (DictionaryEntry de in liste)
                    {
                        Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
                        System.Threading.Thread.Sleep(2000);
                       
                    }
                    break;
                }

                else
                {
                    Console.WriteLine("Yanlış Giriş Yaptınız. Başa Yönlendiriliyorsunuz:");
                    System.Threading.Thread.Sleep(2000);
                    goto baslangic;
                }


            }
            Console.ReadLine();
        }
    }
}
