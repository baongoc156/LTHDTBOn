/*
 * Phan Hong Bao Ngoc
 * 25/08/2020
 * Mo ta: Chay chuong trinh test cau 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test toString cua lop address
            Address ad1 = new Address("Duong a", "TP.HCM");
            Console.WriteLine(ad1.toString());

            //test toString cua lop Account
            Account ac1 = new Account("Bao", "Ngoc", "Duong a", "TP.HCM");
            Console.WriteLine(ac1.toString());


            //test operator so sanh 2 dia chi cua 2 account
            // operator ==
            Account ac2 = new Account("Ngoc", "Bao", "Duong a", "TP.HCM");
            Console.WriteLine(ac2.toString());
            Console.WriteLine(ac1==ac2);

            //operator !=
            Console.WriteLine(ac1.toString());
            Account ac3 = new Account("Hong", "Ngoc", "Duong a", "Ha Noi");
            Console.WriteLine(ac3.toString());
            Console.WriteLine(ac1 != ac3);
        }
    }
}
