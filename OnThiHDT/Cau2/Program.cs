using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            //test SavingAccount
            Account ac1 = new SavingAccount("Bao", "Ngoc", "1", "1", 2, 3, 4);
            Console.WriteLine(ac1.toString());

            //test CurrentAccount
            Account ac2 = new CurrentAccount("Bao", "Ngoc", "1", "1", 2);
            Console.WriteLine(ac2.toString());

        }
    }
}
