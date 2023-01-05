namespace ProjectC.Models
{
    public record Account
    {

        public Guid id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Boolean isAdmin { get; set; }
        public Account(Guid id, string username, string password, Boolean isAdmin)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
        }


    }
}
