using System;
using System.Linq;
using System.Net;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns.Chain_of_Responsibility
{
    public class LoginHandler : IHandler
    {
        public override void ProcessRequest(Login login)
        {
            var us = from u in FauxDatabase.Users
                where (u.UserName == login.UserName && u.Password == login.Password)
                select new
                {
                    UserName = u.UserName,
                    Password = u.Password
                };
           
            if (us.Count() < 0) Console.WriteLine("Such user doesn't exist!");
            else if (successor != null)
            {
                successor.ProcessRequest(login);
            }
        
        }
    }
}