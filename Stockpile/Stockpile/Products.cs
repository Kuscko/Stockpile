using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Stockpile
{
    public class Products
    {
        private string productId;
        private string supplierId;
        private string type;
        private string name;
        private string picture;
        private string description;
        private int ordered;
        private int inStock;
        private decimal price;
       

        public string ProductID
        {
            get { return productId; }
            set { productId = value; }
        }

        public string SupplierID
        {
            get { return supplierId; }
            set { supplierId = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public int Ordered
        {
            get { return ordered; }
            set { ordered = value; }
        }

        public int InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string FormatCart()
        {
            return name + "\t" + ordered.ToString() + "\t" + price.ToString("C");
        }

        public string productFormat() {
            return productId + "\t" + type + "\t" + name + "\t" + price.ToString("C");
        } 
    }
}
