namespace CreationalDesignPatterns.Builders
{
    public class FWRBuilder : IJewelryBuilder
    {
        private FreshWaterRing _freshWaterRing;

        public FWRBuilder() {this.Create();}
        public void Create()
        {
            _freshWaterRing = new FreshWaterRing();
        }

        public void SetName()
        {
            _freshWaterRing.name = "Fresh Water Pearl Ring";
        }

        public void SetType()
        {
            _freshWaterRing.type = "Ring";
        }

        public void SetPrice()
        {
            _freshWaterRing.price = 750;
        }

        public Jewelry GetJewelry()
        {
            return _freshWaterRing;
        }
        
        public void AddEngraving()
        {
            _freshWaterRing.engraving = null;
        }
    }
}