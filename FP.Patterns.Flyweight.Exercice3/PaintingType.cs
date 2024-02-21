namespace FP.Patterns.Flyweight.Exercice3
{
    public class PaintingType
    {
        public string Styles { get; set; }
        public string Medium {  get; set; }
        public PaintingType(string styles, string medium)
        {
            Styles = styles;
            Medium = medium;
        }

        public void ShowPainting(string title, string artist, string creationYear)
        {
            Console.WriteLine($"Painting details:\nTitle: {title}\nArtist: {artist}\nCreation Year: {creationYear}\nStyle: {Styles}\nMedium: {Medium}");
        }
    }
}
