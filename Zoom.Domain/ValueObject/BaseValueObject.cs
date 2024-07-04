namespace Zoom.Domain.ValueObject;

public class BaseValueObject
{
    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;
        if (obj is not FullName fullName)
            return false;
        if (fullName is null)
            return false;
        return true;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}