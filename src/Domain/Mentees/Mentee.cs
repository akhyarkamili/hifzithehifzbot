using System.Diagnostics.CodeAnalysis;
using Domain.Common;
using Domain.Mentors;
using Domain.Reports;

namespace Domain.Mentees;

[SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
public class Mentee : Entity
{
    public Mentee(Gender gender, string externalId, string nickname)
    {
        Gender = gender;
        ExternalId = externalId;
        Nickname = nickname;
    }

    public void AddReport(Report report)
    {
        Reports = Reports.Append(report);
    }
    
    public string Nickname { get; private set; }
    public string ExternalId { get; private set; }
    public Gender Gender { get; private set; }
    public Mentor Mentor { get; }
    public IEnumerable<Report> Reports { get; private set; }
}