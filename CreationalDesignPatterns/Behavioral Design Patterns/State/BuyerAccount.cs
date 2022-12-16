using System;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns.State
{
    public class BuyerAccount: IAccount
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public string CreateElements()
        {
            return "You are not allowed to create new elements. Go to your administrator account";
        }

        public string Buy()
        {
            return "Start buying our beautiful sets";
        }

        public string ChangeSettings()
        {
            return "You are not allowed to create new elements. Go to your administrator account";
        }
    }
}