# Structural Design Patterns

In this project I implemented 3 structural design patterns

- Facade - provides a unified interface to a set of interfaces in a subsystem. This pattern defines a higher-level interface that makes the subsystem easier to use.
- Proxy - provides a surrogate or placeholder for another object to control access to it.
- Composite - composes objects into tree structures to represent part-whole hierarchies. This pattern lets clients treat individual objects and compositions of objects uniformly.

## Facade

The Facade Class is used in order to hold within itself the 2 factories
present in the system and show their components to the user.
```
 public class Facade
    {
        private JewelryFactory freshwaterPearlFactory= FreshWaterPearlFactory.Instance();
        private JewelryFactory hardwearballFactory= HardwearBallFactory.Instance();

        public JewelrySet ShowSet(String whichSet)
        {
            JewelrySet jewelrySet = null;
            switch (whichSet)
            {
               case "1":
               {  
                   jewelrySet = new JewelrySet(freshwaterPearlFactory);
                   jewelrySet.Run();
                   break;
               }

               case "2":
               {
                   jewelrySet = new JewelrySet(hardwearballFactory);
                   jewelrySet.Run();
                   break;
               }
            }

            return jewelrySet;
        }

        public JewelrySet ShowEngravedSet(String whichSet, String message)
        {
            JewelrySet engravedSet = null;
            engravedSet = ShowSet(whichSet);
            engravedSet._bracelet.engraving = message;
            engravedSet._bracelet.price = engravedSet._bracelet.engravedPrice;
            Console.WriteLine("Your personalized set:");
            engravedSet.Run();
            return engravedSet;
        }
    }
```
## Proxy

To implement the Proxy Design Pattern, I used the facade previously 
implemented, I created an interface for the facade:

```
 public interface IFacade
    {
        //proxy for facade
        public JewelrySet ShowSet(String st);
        public JewelrySet ShowEngravedSet(String st, String message);
    }
```

I also created a proxy facade that is able to check if the conditions
are correct before loading the necessary components. For example, if the engraving
is longer than 20 characters, computer power won't be lost to create the object:

```
...
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
  ...
```
## Composite

I used Composite to allow the user to create their own set of jewelry as opposed to the predefined
ones. So, as the binding element, we have the abstract class "Component":

```
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
```


As the root(Compound Object), I have the class "NewSet" which inherits
from the abstract class "Component" and as a leaf (Simple Object), I have the types of Jewelry
that I used in Abstract Class, for example Fresh Water Bracelet.

```
public class FWBSimpleComponent : Component
    {
        Jeweler jewelryCreator = new Jeweler();
        public FWBSimpleComponent(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine( "Cannot Add");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot Remove");
        }

        public override void Display(int depth)
        {
            jewelryCreator.CreateObject(new FWBBuilder());
            var jewel = jewelryCreator.GetJewelry();
            Console.WriteLine(new String('-', depth) + " " + jewel.name);
            Console.WriteLine(FreshWaterBracelet.GetDescription());
        }
    }
```

Therefore, when I want to create a new set, I can just call the constructor of 
New Set .

```"
 NewSet newSet = new NewSet(Console.ReadLine());
```

Then, I can repeatedly, Add to it.

```
newSet.Add(new FWBSimpleComponent(null));
...
newSet.Add(new HWNSimpleComponent(null));
...
newSet.Add(new FWRSimpleComponent(null));
```

The result is the following:

>Here is your new set:
>
> -- My name
> 
>  --- Fresh Water Pearl Bracelet
>
>  Sleek sterling silver links are offset with lustrous pearls in this lock bracelet design.
> 
>  --- Ball Pendant 
>
>  Featuring a sleek sterling silver ball, this simple pendant is effortlessly modern and timeless.
>
> --- Fresh Water Pearl Ring
> 
> Two bold bands of sterling silver exude modern sophistication in this double ring design.
