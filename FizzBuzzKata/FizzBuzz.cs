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
            return IsDivisibleByThree() ? "Fizz" :
               IsDivisibleByFive() ? "Buzz" : 
               _number.ToString();
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