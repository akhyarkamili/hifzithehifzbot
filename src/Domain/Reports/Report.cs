using Domain.Common;
using Domain.Mentees;
using Domain.Reports.ValueObjects;

namespace Domain.Reports;

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