namespace CreationalDesignPatterns.Structural_Design_Patterns.Composite
{
    public abstract class Component
    {
        protected string name;
        // Constructor
        public Component(string name)
        {
            this.name = name;
        }
        // Constructor
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}