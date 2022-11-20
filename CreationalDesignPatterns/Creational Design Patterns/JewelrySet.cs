using System;
using System.Collections;
using System.Drawing;

namespace CreationalDesignPatterns
{
    //client class in abstract factory
    public class JewelrySet
    {
        public Bracelet _bracelet;
        public Necklace _necklace;
        public Ring _ring;

        public JewelrySet(JewelryFactory factory)
        {
            
            _bracelet = factory.GetBracelet();
            _necklace = factory.GetNecklace();
            _ring = factory.GetRing();
        }

        public void Run()
        {
            Console.WriteLine("Here is the set:");
            _bracelet.WriteResponse();
            _necklace.WriteResponse();
            _ring.WriteResponse();
        }

        public float GetReducedPrice()
        {
            float price = _bracelet.price + _necklace.price + _ring.price;
            price = (float) (0.7 * price);
            return price;
        }
        public float GetPrice()
        {
            float price = _bracelet.price + _necklace.price + _ring.price;
            price = (float) (price);
            return price;
        }

    }
}