using FP.Patterns.Flyweight.Exercice1;

DocumentGenerator generator = new DocumentGenerator();

generator.InsertCharacter('H', 10, 10, 20);
generator.InsertCharacter('e', 10 ,10, 20);
generator.InsertCharacter('l', 10 ,10, 20);
generator.InsertCharacter('l', 10 ,10, 20);
generator.InsertCharacter('O', 10 ,10, 20);

generator.Show();

