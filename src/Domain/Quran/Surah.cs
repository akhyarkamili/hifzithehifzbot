namespace Domain.Quran;

public class Surah
{
    public Surah(int index, string englishName, Verse[] verses, string arabicName)
    {
        Index = index;
        EnglishName = englishName;
        Verses = verses;
        ArabicName = arabicName;
    }

    public readonly int Index;
    public readonly string EnglishName;
    public readonly string ArabicName;
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


