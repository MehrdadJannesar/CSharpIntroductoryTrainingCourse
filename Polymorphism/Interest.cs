namespace Polymorphism
{
    public class Interest
    {
        public virtual double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }
    }
}
