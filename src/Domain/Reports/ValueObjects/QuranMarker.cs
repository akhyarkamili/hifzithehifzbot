using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Reports.ValueObjects;

public class QuranMarker : ValueObject
{
    [Range(1, 114)]
    public int Surah { get; set; }
    public int Verse { get; set; }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Surah;
        yield return Verse;
    }
}