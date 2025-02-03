using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;

public class UserId : ValueObject
{
    public UserId(Guid id)
    {
        ID = id;
    }
    public Guid ID { get; init; }


    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return ID;
    }
}
