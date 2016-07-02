namespace FizzBuzzKata
{
    internal class FizzBuzz
    {
        private readonly int _number;

        public FizzBuzz(int number)
        {
            _number = number;
        }

        public string Value()
        {
            string value = "";
            if (IsDivisibleByThree())
            {
                value = "Fizz";
            }
            if (IsDivisibleByFive())
            {
                value +=  "Buzz";
            }
            if (value.Equals(""))
            {
                value =  _number.ToString();
            }
            return value;
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