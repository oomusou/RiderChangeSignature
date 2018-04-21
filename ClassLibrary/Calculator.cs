namespace ClassLibrary
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Calculate(int x, int y, int z)
        {
            return Multiply(Add(x, y), z);
        }
    }
}