using WaitApi.Domain.Primitives;
using System.Text.RegularExpressions;


namespace WaitApi.Domain.UserDomain.Common;

public sealed class FirstName : ValueObject
{
    private const int MaxLength = 50;
    private static readonly Regex FirstNameRegex =
           new("^[a-z\\d](?:[a-z\\d]|-(?=[a-z\\d])){0,38}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public FirstName(string value, Regex regex)
    {
        if (value.Length < MaxLength)
        {
            throw new Exception("The Length of the Firstname exceeds the Maximum Length");
        }
        if (FirstNameRegex == regex)
        {
            throw new Exception("Your Firstname does contain special character that are not allowed");
        }
        RegularX = regex;
        Value = value;
    }
    public Regex RegularX { get; init; }
    public string Value { get; init; }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return RegularX;
        yield return Value;

    }


}