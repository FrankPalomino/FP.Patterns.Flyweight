using FP.Patterns.Flyweight.Exercice3;

ArtGallery artGallery = new ArtGallery();

artGallery.AddNewArt("La noche estrellada", "Van gogh", "1889", "Postimpresionismo", "Lienzo");
artGallery.AddNewArt("La Vision après", "Paul Gauguin", "1889", "Postimpresionismo", "Papel");
artGallery.AddNewArt("Paisaje cerca de Figueras", "Salvador Dalí", "1910", "Surrealismo", "Lienzo");
artGallery.AddNewArt("La virgen bendecida", "Max Ernst", "1976", "Surrealismo", "Papel");

artGallery.ShowPainting();
