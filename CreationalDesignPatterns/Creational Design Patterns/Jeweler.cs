using System;
using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns
{
    //director class in builder
    public class Jeweler
    {
        private IJewelryBuilder _builder;

        public void CreateObject(IJewelryBuilder builder)
        {
            _builder = builder;
            _builder.Create();
            _builder.SetName();
            _builder.SetPrice();
            _builder.SetType();
            _builder.AddEngraving();
        }

        public Jewelry GetJewelry()
        {
            return _builder.GetJewelry();
        }
        
    }
}