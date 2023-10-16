using GenericCollectionsOOP.Interfaces;

namespace GenericCollectionsOOP.Models;

public class Person : IPerson
{
    /*
     * In order to prevent null or empty values from being assigned to the _name field, we throw an exception if this is
     * the case.
     */
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Attempted to assign Null or Empty to _name");
            _name = value;
        }
    }
    public Gender Gender { get; }

    public Person(string name, Gender gender)
    {
        Name = name;
        Gender = gender;
    }
    
    private string _name = null!;
}