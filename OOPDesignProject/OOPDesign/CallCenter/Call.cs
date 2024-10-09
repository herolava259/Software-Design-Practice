

using static OOPDesign.CallCenter.CallCenterEnum;

namespace OOPDesign.CallCenter;

public class Call
{
    public string PhoneNumber { get; private init; } = String.Empty;

    public ELevel Level { get; private init; }

    public Call(string phoneNumber, ELevel level = ELevel.Respondent)
    {
        PhoneNumber = phoneNumber;
        Level = level;
    }

    public Call Escalate()
    {
        if (Level == ELevel.Director)
            return this;
        return new(PhoneNumber, (ELevel)((int)Level + 1));
    }
}
