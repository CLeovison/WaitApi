using System.Text.RegularExpressions;
using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;

public class LastName : ValueObject
{

    private readonly Regex LastNameRegex = new(@"^([a-zA-Z]{2,}\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\s?([a-zA-Z]{1,}))$");
    private const int MaxLength = 40;

    //Constructor
    public LastName(Regex regex, string maxlength)
    {

        if (LastNameRegex != regex)
        {
            throw new ArgumentException("Name's must not contain special character");
        }

        if (MaxLength > maxlength.Length)
        {
            throw new ArgumentException("You're Last Name must not exceed 40 characters");

        }

        LastNameRegularX = regex;
        MaximumLength = maxlength;
    }

    public Regex LastNameRegularX { get; init; }
    public string MaximumLength { get; init; }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return LastNameRegularX;
    }
}