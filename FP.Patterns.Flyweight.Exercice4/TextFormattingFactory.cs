namespace FP.Patterns.Flyweight.Exercice4
{
    public static class TextFormattingFactory
    {
        public static readonly List<TextFormatting> _textFormattingList = [];

        public static TextCharacter GetTextCharacter(char x, string font, string color, string style)
        {
            TextFormatting textFormatting = _textFormattingList.FirstOrDefault(x => x.Equals(new TextFormatting(font, color, style)));

            if (textFormatting is null)
            {
                textFormatting = new TextFormatting(font, color, style);
                _textFormattingList.Add(textFormatting);
            }

            return new TextCharacter(x, textFormatting);
        }
    }
}
