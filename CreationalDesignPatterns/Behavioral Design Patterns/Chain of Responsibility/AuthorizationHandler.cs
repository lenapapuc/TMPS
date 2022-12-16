using System;
using System.Linq;
using CreationalDesignPatterns.Behavioral_Design_Patterns.State;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns.Chain_of_Responsibility
{
    public class AuthorizationHandler : IHandler
    {
        public override void ProcessRequest(Login login)
        {
            var us = from u in FauxDatabase.Users
                where u.UserName == login.UserName && u.Password == login.Password
                select new
                {
                    Role = u.Role
                };
            
            
            foreach (var element in us)
            {
        
                if (element.Role == "buyer") Console.WriteLine($"{login.UserName} Welcome to the store");
                else if (element.Role == "administrator") {Console.WriteLine($"Hello administrator {login.UserName}");}
                
            }
            
            if (us.Count() > 1)
            {
                Console.WriteLine("What account are you tryinng to get into?");
                string st = Console.ReadLine();
                Context context = new Context(login.UserName, st);
                context.Buy();
                context.ChangeSettings();
                context.CreateElements();
            }

        }
    }
}