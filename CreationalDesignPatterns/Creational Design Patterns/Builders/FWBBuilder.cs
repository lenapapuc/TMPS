using System;
using CreationalDesignPatterns.Structural_Design_Patterns.Composite;

namespace CreationalDesignPatterns.Builders
{
    public class FWBBuilder : IJewelryBuilder
    {
        private FreshWaterBracelet _freshWaterBracelet;

        public FWBBuilder() {this.Create();}
        public void Create()
        {
            _freshWaterBracelet = new FreshWaterBracelet();
        }

        public void SetName()
        {
            _freshWaterBracelet.name = "Fresh Water Pearl Bracelet";
        }

        public void SetType()
        {
            _freshWaterBracelet.type = "Bracelet";
        }

        public void SetPrice()
        {
            _freshWaterBracelet.price = 1950;
        }

        public Jewelry GetJewelry()
        {
            return _freshWaterBracelet;
        }

        public void AddEngraving()
        {
           _freshWaterBracelet.engraving = "No engraving";
        }

      
    }
}