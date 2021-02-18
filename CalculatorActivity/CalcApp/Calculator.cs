namespace CalcApp
{
    public class Calculator
    {
        //Methods
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
        public int Fib(int x)
        {
            if(x <= 1)
            {
                return -1;
            }
            else
            {
                return Fib(x - 1) + Fib(x + 2);
            }
        }
    }

}
