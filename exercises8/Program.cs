using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace exercises8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kullaniciAdi;
            string sifre;

            Console.WriteLine("Kullanici adini girin : ");
            kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Sifrenizi girin : ");
            sifre = Console.ReadLine();

            Login(kullaniciAdi,sifre);

            Console.Read();

        }

        static void Login(string userName,string password)
        {
            string kullaniciAdi = "zeynep";
            string sifre = "abc*123";

            //if(userName == "zeynep" && password == "abc*123")
            if (userName == kullaniciAdi && password == sifre)
            {
                Console.Clear();
                Console.WriteLine("Kullanici adi ve sifreniz dogru");
                Console.WriteLine("*******************************");
                Console.WriteLine("Sisteme hos geldiniz");
                Console.WriteLine("*******************************");
            }
            else
            {
                Console.WriteLine("Kullanici adi veya sifre hatali");
            }
        }

    }
}
