using System;

namespace CreationalDesignPatterns.Structural_Design_Patterns
{
    public interface IFacade
    {
        //proxy for facade
        public JewelrySet ShowSet(String st);
        public JewelrySet ShowEngravedSet(String st, String message);
    }
}