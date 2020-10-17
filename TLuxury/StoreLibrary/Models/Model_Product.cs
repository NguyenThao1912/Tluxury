using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class Model_Product
    {
        /// <summary>
        /// Mã Sản Phẩm
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Tên Sản Phẩm
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Loại sản Phẩm
        /// </summary>
        public Model_Category Category { get; set; }
        /// <summary>
        /// Kích Cỡ
        /// </summary>
        public Model_Size Size { get; set; }
        /// <summary>
        /// Chất Liệu
        /// </summary>
        public Model_RawMaterial Material { get; set; }
        /// <summary>
        /// Màu
        /// </summary>
        public Model_Color Color { get; set; }
        /// <summary>
        /// Đối tượng Sử dụng
        /// </summary>
        public Model_Object Object { get; set; }
        /// <summary>
        /// Mùa
        /// </summary>
        public Model_Season Season { get; set; }
        /// <summary>
        /// Nhà sản xuất
        /// </summary>
        public Model_Manufactured Manufactured { get; set; }
        /// <summary>
        /// Số Lượng
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Ảnh
        /// </summary>
        public string Picture { get; set; } = "Khong co anh";
        /// <summary>
        /// Giá Nhập
        /// </summary>
        public decimal PriceEntry { get; set; }
        /// <summary>
        /// Giá bán
        /// </summary>
        public decimal PriceSell { get; set; }

        public Model_Product()
        {

        }

        public Model_Product(string name, Model_Category category, Model_Size size, Model_RawMaterial material, Model_Color color, Model_Object @object, Model_Season season, Model_Manufactured manufactured, int quantity, decimal priceEntry, decimal priceSell)
        {
            Name = name;
            Category = category;
            Size = size;
            Material = material;
            Color = color;
            Object = @object;
            Season = season;
            Manufactured = manufactured;
            Quantity = quantity;
            PriceEntry = priceEntry;
            PriceSell = priceSell;
        }
    }
}
