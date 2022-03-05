using Hifzi.Domain.Common;
using Hifzi.Domain.Mentees;
using Hifzi.Domain.Reports.ValueObjects;

namespace Hifzi.Domain.Reports;

public class Report : Entity
{
    public Report(QuranMarker start, QuranMarker end)
    {
        Start = start;
        End = end;
    }

    public Mentee Mentee { get; }
    public QuranMarker Start { get; private set; }
    public QuranMarker End { get; private set; }
}