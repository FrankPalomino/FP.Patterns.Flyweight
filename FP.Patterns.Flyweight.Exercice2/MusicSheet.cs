namespace FP.Patterns.Flyweight.Exercice2
{
    public class MusicSheet
    {
        private readonly List<MusicalNote> _musicalNotes;
        private readonly MusicalNoteFactory _musicNoteFactory;

        public MusicSheet()
        {
            _musicalNotes = new List<MusicalNote>();
            _musicNoteFactory = new MusicalNoteFactory();
        }

        public void AddMusicalNote(string pitch, string duration, string style)
        {
            MusicalNote note = _musicNoteFactory.GetMusicalNote(pitch, duration, style);

            _musicalNotes.Add(note);
        }

        public void RemoveMusicalNote(MusicalNote musicalNote)
        {
            _musicalNotes.Remove(musicalNote);
        }

        public void DisplayMusicaNotes()
        {
            foreach (var note in _musicalNotes)
            {
                Console.WriteLine(note.ToString());
            }
        }
    }
}
