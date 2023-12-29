namespace FP.Patterns.Flyweight.Exercice2
{
    public class MusicalNote
    {
        public string Pitch { get; set; }
        public string Duration { get; set; }
        public string Style { get; set; }
        public MusicalNote(string pitch, string duration, string style)
        {

            Pitch = pitch.ToUpper();
            Duration = duration.ToUpper();
            Style = style.ToUpper();
        }

        public override string ToString()
        {
            return $"[{Pitch},{Duration},{Style}]";
        }
    }
}
