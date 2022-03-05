using Hifzi.Domain.Common;
using Hifzi.Domain.Mentees;

namespace Hifzi.Domain.Mentors;

public sealed class Mentor : Entity
{
    public Mentor(string name, string externalId, Gender gender)
    {
        Name = name;
        ExternalId = externalId;
        Gender = gender;
    }

    public string Name { get; private set; }
    public string ExternalId { get; private set; }
    public Gender Gender { get; private set; }
    public List<Mentee> Mentees { get; private set; }
}