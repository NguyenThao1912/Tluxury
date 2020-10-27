using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class Model_EntryDetails
    {
        /// <summary>
        /// Mã Hóa đơn Nhập
        /// </summary>
        public string EntryID { get; set; }
        /// <summary>
        /// Mã quần áo/ mã sản phẩm
        /// </summary>
        public string ProductID { get; set; }
        /// <summary>
        /// Số Lượng
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Giá của 1 sản Phẩm
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// Giảm giá = (số % giảm )/100 đơn vị %
        /// </summary>
        public float Discount { get; set; }
        /// <summary>
        /// Tổng Tiền
        /// </summary>
        public decimal Total { get; set; }
    }
}
