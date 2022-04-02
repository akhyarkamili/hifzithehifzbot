using System.Net.Http.Json;
using Newtonsoft.Json.Linq;
using Domain.Quran;
using Newtonsoft.Json;

#pragma warning disable CS8602
#pragma warning disable CS8604

namespace Application;

public class Quran
{
    public Quran(string requestUri, HttpClient client)
    {
        Surahs = new List<Surah>();
        
        var quranJsonRaw = client.GetStringAsync(requestUri).Result;

        var quranJArray = JsonConvert.DeserializeObject<JArray>(quranJsonRaw);
        
        for (int i=0;i<114; i++)
        {
            var ayahCount = quranJArray[i]["ayahCount"].Value<int>();
            var verses = new Verse[ayahCount];
            
            for (int j = 0; j < ayahCount; j++)
            {

                var myArabicText = quranJArray[i]["ayahs"][j]["text"]["ar"].Value<string>();
                var myEnglishTranslation = quranJArray[i]["ayahs"][j]["translation"]["en"].Value<string>();
                var myPageNumber = quranJArray[i]["ayahs"][j]["page"].Value<int>();

                var currentVerse = new Verse(myArabicText, myEnglishTranslation, myPageNumber);

                verses[j] = currentVerse;
            }
            
            var myIndex = i + 1;
            var myArabicName = quranJArray[i]["asma"]["ar"]["short"].Value<string>();
            var myEnglishName = quranJArray[i]["asma"]["en"]["short"].Value<string>();

            var currentSurah = new Surah(myIndex, myEnglishName, verses, myArabicName);

            Surahs.Add(currentSurah);
        }
    }
    public static List<Surah> Surahs;
}