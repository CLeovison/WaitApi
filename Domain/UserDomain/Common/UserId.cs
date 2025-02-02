using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;

public class UserId(Guid id) : ValueObject
{

    public Guid ID { get; init; } = id;


    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return ID;
    }
}
