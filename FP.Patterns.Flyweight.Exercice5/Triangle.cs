namespace FP.Patterns.Flyweight.Exercice5
{
    public class Triangle : IShape
    {
        private readonly string _color;
        private readonly int _size;

        public Triangle(string color, int size)
        {
            _color = color;
            _size = size;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Triangle with size {_size} is pinting with color {_color} on position {x}:{y}");
        }
    }
}
