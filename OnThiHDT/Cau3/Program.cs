using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    class Program
    {
        static void Main(string[] args)
        {
            //test cau 3a:
            LinkedList<Account> list = NhapDanhSachAccount();

            //test cau 3b làm xong luôn rồi hở chưa má còn câu c
            InDanhSach(list);

            //test cau 3c -1
            Console.WriteLine(FindMaxInterest(list).toString());

            //test cau 3c -2
            Console.WriteLine(SumInterest(list));

            //test cau 3c-3
            Console.WriteLine(Account.Count);

            //test cau 3d
            LinkedList<Account> listD = new LinkedList<Account>();
            listD.AddLast(new SavingAccount("Bao", "Ngoc", "1", "1", 2, 3, 4));
            listD.AddLast(new CurrentAccount("Bao", "Ngoc", "1", "1", 2));

            InDanhSach(listD);
        }

        static long SumInterest(LinkedList<Account> list)
        {
            long tong = 0;
            //magic 
            for (LinkedListNode<Account> i = list.First; i != null; i = i.Next)
            {
                tong += i.Value.GetInterest();
            }
            return tong;
        }

        static Account FindMaxInterest(LinkedList<Account> list)
        {
            long max = list.First.Value.GetInterest();
            // doi xiu hihi 
            //magic 
            for (LinkedListNode<Account> i = list.First.Next; i != null; i = i.Next)
            {
                if (max < i.Value.GetInterest())
                {
                    return i.Value;
                }
            }
            return list.First.Value;
        }

        static void InDanhSach(LinkedList<Account> list)
        {
            foreach (Account ac in list)
            {
                Console.WriteLine(ac.toString());
            }
        }
        static LinkedList<Account> NhapDanhSachAccount()
        {
            //khai bao bien
            int n = 0;
            LinkedList<Account> list = new LinkedList<Account>();

            //Nhap so luong Account
            Console.Write("Nhap so luong Account: ");
            int.TryParse(Console.ReadLine(), out n);
            //Nhap thong tin va them vao list
            for (int i = 0; i < n; i++)
            {
                list.AddLast(NhapAccount());
            }
            return list;
        }
        static Account NhapAccount()
        {
            //khai bao bien
            int choose = 0;
            string firstName = "";
            string lastName = "";
            string ward = "";
            string city = "";
            long amount = 0L;
            int period = 0;
            double rate = 0.0d;
            long balance = 0L;

            //chon
            Console.WriteLine("1: Saving Account");
            Console.WriteLine("2: Current Account");
            Console.Write("Ban chon: ");
            int.TryParse(Console.ReadLine(), out choose);
            //nhap 
            Console.Write("First name: ");
            firstName = Console.ReadLine();

            Console.Write("Last name: ");
            lastName = Console.ReadLine();

            Console.Write("Ward: ");
            ward = Console.ReadLine();

            Console.Write("City: ");
            city = Console.ReadLine();

            if (choose == 1)
            {
                Console.Write("Amount: ");
                long.TryParse(Console.ReadLine(), out amount);

                Console.Write("Period: ");
                int.TryParse(Console.ReadLine(), out period);

                Console.Write("Rate: ");
                double.TryParse(Console.ReadLine(), out rate);

                return new SavingAccount(firstName, lastName, ward, city, amount, period, rate);
            }
            else
            {
                Console.Write("Balance: ");
                long.TryParse(Console.ReadLine(), out balance);

                return new CurrentAccount(firstName, lastName, ward, city, balance);
            }
        }
    }
}
