/*
 * Phan Hong Bao Ngoc
 * 25/08/2020
 * Mo ta: Cau 1 Tao lop Address theo yeu cau de
 */ 
namespace Cau1
{
    class Address
    {
        //fields
        private string ward;
        private string city;

        //properties
        public string Ward { get => ward; set => ward = value; }
        public string City { get => city; set => city = value; }
        
        //constructors
        /// <summary>
        /// PTKT khong tham so
        /// </summary>
        public Address() { }

        /// <summary>
        /// PTKT 2 tham so
        /// </summary>
        /// <param name="ward"></param>
        /// <param name="city"></param>
        public Address(string ward, string city)
        {
            this.ward = ward;
            this.city = city;
        }

        /// <summary>
        /// Ham huy
        /// </summary>
        ~Address() { }

        //methods
        /// <summary>
        /// in
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            return $"Address: {ward}, {city}";
        }
    }
}
