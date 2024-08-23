using FP.Patterns.Flyweight.Exercice5;

ShapeFactory shapeFactory = new ShapeFactory();

// Create many shapes with shared intrinsic properties
for (int i = 0; i < 100; i++)
{
    IShape circle = shapeFactory.GetShape("Circle", "Red", 10);
    circle.Draw(i, i);

    IShape square = shapeFactory.GetShape("Square", "Blue", 20);
    square.Draw(i + 10, i + 10);

    IShape triangle = shapeFactory.GetShape("Triangle", "Green", 15);
    triangle.Draw(i + 20, i + 20);
}

// Display total number of shape objects created
Console.WriteLine($"\nTotal unique shapes created: {shapeFactory.GetTotalShapes()}");