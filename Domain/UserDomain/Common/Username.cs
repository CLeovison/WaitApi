using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;


public class Username : ValueObject
{
    public Username(string minlegnth)
    {
        if (minlegnth.Length < 6 || minlegnth.Length > 30)
        {
            throw new ArgumentException("Your username must be in between 6 to 30 characters long");
        }

        MinimumLenghth = minlegnth;
    }

    public string MinimumLenghth { get; init; }
    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return MinimumLenghth;
    }
}