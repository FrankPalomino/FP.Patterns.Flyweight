namespace FP.Patterns.Flyweight.Exercice3
{
    public class ArtGallery
    {
        public List<Painting> Paintings { get; set; } = [];

        public void AddNewArt(string title, string artist, string creationYear, string style, string medium)
        {
            PaintingType paintingType = PaintingFactory.GetPaintingType(style, medium);
            Painting painting = new Painting(title, artist, creationYear, paintingType);
            Paintings.Add(painting);
        }

        public void ShowPainting()
        {
            foreach(Painting painting in Paintings)
            {
                painting.ShowPainting();
            }
        }
    }
}
