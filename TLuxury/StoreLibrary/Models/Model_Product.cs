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
        public Model_Category Category { get; set; } = new Model_Category();
        /// <summary>
        /// Kích Cỡ
        /// </summary>
        public Model_Size Size { get; set; } = new Model_Size();
        /// <summary>
        /// Chất Liệu
        /// </summary>
        public Model_RawMaterial Material { get; set; } = new Model_RawMaterial();
        /// <summary>
        /// Màu
        /// </summary>
        public Model_Color Color { get; set; } = new Model_Color();
        /// <summary>
        /// Đối tượng Sử dụng
        /// </summary>
        public Model_Object Object { get; set; } = new Model_Object();
        /// <summary>
        /// Mùa
        /// </summary>
        public Model_Season Season { get; set; } = new Model_Season();
        /// <summary>
        /// Nhà sản xuất
        /// </summary>
        public Model_Manufactured Manufactured { get; set; } = new Model_Manufactured();
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
        public Model_Product(string iD,string name,string cate,string size,string mate,string color,string @object,string season,string manu ,string quantity,string priceEntry,string pricesell,string pic)
        {
            ID = iD;
            Name = name;
            Size.Size = size;
            Category.Name = cate;
            Material.Name = mate;
            Color.Name = color;
            Object.Name = @object;
            Season.Name = season;
            Manufactured.Name = manu;
            Quantity = int.Parse(quantity);
            PriceEntry = decimal.Parse(priceEntry);
            PriceSell = decimal.Parse(pricesell);
            Picture = pic;
        }
    }
}
