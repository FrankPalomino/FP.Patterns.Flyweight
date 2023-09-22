namespace FP.Patterns.Flyweight
{
    internal class Recipe : IFlyweight
    {
        private string? _name;
        private double _price;
        private double _value;
        public void AddName(string name)
        {
            _name = name;
        }

        public void CalculatePrice()
        {
            foreach(char letter in _name)
            {
                _price += (int)letter;
            }

            _value = _price * 1.30;
        }

        public string GetName()
        {
            return _name;
        }

        public void Show()
        {
            Console.WriteLine("{0} esta {1}", _name, _value);
        }
    }
}
