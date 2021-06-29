namespace Stockpile
{
    public class Wishlists
    {
        private string userID;
        private string listName;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string ListName
        {
            get { return listName; }
            set { listName = value; }
        }
    }
}
