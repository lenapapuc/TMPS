using System;

namespace CreationalDesignPatterns.Structural_Design_Patterns
{
    public class Facade : IFacade
    {
        private JewelryFactory freshwaterPearlFactory= FreshWaterPearlFactory.Instance();
        private JewelryFactory hardwearballFactory= HardwearBallFactory.Instance();

        public JewelrySet ShowSet(String whichSet)
        {
            JewelrySet jewelrySet = null;
            switch (whichSet)
            {
               case "1":
               {  
                   jewelrySet = new JewelrySet(freshwaterPearlFactory);
                   jewelrySet.Run();
                   break;
               }

               case "2":
               {
                   jewelrySet = new JewelrySet(hardwearballFactory);
                   jewelrySet.Run();
                   break;
               }

            }

            return jewelrySet;
        }

        public JewelrySet ShowEngravedSet(String whichSet, String message)
        {
            JewelrySet engravedSet = null;
            engravedSet = ShowSet(whichSet);
            engravedSet._bracelet.engraving = message;
            engravedSet._bracelet.price = engravedSet._bracelet.engravedPrice;
            Console.WriteLine("Your personalized set:");
            engravedSet.Run();
            return engravedSet;
        }
    }
}