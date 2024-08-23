namespace FP.Patterns.Flyweight.Exercice5
{
    public class ShapeFactory
    {
        private readonly Dictionary<string, IShape> _shapes = [];

        public IShape GetShape(string type, string color, int size)
        {
            string key = $"{type}_{color}_{size}";
            if (!_shapes.ContainsKey(key))
            {
                IShape shape = type switch
                {
                    "Circle" => new Circle(color, size),
                    "Square" => new Square(color, size),
                    "Triangle" => new Triangle(color, size),
                    _ => throw new NotImplementedException()
                };

                _shapes.Add(key, shape);
            }

            return _shapes[key];
        }

        public int GetTotalShapes()
        {
            return _shapes.Count;
        }
    }
}
