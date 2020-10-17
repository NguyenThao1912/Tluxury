using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class Model_Supplier
    {
        /// <summary>
        /// Mã Nhà Cung cấp
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Tên Nhà Cung Cấp
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Địa Chỉ Nhà Cung Cấp
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Số Điện Thoại Nhà cung cấp
        /// </summary>
        public string PhoneNumber { get; set; }

        public Model_Supplier()
        {
        }

        public Model_Supplier(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
