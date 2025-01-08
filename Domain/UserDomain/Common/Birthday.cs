
using WaitApi.Domain.Primitives;

namespace WaitApi.Domain.UserDomain.Common;


public class Birthday : ValueObject
{
    
    public Birthday(DateOnly dob)
    {
        if(dob > DateOnly.FromDateTime(DateTime.Now)){
            throw new Exception("You're date of birth cannot be right now");
        }
        DateOfBirth = dob;
    }

    public DateOnly DateOfBirth { get; init; }

    protected override IEnumerable<object> GetAtomicValues()
    {
            yield return DateOfBirth;
    }
}