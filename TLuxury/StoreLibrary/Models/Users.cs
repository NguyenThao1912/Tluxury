namespace StoreLibrary.Models
{
    public class Users
    {
        public string username { get; set; }
        public string password { get; set; }
        public int status { get; set; }
        public int role { get; set; }
        public int islogin { get; set; } = 0;
    }
}
