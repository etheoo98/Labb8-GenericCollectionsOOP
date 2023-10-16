namespace GenericCollectionsOOP.Interfaces;

public interface IEmployee
{
    // Inheritors must implement an Id to uniquely identify Employee objects in case of duplicate property values.
    public int Id { get; }
}