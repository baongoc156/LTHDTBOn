/*
 * Phan Hong Bao Ngoc
 * 25/08/2020
 * Mo ta: Cau 2 Tao lop Account theo yeu cau de
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
     abstract class Account
    {
        //fields
        private int iD;
        private string firstName;
        private string lastName;
        private Address address;
        private static int count;
        //properties
        public int ID { get => iD; }
        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        internal Address Address { get => address; set => address = value; }
        public static int Count { get => count; set => count = value; }

        //constructors
        /// <summary>
        /// PTKT khong tham so
        /// </summary>
        public Account()
        {
            count = 0;
        }

        /// <summary>
        /// PTKT 4 tham so
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="ward"></param>
        /// <param name="city"></param>
        public Account(string firstName, string lastName, string ward, string city)
        {
            this.iD = ++count;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = new Address(ward, city);
        }

        //methods
        /// <summary>
        /// in
        /// </summary>
        /// <returns></returns>
        public abstract string toString();

        /// <summary>
        /// tinh tien lai
        /// </summary>
        /// <returns></returns>
        public abstract long GetInterest();
       

        /// <summary>
        /// so sanh 2 dia chi cua 2 account giong nhau 2 fields tra ve true
        /// </summary>
        /// <param name="ac1"></param>
        /// <param name="ac2"></param>
        /// <returns></returns>
        public static bool operator ==(Account ac1, Account ac2)
        {
            if (ac1.address.Ward == ac2.address.Ward && ac1.address.City == ac2.address.City)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// so sanh 2 dia chi cua 2 account khac nhau it nhat 1 field tra ve true
        /// </summary>
        /// <param name="ac1"></param>
        /// <param name="ac2"></param>
        /// <returns></returns>
        public static bool operator !=(Account ac1, Account ac2)
        {
            if (ac1.address.Ward != ac2.address.Ward || ac1.address.City != ac2.address.City)
            {
                return true;
            }
            return false;

        }
    }
}
