using System;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns.State
{
    public class Context
    {
        private IAccount _account;
        private string Name;
        private string Role;

        public Context(string Name, string role)
        {
            this.Name = Name;
            this.Role = role;
            if (role == "administrator") _account = new AdministratorAccount();
            else
            {
                _account = new BuyerAccount();
            }
        }

        public void CreateElements()
        {
            Console.WriteLine(_account.CreateElements());
        }

        public void ChangeSettings()
        {
           Console.WriteLine(_account.ChangeSettings()); 
        }

        public void Buy()
        {
            Console.WriteLine(_account.Buy());
        }

    }
}