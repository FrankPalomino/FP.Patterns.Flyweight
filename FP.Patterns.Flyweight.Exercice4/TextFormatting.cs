namespace FP.Patterns.Flyweight.Exercice4
{
    public class TextFormatting : IEquatable<TextFormatting>
    {
        private readonly string _font;
        private readonly string _color;
        private readonly string _style;

        public TextFormatting(string font, string color, string style)
        {
            _font = font;
            _color = color;
            _style = style;
        }

        public bool Equals(TextFormatting? other)
        {
            return _color.Equals(other._color) && _style.Equals(other._style) && _font.Equals(other._font);
        }

        public string ToString()
        {
            return $"Font: {_font}\nColor: {_color}\nStyle: {_style}";
        }
    }
}
