using System.Text.RegularExpressions;
using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;


public class Email : ValueObject
{
    private const int MinLength = 6;
    private static readonly Regex EmailRegex =
     new("^[\\w!#$%&’*+/=?`{|}~^-]+(?:\\.[\\w!#$%&’*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",
         RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public Email(string minlength, Regex regex)
    {
        if (minlength.Length < MinLength)
        {
            throw new Exception("Sorry your email must be 6 characters long");
        }

        if(regex != EmailRegex){
            throw new Exception("Your Email Was Not Valid");
        }

        Length = minlength;

        EmailRegularX = regex;
    }
    public required string Length { get; init; } = default!;

    public Regex EmailRegularX { get; init; }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Length;
        yield return EmailRegularX;
    }
}