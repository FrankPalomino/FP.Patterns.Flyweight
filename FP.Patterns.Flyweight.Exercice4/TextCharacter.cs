namespace FP.Patterns.Flyweight.Exercice4
{
    public class TextCharacter
    {
        private readonly char _char;
        private readonly TextFormatting _formatting;

        public TextCharacter(char @char, TextFormatting formatting)
        {
            _char = @char;
            _formatting = formatting;
        }

        public string ToString()
        {
            return $"Char: {_char}\nFormating: {_formatting.ToString()}";
        }
    }
}
