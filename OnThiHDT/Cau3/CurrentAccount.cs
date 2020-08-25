
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    class CurrentAccount : Account
    {
        //fields
        private long balance;

        //properties
        public long Balance { get => balance; }

        //constructors
        /// <summary>
        /// PTKT khong tham so
        /// </summary>
        public CurrentAccount() : base() { }

        /// <summary>
        /// PTKT 5 tham so
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="ward"></param>
        /// <param name="city"></param>
        /// <param name="balance"></param>
        public CurrentAccount(string firstName, string lastName, string ward, string city, long balance) : base(firstName, lastName, ward, city)
        {
            this.balance = balance;
        }

        /// <summary>
        /// in
        /// </summary>
        /// <returns></returns>
        public override long GetInterest()
        {
            return (long)(balance * 0.01);
        }

        // lam choi
        //public long UpdateBalance(long newBalance)
        //{
        //    balance = newBalance;
        //    return balance;
        //}

        /// <summary>
        /// in
        /// </summary>
        /// <returns></returns>
        public override string toString()
        {
            return $"{FirstName} + {LastName} + {Address.toString()} + {GetInterest()}";
        }
    }
}
