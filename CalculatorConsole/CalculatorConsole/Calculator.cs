namespace CalculatorConsole
{
    public class Calculator
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {

            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
              return a / b; 
        }

    }
}
