namespace FP.Patterns.Flyweight.Exercice1
{
    public class Character
    {
        public char Symbol { get; set; }
        public int Font { get; set; }
        public int Size { get; set; }
        public int Color { get; set; }

        public Character(char symbol, int font, int size, int color)
        {
            Symbol = symbol;
            Font = font;
            Size = size;
            Color = color;
        }

        public void Show()
        {
            Console.WriteLine("Symbol: {0}, Font: {1}, Size: {2}, Color: {3}", Symbol, Font, Size, Color);
        }
    }
}
