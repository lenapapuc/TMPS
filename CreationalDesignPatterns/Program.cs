using System;
using System.Linq;
using System.Linq.Expressions;
using CreationalDesignPatterns.Builders;

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
                var input = Console.ReadLine();
                if(input.Length == 0) break;
                switch (input)
                {
                    case "1":
                    {
                        JewelryFactory freshwater = FreshWaterPearlFactory.Instance();
                        JewelrySet set = new JewelrySet(freshwater);
                        set.Run();
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
                                        if (message.Length > 20)
                                        {
                                            Console.WriteLine("Your message is too long");
                                            break;
                                        }
                                        
                                        Console.Clear();
                                        Console.WriteLine("Check out the difference between the 2");
                                        Console.WriteLine();
                                        set.Run();
                                        Console.WriteLine();
                                        JewelryFactory fresh = freshwater.Clone();
                                        JewelrySet set1 = new JewelrySet(fresh);
                                        set1._bracelet.engraving = message;
                                        set1._bracelet.price = 2000;
                                        Console.WriteLine("Your personalized set:");
                                        set1.Run();
                                        Console.WriteLine(
                                            "If you want to buy the whole set we have a special price of {0} reduced from the initial price of {1}.",
                                            set1.GetReducedPrice(), set1.GetPrice());
                                        goto AfterLoop;
                                    }
                                    case "no":
                                    {
                                        Console.WriteLine(
                                            "If you want to buy the whole set we have a special price of {0} reduced from the initial price of {1}.",
                                            set.GetReducedPrice(), set.GetPrice());
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
                            case "q": goto AfterLoop;

                        }
                        break;
                    }

                    case "2":
                    {
                        JewelryFactory hardwear =  HardwearBallFactory.Instance();
                        JewelrySet hset = new JewelrySet(hardwear);
            
                        hset.Run();
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
                                        Console.WriteLine("Please write the message, no more than 20 characters long:");

                                        var message = Console.ReadLine();
                                        if (message.Length > 20)
                                        {
                                            Console.WriteLine("Your message is too long");
                                            break;
                                        }

                                        JewelryFactory hard = hardwear.Clone();
                                        JewelrySet set1 = new JewelrySet(hard);
                                        set1._bracelet.engraving = message;
                                        Console.WriteLine("Your personalized set:");
                                        set1.Run();
                                        Console.WriteLine(
                                            "If you want to buy the whole set we have a special price of {0} reduced from the initial price of {1}.",
                                            set1.GetReducedPrice(), set1.GetPrice());
                                        goto AfterLoop;
                                    }
                                    case "no":
                                    {
                                        Console.WriteLine(
                                            "If you want to buy the whole set we have a special price of {0} reduced from the initial price of {1}.",
                                            hset.GetReducedPrice(), hset.GetPrice());
                                        break;
                                    }

                                    case "q": break;
                                }

                                break;
                            }
                            case "no": continue;
                            case "q": goto AfterLoop;

                        }
                        
                        break;
                    }
                    
                    case "q": goto AfterLoop;

                    default:
                    {
                        Console.WriteLine("There is no such item in our catalogue. Please select Another one");
                        continue;
                    }
                            
                }
                
                AfterLoop:
                {
                    Console.WriteLine("Thank you for shopping with us.");
                    break;
                }
                
                
            }
           
             
            
         
            
            



        }
    }
}