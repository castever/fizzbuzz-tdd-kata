namespace FizzBuzzKata
{
    internal class FizzBuzz
    {
        private readonly int _number;

        public FizzBuzz(int number)
        {
            this._number = number;
        }

        public string Value()
        {
            if (IsDivisibleByThree() && IsDivisibleByFive())
            {
                return "FizzBuzz";
            }
            if (IsDivisibleByThree())
            {
                return "Fizz";
            }
            if (IsDivisibleByFive())
            {
                return "Buzz";
            }
            return _number.ToString();
        }

        private bool IsDivisibleByThree()
        {
            return _number % 3 == 0;
        }

        private bool IsDivisibleByFive()
        {
            return _number % 5 == 0;
        }
    }
}