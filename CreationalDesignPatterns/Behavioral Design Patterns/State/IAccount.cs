namespace CreationalDesignPatterns.Behavioral_Design_Patterns.State
{
    public interface IAccount
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public string CreateElements();
        public string Buy();
        public string ChangeSettings();
    }
}