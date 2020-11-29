using System;

namespace StoreLibrary.Models
{
    public class Model_SaleInvoice
    {
        /// <summary>
        /// Mã Hóa Đơn Bán
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Nhân Viên
        /// </summary>
        public string EmployeeID { get; set; }
        /// <summary>
        /// Khách hàng
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// Ngày Bán
        /// </summary>
        public DateTime day { get; set; }
        /// <summary>
        /// Tổng Tiền Hóa Đơn Bán
        /// </summary>
        public decimal Total { get; set; }
    }
}
