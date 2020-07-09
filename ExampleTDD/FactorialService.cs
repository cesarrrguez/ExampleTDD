namespace ExampleTDD
{
    public class FactorialService
    {
        public int Calculate(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Calculate(number - 1);
        }
    }
}
