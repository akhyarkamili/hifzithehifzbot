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

        var quranJObject = JsonConvert.DeserializeObject<JArray>(quranJsonRaw);
    }

    public static List<Surah> Surahs;
}