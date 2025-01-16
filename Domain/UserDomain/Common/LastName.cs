using System.Text.RegularExpressions;
using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;

public class LastName : ValueObject
{

    private readonly Regex LastNameRegex = new(@"^([a-zA-Z]{2,}\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\s?([a-zA-Z]{1,}))$");

    //Constructor
    public LastName(string maxlength, Regex regex)
    {

        if (LastNameRegex == regex)
        {
            throw new ArgumentException("Name's must not contain special character");
        }



        LastNameRegularX = regex;
        MaximumLength = maxlength;
    }

    public Regex LastNameRegularX { get; init; }
    public string MaximumLength { get; init; }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return MaximumLength;
        yield return LastNameRegularX;
    }
}