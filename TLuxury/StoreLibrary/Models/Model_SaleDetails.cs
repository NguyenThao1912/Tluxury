namespace StoreLibrary.Models
{
    public class Model_SaleDetails
    {
        /// <summary>
        ///  Hóa Đơn Bán (PK)
        /// </summary>
        public Model_SaleInvoice Sale { get; set; }
        /// <summary>
        /// Sản Phẩm
        /// </summary>
        public Model_Product Product { get; set; }
        /// <summary>
        /// Số Lượng mua
        /// </summary>
        public int Quantity { get; set; }
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
