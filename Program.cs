namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type numbers");
            
            long fibNumber = Convert.ToInt64(Console.ReadLine());
            
            int fibModulo = Convert.ToInt32(Console.ReadLine());
            
            Fibonacci.Fibonacci getFibonacciNumber = new Fibonacci.Fibonacci();
            
            Console.WriteLine();
            Console.WriteLine("Small Fibonacci Number");
            Console.WriteLine(getFibonacciNumber.GetSmallFibonacciNumber(fibNumber));
            
            Console.WriteLine();
            Console.WriteLine("Last Digit Of The Big Fibonacci Number");
            Console.WriteLine(getFibonacciNumber.LastDigitOfTheBigFibonacciNumber(fibNumber));
            
            Console.WriteLine();
            Console.WriteLine("Huge Fibonacci Number Modul");
            Console.WriteLine(getFibonacciNumber.HugeFibonacciNumberModulo(fibNumber, fibModulo));
        }
    }
}