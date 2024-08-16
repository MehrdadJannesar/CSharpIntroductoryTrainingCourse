namespace Polymorphism
{
    public class  SimpleInterest : Interest
    {
        public override double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate) + 1000;
        }
    }
}
