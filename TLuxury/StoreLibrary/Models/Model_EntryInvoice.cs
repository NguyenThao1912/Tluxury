using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class Model_EntryInvoice
    {
        /// <summary>
        /// Mã Hóa đơn
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Mã Nhân Viên 
        /// </summary>
        public string EmployeeID { get; set; }
        /// <summary>
        /// Ngày Nhập Hàng
        /// </summary>
        public DateTime Day { get; set; }
        /// <summary>
        /// Mã Nhà Cung Cấp
        /// </summary>
        public string SupplierID { get; set; }
        /// <summary>
        /// Tổng Tiền Hóa Đơn Nhập
        /// </summary>
        public decimal Total { get; set; }
    }
}
