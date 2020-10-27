using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class Model_Category
    {
        /// <summary>
        /// ID of this category (T-Shirt ,Dress ,hat,...)
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Name of Category
        /// </summary>
        public string Name { get; set; }
    }
}
