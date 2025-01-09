
using System.Text.RegularExpressions;
using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;


public class Birthday : ValueObject
{

    private readonly Regex BirthdayRegex = new("^(0[1-9]|1[0-2])/(0[1-9]|1\\d|2\\d|3[01])/\\d{4}$", RegexOptions.Compiled);

    public Birthday(DateOnly dateofbirth, Regex birthdayregex)
    {
        if (dateofbirth > DateOnly.FromDateTime(DateTime.Now))
        {
            throw new ArgumentException("You're date of birth cannot be right now");
        }

        if (birthdayregex != BirthdayRegex)
        {
            throw new ArgumentException("The Format that you provide was incorrect");
        }
        DateOfBirth = dateofbirth;
        BirthdayRegexValidation = birthdayregex;
    }

    public DateOnly DateOfBirth { get; init; }
    public Regex BirthdayRegexValidation { get; init; }
    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return BirthdayRegexValidation;
        yield return DateOfBirth;

    }
}