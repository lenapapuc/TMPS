using System;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using CreationalDesignPatterns.Builders;
using CreationalDesignPatterns.Structural_Design_Patterns;
using CreationalDesignPatterns.Structural_Design_Patterns.Composite;

namespace CreationalDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
             while (true)
            {
                Console.WriteLine("What set would you like to buy today?");
                Console.WriteLine("Write 1 for the Fresh Water Pearl Set");
                Console.WriteLine("Write 2 for the Hardwear Ball Set");
                Console.WriteLine("Write q if you want to exit.");
                Console.WriteLine("Write 'Create' if you want to create your own set");
                var input = Console.ReadLine();
                if (input.Length == 0) break;
                if (input == "q") break;
                if (input == "Create") goto Create;
                IFacade facade = new Facade();
                IFacade showObjects = new ProxyFacade(facade);

                //showObjects.ShowSet(input);
                if(showObjects.ShowSet(input) == null) continue;
                
                Console.WriteLine("Would you like to buy the set? Write 'yes' or 'no'.");
                Console.WriteLine("Press q if you want to exit.");
                var response = Console.ReadLine();
                
                switch (response)
                {
                    case "yes":
                    {
                        Console.WriteLine("Would you like to engrave the bracelet? 'yes' 'no' 'q'");
                        var res = Console.ReadLine();
                        switch (res)
                        {
                            case "yes":
                            {
                                Console.Clear();
                                Console.WriteLine("Please write the message, no more than 20 characters long:");

                                var message = Console.ReadLine();
                              
                                Console.Clear();
                              
                                if (showObjects.ShowEngravedSet(input, message) == null) continue;
                               
                                
                                Console.WriteLine(
                                    "If you want to buy the whole set we have a special price of {0} reduced from the initial price of {1}.",
                                    showObjects.ShowEngravedSet(input, message).GetReducedPrice(),
                                    showObjects.ShowEngravedSet(input, message).GetPrice());
                                break;
                            }
                            case "no":
                            {
                                Console.WriteLine(
                                    "If you want to buy the whole set we have a special price of {0} reduced from the initial price of {1}.",
                                    showObjects.ShowSet(input).GetReducedPrice(), showObjects.ShowSet(input).GetPrice());
                                break;
                            }
                            case "q": break;

                        }
                        break;
                    }
                    case "no":
                    {
                        Console.Clear();
                        continue;
                    }
                    case "q":
                    {
                        goto AfterLoop;
                    }

                }
                AfterLoop:
                {
                    Console.WriteLine("Thank you for shopping with us.");
                    break;
                }
            }
             
             Create:
             {
                 Console.WriteLine("Give your new set a name");
                 
                 NewSet newSet = new NewSet(Console.ReadLine());
                 
                 Console.WriteLine("Which Bracelet would you like to add to your set?/n" +
                                   "Press 1 for Fresh Water Bracelet and 2 for Hardwear Bracelet");
                 switch (Console.ReadLine())
                 {
                     case "1" : newSet.Add(new FWBSimpleComponent(null));
                         break;
                     case "2" : newSet.Add(new HWBSimpleComponent(null));
                         break;
                 }
                 Console.WriteLine("Which Necklace would you like to add to your set?/n" +
                                   "Press 1 for Fresh Water Necklace and 2 for Hardwear Necklace");
                 switch (Console.ReadLine())
                 {
                     case "1" : newSet.Add(new FWNSimpleComponent(null));
                         break;
                     case "2" : newSet.Add(new HWNSimpleComponent(null));
                         break;
                 }
                 Console.WriteLine("Which Ring would you like to add to your set?/n" +
                                   "Press 1 for Fresh Water Ring and 2 for Hardwear Ring");
                 switch (Console.ReadLine())
                 {
                     case "1" : newSet.Add(new FWRSimpleComponent(null));
                         break;
                     case "2" : newSet.Add(new HWRSimpleComponent(null));
                         break;
                 }
                 
                 Console.WriteLine("Here is your new set");
                 newSet.Display(1);
                
             }
        }
    }
}