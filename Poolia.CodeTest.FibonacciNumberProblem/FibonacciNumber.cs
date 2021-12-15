namespace Poolia.CodeTest.FibonacciNumberProblem
{
    public class FibonacciNumber
    {
        public int GetFibonacciByPosition(int position)
        {
            if (position < 1)
            {
                return 1; // As Agreed in the interview
            }

            var firstNumber = 0;
            var secondNumber = 1;
            var fibonacciNumber = 0;

            for (int i = 1; i < position; i++)
            {
                fibonacciNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fibonacciNumber;
            }

            return fibonacciNumber;
        }
    }
}
