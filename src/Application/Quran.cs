using System.Net.Http.Json;
using Newtonsoft.Json.Linq;
using Domain.Quran;
using Newtonsoft.Json;

#pragma warning disable CS8602
#pragma warning disable CS8604

namespace Application;

public class Quran
{
    private static readonly string[] DONT_SKIP_FIRST_VERSE = new string[] {"at-Taubah", "al-Fatihah"};

    public Quran(string requestUri)
    {
        Surahs = new List<Surah>();
        HttpClient client = new HttpClient();
        
        var quranJsonRaw = client.GetStringAsync(requestUri).Result;

        var quranJObject = JsonConvert.DeserializeObject<JArray>(quranJsonRaw);

    }

    public static List<Surah> Surahs;
}