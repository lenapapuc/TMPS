namespace CreationalDesignPatterns.Builders
{
    public class FWNBuilder : IJewelryBuilder
    {
        private FreshwaterNecklace _freshWaterNecklace;

        public FWNBuilder() {this.Create();}
        public void Create()
        {
            _freshWaterNecklace = new FreshwaterNecklace();
        }

        public void SetName()
        {
            _freshWaterNecklace.name = "Fresh Water Pearl Necklace";
        }

        public void SetType()
        {
            _freshWaterNecklace.type = "Necklace";
        }

        public void SetPrice()
        {
            _freshWaterNecklace.price = 1600;
        }

        public Jewelry GetJewelry()
        {
            return _freshWaterNecklace;
        }

        public void AddEngraving()
        {
            _freshWaterNecklace.engraving = null;
        }
    }
}