# Design Patterns

In this project I implemented 5 creational design patterns

- Abstract Factory - Creates families of related dependent objects
- Factory - Creates objects of several related classes without specifying the exact object to be created
- Builder -  Constructs complex objects using step-by-step approach
- Singleton - A class should have only one instance at a time
- Prototype - Makes copies of existing objects without making the code dependent on their classes.

## Abstract Factory

The abstract factory interface is represented by the abstract class 
"Jewelry Factory"

```
public abstract class JewelryFactory
    {
        public abstract Bracelet GetBracelet();
        public abstract Necklace GetNecklace();
        public abstract Ring GetRing();
        
        ...
    }
```
 

The concrete factories are the Fresh Water Pearl Factory and Hardwear 
Ball Factory, each one of them outputting a different set of jewelry
made out of the abstract products "Bracelet", "Ring" and "Necklace"
For the sake of the project, for each abstract product I have implemented
2 concrete products that correspond to the 2 individual concrete factories.

## Factory

The factory method was exemplified through the Fresh Water Pearl Factory
and Hardwear Ball Factory that both create instances of several related classes: Bracelet,
Ring and Necklace.

```
public class FreshWaterPearlFactory : JewelryFactory
    {
      ...
        
        Jeweler jewelryCreator = new Jeweler();
        public override Bracelet GetBracelet()
        {
            jewelryCreator.CreateObject(new FWBBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Bracelet) jewel;
        }

        public override Necklace GetNecklace()
        {
            jewelryCreator.CreateObject(new FWNBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Necklace) jewel;
        }

        public override Ring GetRing()
        {
            jewelryCreator.CreateObject(new FWRBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Ring) jewel;
        }
        
        ...

    }
}
```

## Builder

The Factory Method is used together with Builder. Since Builder helps 
create different objects with the same process, it is perfect for creating
the objects of type Jewelry that all have similar properties: name, description,
price, type, engraving.

The builder interface:

```
 public interface IJewelryBuilder
    {
        public  void Create();
        public  void SetName();
        public  void SetType();
        public  void SetPrice();
        public void AddEngraving();
        public Jewelry GetJewelry();
    }
```
The director class is Jeweler, that represents the exact construction
method for the objects.

```
 private IJewelryBuilder _builder;

        public void CreateObject(IJewelryBuilder builder)
        {
            _builder = builder;
            _builder.Create();
            _builder.SetName();
            _builder.SetPrice();
            _builder.SetType();
            _builder.AddEngraving();
        }

        public Jewelry GetJewelry()
        {
            return _builder.GetJewelry();
        }
```

The Concrete Builders are represented by 6 classes in my case that 
use the methods from the builder interface.

```
 public class FWBBuilder : IJewelryBuilder
    {
        private FreshWaterBracelet _freshWaterBracelet;

        public FWBBuilder() {this.Create();}
        public void Create()
        {
            _freshWaterBracelet = new FreshWaterBracelet();
        }

        public void SetName()
        {
            _freshWaterBracelet.name = "Fresh Water Pearl Bracelet";
        }

        public void SetType()
        {
            _freshWaterBracelet.type = "Bracelet";
        }

        public void SetPrice()
        {
            _freshWaterBracelet.price = 1950;
        }

        public Jewelry GetJewelry()
        {
            return _freshWaterBracelet;
        }

        public void AddEngraving()
        {
           _freshWaterBracelet.engraving = "No engraving";
        }

      
    }
```

The products are created inside each factory method:
```
Jeweler jewelryCreator = new Jeweler();

public override Bracelet GetBracelet()
        {
            jewelryCreator.CreateObject(new FWBBuilder());
            var jewel = jewelryCreator.GetJewelry();
            return (Bracelet) jewel;
        }
```

## Singleton

Singleton is used inside each factory method inside the abstract factory,
because only one instance of each is necessary through the run of the program.

```
 public class FreshWaterPearlFactory : JewelryFactory
    {
        private static FreshWaterPearlFactory _freshWaterPearlFactory;
        protected FreshWaterPearlFactory()
        {
        }

        public static FreshWaterPearlFactory Instance()
        {
            if (_freshWaterPearlFactory == null) _freshWaterPearlFactory = new FreshWaterPearlFactory();
            return _freshWaterPearlFactory;
        }
        
```

## Prototype

Because I mean to clone both the Fresh Water Pearl Factory
and the Hardwear Ball Factory I implemented in both of them as well
as in their parent class the Clone() method that provides shallow cloning
for these classes:

```
  public override JewelryFactory Clone()
        {
            return (JewelryFactory) this.MemberwiseClone();
        }
```
