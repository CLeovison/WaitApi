

using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;

public sealed class FirstName : ValueObject
{
    public const int MaxLength = 50;

    public FirstName(string value)
    {

        if (value.Length > MaxLength)
        {
            throw new Exception("The Length of the Firstname exceeds the Maximum Length");
        }

        Value = value;
    }

    public string Value { get; init; }

    protected override IEnumerable<object> GetAtomicValues(){
        yield return Value;
    }


}