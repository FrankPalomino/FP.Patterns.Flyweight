namespace FP.Patterns.Flyweight.Exercice2
{
    public class MusicalNoteFactory
    {
        private readonly IDictionary<string, MusicalNote> _notes = new Dictionary<string, MusicalNote>();
        public MusicalNote GetMusicalNote(string pitch, string duration, string style)
        {
            var key = $"{pitch}-{duration}";

            if(!_notes.TryGetValue(key, out var musicalNote))
            {
                musicalNote = new MusicalNote(pitch, duration, style);
                _notes.Add(key, musicalNote);
            }

            return musicalNote;
        }
    }
}
