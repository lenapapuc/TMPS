using System;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns.State
{
    public class AdministratorAccount : IAccount
    {
        public string UserName { get; set; }
        
        public string Role { get; set; }

        public string CreateElements()
        {
            return "Start creating elements";
        }

        public string Buy()
        {
            return "You are not allowed to create new elements. Go to your buyer account";
        }

        public string ChangeSettings()
        {
            return "Change settings";
        }
    }
}