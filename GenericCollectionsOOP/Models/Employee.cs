using GenericCollectionsOOP.Interfaces;

namespace GenericCollectionsOOP.Models;

public class Employee : Person, IEmployee
{
    public int Id { get; }
    /*
     * We check the value of salary sent to the constructor, to ensure that it is not a negative, since salaries aren't
     * expected to negative, before we assign the value to the _salary field.
     */
    public double Salary
    {
        get => _salary;
        set
        {
            if (value < 0)
                throw new Exception("Attempted to assign a negative value to _salary. _salary must be 0 or " +
                                    "greater.");
            _salary = value;
        }
    }
    
    /*
     * To make it simpler to create an employee object (and because it's fun), we allow no argument to be passed to
     * salary (its default value is null). A null-coalescing operator "??" is used to determine if a random number
     * should be generated or if we keep the value that was sent to the constructor.
     *
     * To increase modularity we are also using the constructor of the base class, which handles the value assignments
     * of Name and Gender, which this class inherits.
     */
    public Employee(string name, Gender gender, double? salary = null) :base(name, gender)
    {
        Id = ++_lastId;
        Salary = salary ?? Random.Next(MinRandomSalary, MaxRandomSalary + 1);
    }

    public override string ToString() => $"{Id}, {Name}, {Gender}, {Salary}";
    
    /*
     * _lastId is made static since it will not contain instanced data. It will increment with 1 in the constructor
     * each time an object is created to achieve auto incrementation of the instanced property Id.
     */
    private static int _lastId;
    private static readonly Random Random = new();
    private const int MinRandomSalary = 34000;
    private const int MaxRandomSalary = 65000;
    private double _salary;
}