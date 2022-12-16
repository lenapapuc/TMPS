namespace CreationalDesignPatterns.Behavioral_Design_Patterns.Chain_of_Responsibility
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        
        public string email { get; set; }
        
        public User(string userName, string password, string role, string email)
        {
            UserName = userName;
            Password = password;
            Role = role;
            this.email = email;
        }
        
        
    }
}