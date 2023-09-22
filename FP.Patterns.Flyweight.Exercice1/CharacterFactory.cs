namespace FP.Patterns.Flyweight.Exercice1
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

        public Character GetCharacter(char letter, int font, int size, int color)
        {
            if(!_characters.ContainsKey(letter))
            {
                _characters.Add(letter, new Character(letter, font, size, color));
            }

            return _characters[letter];
        }
    }
}
