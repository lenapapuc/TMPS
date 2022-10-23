using System;

namespace CreationalDesignPatterns.Builders
{
    public interface IJewelryBuilder
    {
        public  void Create();
        public  void SetName();
        public  void SetType();
        public  void SetPrice();
        public void AddEngraving();
        public Jewelry GetJewelry();


    }
}