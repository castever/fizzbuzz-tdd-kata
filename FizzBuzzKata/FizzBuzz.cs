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
            return _number % 3 == 0 ? "Fizz" :
                _number % 5 == 0 ? "Buzz" : _number.ToString();
        }
    }
}