using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns
{
    public interface IElement
    {
        public void Accept(IVisitor visitor);
    }
}