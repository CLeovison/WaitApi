namespace WaitApi.Domain.Entity;

public abstract class Entity : IEquatable<Entity>
{
    public Guid ID { get; private init; }

    protected Entity(Guid id)
    {
        ID = id;
    }

    public static bool operator ==(Entity? first, Entity? second)
    {
        return first is not null && second is not null && first.Equals(second);
    }

    public static bool operator !=(Entity? first, Entity? second)
    {
        return !(first == second);
    }


    public bool Equals(Entity? other)
    {
        if (other is null)
        {
            return false;
        }

        if (other.GetType() != GetType())
        {
            return false;
        }

        return other.ID == ID;
    }


    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj.GetType() != obj.GetType())
        {
            return false;
        }

        if (obj is not Entity entity)
        {
            return false;
        }
        return entity.ID == ID;
    }

    public override int GetHashCode()
    {
        return ID.GetHashCode();
    }
}