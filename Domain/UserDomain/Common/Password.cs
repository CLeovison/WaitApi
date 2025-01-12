using WaitApi.Domain.Primitives;

public class Password : ValueObject
{
    public string MinimumLength { get; init; }
    public Password(string minlegnth)
    {
        if (minlegnth.Length < 6 || minlegnth.Length > 30)
        {
            throw new ArgumentException("Your username must be in between 6 to 30 characters long");
        }

        MinimumLength = minlegnth;
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return MinimumLength;
    }
}