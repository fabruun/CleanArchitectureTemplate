namespace CleanArchitecture.Domain.Common.Models;

public abstract class Entity<TEntityId>
    where TEntityId : notnull
{
    private TEntityId Id { get; set; }

    protected Entity(TEntityId id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        return obj is Entity<TEntityId> entity && Id.Equals(entity.Id);
    }

    public static bool operator ==(Entity<TEntityId> left, Entity<TEntityId> right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Entity<TEntityId> left, Entity<TEntityId> right)
    {
        return !Equals(left, right);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}