using FP.Patterns.Flyweight.Exercice2;

MusicSheet musicSheet = new MusicSheet();

musicSheet.AddMusicalNote("do", "cuart", "happy");
musicSheet.AddMusicalNote("re", "mitg", "sad");
musicSheet.AddMusicalNote("do", "cuart", "sad");

musicSheet.DisplayMusicaNotes();