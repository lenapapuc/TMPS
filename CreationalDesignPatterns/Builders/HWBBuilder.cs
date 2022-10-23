namespace CreationalDesignPatterns.Builders
{
    public class HWBBuilder : IJewelryBuilder
    {
       
            private HardwearBracelet _hardwearBracelet;

            public HWBBuilder() {this.Create();}
            public void Create()
            {
                _hardwearBracelet = new HardwearBracelet();
            }

            public void SetName()
            {
                _hardwearBracelet.name = "Ball Bracelet";
            }

            public void SetType()
            {
                _hardwearBracelet.type = "Bracelet";
            }

            public void SetPrice()
            {
                _hardwearBracelet.price = 525;
            }

            public Jewelry GetJewelry()
            {
                return _hardwearBracelet;
            }
            
            public void AddEngraving()
            {
                _hardwearBracelet.engraving = "No Engraving";
            }

    }
}