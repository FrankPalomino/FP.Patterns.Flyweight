using FP.Patterns.Flyweight;

int i = 0;

List<int> American = new List<int>();
List<int> Italian = new List<int>();
List<int> Mexican = new List<int>();

List<int> Meats = new List<int>();
List<int> Soups = new List<int>();
List<int> Salads = new List<int>();

List<int> Fast = new List<int>();

FlyweightFactory factory = new FlyweightFactory();

i = factory.Add("Hamburger");
American.Add(i);
Meats.Add(i);
Fast.Add(i);

i = factory.Add("Hot Dog");
American.Add(i);
Meats.Add(i);
Fast.Add(i);

i = factory.Add("Pizza");
Italian.Add(i);
Fast.Add(i);

i = factory.Add("Pasta");
Italian.Add(i);

i = factory.Add("Taco");
Mexican.Add(i);
Fast.Add(i);

i = factory.Add("Burrito");
Mexican.Add(i);
Fast.Add(i);

i = factory.Add("Tortilla Soup");
Mexican.Add(i);
Soups.Add(i);


foreach (int index in American)
{
    Recipe recipe = (Recipe)factory[index];
    recipe.CalculatePrice();
    recipe.Show();
}

Console.WriteLine("--------");

foreach (int index in Italian)
{
    Recipe recipe = (Recipe)factory[index];
    recipe.CalculatePrice();
    recipe.Show();
}

Console.WriteLine("--------");

foreach (int index in Fast)
{
    Recipe recipe = (Recipe)factory[index];
    //recipe.CalculatePrice();
    recipe.Show();
}