namespace Domain.Quran;

public class Surah
{
    public Surah(int index, string name, string[] verses)
    {
        Index = index;
        Name = name;
        Verses = verses;
    }

    public readonly int Index;
    public readonly string Name;
    public readonly string[] Verses;
};


