using System.Collections.Generic;

namespace CreationalDesignPatterns.Behavioral_Design_Patterns.Chain_of_Responsibility
{
    public static class FauxDatabase
    {
        public static IEnumerable<User> Users = new List<User>
        {
            new User(
                userName:"chucky",
                password:"testpass",
                role: "buyer",
                email:"chuchy@gmail.com"
                ),
            

            new User(
                userName: "chucky1",
                password: "passtest",
                role:"administrator",
                email:"chuchy1@gmail.com"
                ),
            
            new User(
                userName: "chucky1",
                password: "passtest",
                role:"buyer",
                email:"chuchy1@gmail.com"
            )
        };
    }
}