namespace FP.Patterns.Flyweight.Exercice3
{
    public static class PaintingFactory
    {
        private static readonly List<PaintingType> _paintingTypes = [];

        public static PaintingType GetPaintingType(string style, string medium)
        {
            PaintingType paintingType = _paintingTypes.FirstOrDefault(x => x.Styles.Equals(style) && x.Medium.Equals(medium));
            if (paintingType is null)
            {
                paintingType = new PaintingType(style, medium);
                _paintingTypes.Add(paintingType);
            }

            return paintingType;
        }
    }
}
