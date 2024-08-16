namespace Polymorphism
{
    public class TestStaticPolymorphism
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
