namespace FP.Patterns.Flyweight.Exercice3
{
    public class Painting
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string CreationYear { get; set; }
        public PaintingType PaintingType { get; set; }

        public Painting(string title, string artist, string creationYear, PaintingType paintingType)
        {
            Title = title;
            Artist = artist;
            CreationYear = creationYear;
            PaintingType = paintingType;
        }

        public void ShowPainting()
        {
            PaintingType.ShowPainting(Title, Artist, CreationYear);
        }
    }
}
