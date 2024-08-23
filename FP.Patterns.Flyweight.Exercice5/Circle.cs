namespace FP.Patterns.Flyweight.Exercice5
{
    public class Circle : IShape
    {
        private readonly string _color;
        private readonly int _size;

        public Circle(string color, int size)
        {
            _color = color;
            _size = size;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Circle with size {_size} is pinting with color {_color} on position {x}:{y}");
        }
    }
}
