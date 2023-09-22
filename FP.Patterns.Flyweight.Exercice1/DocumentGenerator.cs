namespace FP.Patterns.Flyweight.Exercice1
{
    public class DocumentGenerator
    {
        private List<Character> _characters = new List<Character>();
        private CharacterFactory _factory = new CharacterFactory();

        public void InsertCharacter(char letter, int font, int size, int color)
        {
            Character character = _factory.GetCharacter(letter, font, size, color);
            _characters.Add(character);
        }

        public void Show()
        {
            foreach(Character character in _characters)
            {
                character.Show();
            }
        }
    }
}
