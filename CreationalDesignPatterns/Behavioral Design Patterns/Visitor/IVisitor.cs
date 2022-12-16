using CreationalDesignPatterns.Builders;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns
{
    public interface IVisitor
    {
        void Visit(FreshWaterBracelet bracelet);
        void Visit(FreshwaterNecklace necklace);
        void Visit(FreshWaterRing ring);

    }
}