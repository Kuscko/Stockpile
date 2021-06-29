namespace Stockpile
{
    public class WishlistItems
    {
        private string listName;
        private string productName;
        private string productDescription;
        private int quantity;
        private decimal price;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public string ListName
        {
            get { return listName; }
            set { listName = value; }
        }
    }
}
