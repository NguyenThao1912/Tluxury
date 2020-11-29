namespace StoreLibrary.Models
{
    public class Model_Customer
    {
        /// <summary>
        /// Mã Khách Hàng start with KH0000
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Tên Khách Hàng
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Địa Chỉ Khách Hàng
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Số Điện Thoại Khách Hàng
        /// </summary>
        public string PhoneNumber { get; set; }

        public Model_Customer()
        {

        }

        public Model_Customer(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
