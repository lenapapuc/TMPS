using System;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using CreationalDesignPatterns.Behavioral_Design_Patterns;
using CreationalDesignPatterns.Behavioral_Design_Patterns.Chain_of_Responsibility;
using CreationalDesignPatterns.Builders;
using CreationalDesignPatterns.Structural_Design_Patterns;
using CreationalDesignPatterns.Structural_Design_Patterns.Composite;

namespace CreationalDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bracelet bracelet = new FreshWaterBracelet();
            //bracelet.Accept(new Construct());

            Login us = new Login("chucky1", "passtest");
            Login us1 = new Login("chucky2", "pass");

            IHandler handler1 = new LoginHandler();
            IHandler handler2 = new AuthorizationHandler();
            handler1.SetSuccessor(handler2);
            
            handler1.ProcessRequest(us);
        }
    }
}