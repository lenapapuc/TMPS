using System;

namespace CreationalDesignPatterns.Structural_Design_Patterns
{
    public class ProxyFacade : IFacade
    {
        private IFacade _facade = new Facade();

        public ProxyFacade(IFacade _facade)
        {
            this._facade = _facade;
        }
        public JewelrySet ShowSet(string st)
        {
            if (st == "1" || st == "2")
            {
                _facade.ShowSet(st);
                return _facade.ShowSet(st);
            }

            else
            {
               Console.WriteLine("This set doesn't exist in the store");
               return null;
            }
            
        }

        public JewelrySet ShowEngravedSet(string st, string message)
        {
            if (message.Length <= 20)
            {
                _facade.ShowEngravedSet(st, message);
                return _facade.ShowEngravedSet(st, message);
            }
            else
            {
                Console.WriteLine("The message is too long");
                return null;
            }
            
        }
    }
}