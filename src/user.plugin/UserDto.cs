namespace User.plugin
{

    public class User
    {

        public Guid id { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public User(Guid id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

    }

}