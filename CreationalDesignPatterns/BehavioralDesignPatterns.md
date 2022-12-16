# Behavioral Design Patterns

In this project I implemented 3 structural design patterns

- Visitor - lets you separate algorithms from the objects on which they operate.
- Chain of Responsibility - chains the receiving objects and passes the request along the chain until an object handles it.
- State - allows an object to change the behavior when its internal state changes.
## Visitor

In order to be able to sell the objects to the buyer separately, I need to create them first.
Because the current implementation doesn't allow that, I created a visitor that visits each 
element I want to add in my basket and creates it, and of course attaches it to the list:

Visitor Interface:
```
public interface IVisitor
    {
        void Visit(FreshWaterBracelet bracelet);
        ...
    }
```

Concrete Visitor:
```
public class Construct : IVisitor
    {
        public Basket _basket = new Basket();

        public void Visit(FreshWaterBracelet bracelet)
        {
            Jeweler jeweler = new Jeweler();
            jeweler.CreateObject(new FWBBuilder());
            Bracelet b = (Bracelet) jeweler.GetJewelry();
            _basket.Attach(b);
            Console.WriteLine($"{b.name} was added to the basket");
        }
        
        ...
```

Object Structure:

````
 public class Basket
    {
        public static List<Jewelry> List = new List<Jewelry>();

        public void Attach(Jewelry jewelry)
        {
            List.Add(jewelry);
        }

        public void Delete(Jewelry jewelry)
        {
            List.Remove(jewelry);
        }
        
    }
````

Element:

```
 public interface IElement
    {
        public void Accept(IVisitor visitor);
    }
```

Concrete Element(s):

>FreshWaterBracelet
> 
>FresWaterNecklace
> 
> FreshWaterRing

As a result I get the message example:

>Fresh Water Pearl Bracelet was added to the basket

## Chain Of Responsibility

I used chain of responsibility to perform log in and authorization
in the application. For this I created a login handler and a role verification handler.

The login handler, takes the login user name and password and compares them
against the ones already existing in the in memory database "FauxDatabase". The 
authorization handler takes the credentials and finds the role of the user, 
therefore logging him/her in as a buyer or an administrator.

Initialization:

```
            IHandler handler1 = new LoginHandler();
            IHandler handler2 = new AuthorizationHandler();
            handler1.SetSuccessor(handler2);
            
            handler1.ProcessRequest(us);
```

Login Handler:

```
 public class LoginHandler : IHandler
    {
        public override void ProcessRequest(Login login)
        {
            var us = from u in FauxDatabase.Users
                where (u.UserName == login.UserName && u.Password == login.Password)
                select new
                {
                    UserName = u.UserName,
                    Password = u.Password
                };
           
            if (us.Count() < 0) Console.WriteLine("Such user doesn't exist!");
            else if (successor != null)
            {
                successor.ProcessRequest(login);
            }
        
        }
    }
```

Authorization Handler:

```
public class AuthorizationHandler : IHandler
    {
        public override void ProcessRequest(Login login)
        {
            var us = from u in FauxDatabase.Users
                where u.UserName == login.UserName && u.Password == login.Password
                select new
                {
                    Role = u.Role
                };
            foreach (var element in us)
            {
        
                if (element.Role == "buyer") Console.WriteLine($"{login.UserName} Welcome to the store");
                else if (element.Role == "administrator") {Console.WriteLine($"Hello administrator {login.UserName}");}
                
            }

        }
    }
```

As a result we get results like these:

> chucky Welcome to the store

## Status

I used status for the case when I have a user with the same credentials, but 2 different
roles. In this way, the user can get into their account and perform only the actions they are allowed to.

State:

```
public interface IAccount
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public string CreateElements();
        public string Buy();
        public string ChangeSettings();
    }
```

Specific States:

- Administrator Account:

```
...
 public string CreateElements()
        {
            return "Start creating elements";
        }

        public string Buy()
        {
            return "You are not allowed to create new elements. Go to your buyer account";
        }

        public string ChangeSettings()
        {
            return "Change settings";
        }
   ...
```

- Buyer Account:

````
...
public string CreateElements()
        {
            return "You are not allowed to create new elements. Go to your administrator account";
        }

        public string Buy()
        {
            return "Start buying our beautiful sets";
        }

        public string ChangeSettings()
        {
            return "You are not allowed to create new elements. Go to your administrator account";
        }
        ...
````

Context:

```
...
public Context(string Name, string role)
        {
            this.Name = Name;
            this.Role = role;
            if (role == "administrator") _account = new AdministratorAccount();
            else
            {
                _account = new BuyerAccount();
            }
        }

        public void CreateElements()
        {
            Console.WriteLine(_account.CreateElements());
        }

        public void ChangeSettings()
        {
           Console.WriteLine(_account.ChangeSettings()); 
        }

        public void Buy()
        {
            Console.WriteLine(_account.Buy());
        }
...
```

Initialization:

````
                Console.WriteLine("What account are you tryinng to get into?");
                string st = Console.ReadLine();
                Context context = new Context(login.UserName, st);
                context.Buy();
                context.ChangeSettings();
                context.CreateElements()
````


This is the result:

>Hello administrator chucky1
> 
>chucky1 Welcome to the store
> 
>What account are you tryinng to get into?
>       
>administrator
> 
>You are not allowed to create new elements. Go to your buyer account
> 
>Change settings
> 
>Start creating elements
