namespace Domain.Quran;

public class Surah
{
    public Surah(int index, string name, Verse[] verses)
    {
        Index = index;
        Name = name;
        Verses = verses;
    }

    public readonly int Index;
    public readonly string Name;
    public readonly Verse[] Verses;
};

public class Verse
{
    public readonly string ArabicText;
    public readonly string EnglishTranslation;
    public readonly int PageNumber;

    public Verse(string arabicText, string englishTranslation, int pageNumber)
    {
        ArabicText = arabicText;
        EnglishTranslation = englishTranslation;
        PageNumber = pageNumber;
    }
}


