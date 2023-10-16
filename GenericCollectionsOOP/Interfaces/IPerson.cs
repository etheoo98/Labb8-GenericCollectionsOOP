namespace GenericCollectionsOOP.Interfaces;

// An enum for Gender to restrict possible values for the property used by inheritors.
public enum Gender
{
    Male,
    Female
}

public interface IPerson
{
    public string Name { get; }
    public Gender Gender { get; }
}