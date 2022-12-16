namespace CreationalDesignPatterns.Behavioral_Design_Patterns.Chain_of_Responsibility
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
       
        
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}