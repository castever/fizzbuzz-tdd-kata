namespace FizzBuzzKata
{
    internal class FizzBuzz
    {
        private int _number;

        public FizzBuzz(int number)
        {
            this._number = number;
        }

        public string Value()
        {
            return _number.ToString();
        }
    }
}