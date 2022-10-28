namespace Fibonacci
{
    public class Fibonacci
    {
        public int GetSmallFibonacciNumber(long fibNumber)
        {
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;

            for (int i = 0; i < fibNumber - 1; i++)
            {
                fib3 = fib2;
                fib2 = fib1 + fib2;
                fib1 = fib3;
            }

            return fib2;
        }
        public int LastDigitOfTheBigFibonacciNumber(long fibNumber)
        {
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;

            for (int i = 0; i < fibNumber - 1; i++)
            {
                fib3 = fib2;
                fib2 = fib1 + fib2 % 10;
                fib1 = fib3;
            }

            return fib2 % 10;
        }
        public int HugeFibonacciNumberModulo(long fibNumber, int fibModulo)
        {

            int[] arrFib = new int[fibModulo * 6];
            int length = 0;

            arrFib[0] = 0;
            arrFib[1] = 1;
            
            for (int i = 2; i < 6 * fibModulo; i++)
            {
                arrFib[i] = (arrFib[i - 1] + arrFib[i - 2]) % fibModulo;
                
                if (arrFib[i] == 1 && arrFib[i - 1] == 0)
                {
                    length = i - 1;
                    return arrFib[fibNumber % length];
                }
            }

            return -1;
        }
    }
}        
