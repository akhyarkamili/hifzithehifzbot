using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using Domain.Quran;

#pragma warning disable CS8604

namespace Application;

public class Quran
{
    public Quran()
    {
        Surahs = new List<Surah>();
        
        foreach (var surahRaw in RawQuran.SURAHS)
        {
            var jsonSurah = JObject.Parse(surahRaw);
            var index = Int32.Parse(jsonSurah["index"].Value<string>());
            var name = jsonSurah["name"].Value<string>();
            var verses = new List<string>();
            var versesRaw = name == "al-Fatihah" ? jsonSurah["verse"] : jsonSurah["verse"].Skip(1);
            foreach (var verse in versesRaw)
            {
                var verseString = verse.First().Value<string>();
                verses.Add(verseString);
            }

            Surahs.Add(new Surah(index, name, verses.ToArray()));
        }
    }

    public static List<Surah> Surahs;
}