using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class Model_Employee
    {
        /// <summary>
        /// Mã Nhân Viên
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Tên Nhân Viên
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Giới Tính
        /// </summary>
        public Char Sex { get; set; }
        /// <summary>
        /// Ngày Sinh Nhân Viên
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Số Điện Thoại Nhân Viên
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Địa Chỉ Nhân Viên
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Mã Chức Vụ
        /// </summary>
        public Model_Role Role { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"> Tên Nhân Viên</param>
        /// <param name="sex"> Giới Tính</param>
        /// <param name="dateOfBirth">Ngày Sinh</param>
        /// <param name="phoneNumber">Số điện Thoại</param>
        /// <param name="address">Địa chỉ</param>
        /// <param name="roleID"> mã Chức vụ</param>
        public Model_Employee(string firstName, char sex, DateTime dateOfBirth, string phoneNumber, string address, Model_Role role)
        {
            Name = firstName;
            Sex = sex;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
            Role = role;
        }

        public Model_Employee()
        {
        }
    }
}
