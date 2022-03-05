using System.ComponentModel.DataAnnotations;
using Hifzi.Domain.Common;

namespace Hifzi.Domain.Reports.ValueObjects;

public class QuranMarker : ValueObject
{
    [Range(1, 117)]
    public int Surah { get; set; }
    public int Verse { get; set; }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Surah;
        yield return Verse;
    }
}