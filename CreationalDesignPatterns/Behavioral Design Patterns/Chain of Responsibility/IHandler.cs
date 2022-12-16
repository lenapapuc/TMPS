namespace CreationalDesignPatterns.Behavioral_Design_Patterns.Chain_of_Responsibility
{
    public abstract class IHandler
    {
        protected IHandler successor;

        public void SetSuccessor(IHandler successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Login login);
    }
}