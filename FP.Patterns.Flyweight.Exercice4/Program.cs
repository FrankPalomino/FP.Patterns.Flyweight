using FP.Patterns.Flyweight.Exercice4;

TextCharacter b = TextFormattingFactory.GetTextCharacter('b', "Bolt", "Red", "Arial");
TextCharacter c = TextFormattingFactory.GetTextCharacter('c', "Bolt", "Red", "Arial");
TextCharacter b1 = TextFormattingFactory.GetTextCharacter('b', "Bolt", "Blue", "Arial");

Console.WriteLine(b.ToString());
Console.WriteLine("\n-----------------\n----------");
Console.WriteLine(c.ToString());
Console.WriteLine("\n-----------------\n----------");
Console.WriteLine(b1.ToString());
Console.WriteLine("\n-----------------\n----------");

foreach (var formatting in TextFormattingFactory._textFormattingList)
{
    Console.WriteLine(formatting.ToString());
    Console.WriteLine("\n-----------------\n----------");
}