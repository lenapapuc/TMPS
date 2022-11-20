using System;
using System.Collections;
using System.Collections.Generic;

namespace CreationalDesignPatterns.Structural_Design_Patterns.Composite
{
    public class NewSet : Component, IEnumerable
    {
        private List<Component> partsOfSet = new List<Component>();
        
        public NewSet(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            partsOfSet.Add(c);
        }

        public  override void Remove(Component c)
        {
            partsOfSet.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) +
                              " "+ name);
            // Display each child element on this node
            foreach (Component d in partsOfSet)
            {
                d.Display(depth + 2);
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}