/*
 * Phan Hong Bao Ngoc
 * 25/08/2020
 * Mo ta: Cau 2 Tao lop SavingAccount : Account theo yeu cau de
 */

namespace Cau2
{
    class SavingAccount : Account
    {
        //fields
        private long amount;
        private int period;
        private double rate;

        //properites
        public long Amount { get => amount; set => amount = value; }
        public int Period { get => period; set => period = value; }
        public double Rate { get => rate; set => rate = value; }

        //constructors
        /// <summary>
        /// PTKT khong tham so
        /// </summary>
        public SavingAccount() :base() { }

        /// <summary>
        /// PTKT 7 tham so
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="ward"></param>
        /// <param name="city"></param>
        /// <param name="amount"></param>
        /// <param name="period"></param>
        /// <param name="rate"></param>
        public SavingAccount(string firstName, string lastName, string ward, string city,long amount, int period, double rate) :base(firstName,lastName,ward,city)
        {
            this.amount = amount;
            this.period = period;
            this.rate = rate;
        }

        /// <summary>
        /// ham huy
        /// </summary>
        ~SavingAccount() { }

        /// <summary>
        /// tinh tien lai
        /// </summary>
        /// <returns></returns>
        public override long GetInterest()
        {
            return amount * (long)rate * period;
        }

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
