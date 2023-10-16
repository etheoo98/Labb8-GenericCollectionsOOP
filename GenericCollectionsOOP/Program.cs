using GenericCollectionsOOP.Interfaces;
using GenericCollectionsOOP.Models;

namespace GenericCollectionsOOP;

internal static class Program
{
    private static readonly Stack<Employee> EmployeeStack = new();
    private static readonly List<Employee> EmployeeList = new();
    
    public static void Main()
    {
        EmployeeStack.Push(new Employee("Andre", Gender.Male));
        EmployeeStack.Push(new Employee("Ebba", Gender.Female));
        EmployeeStack.Push(new Employee("Karin", Gender.Female));
        EmployeeStack.Push(new Employee("Heikki", Gender.Male));
        EmployeeStack.Push(new Employee("Marie", Gender.Female));
        
        PrintStackElements();
        PopStackElements();
        PushToStack();
        PeekStack();
        ListNameContains('i');
        FindFirstGenderInList(Gender.Male);
        FindAllGenderInList(Gender.Male);
    }

    private static void PrintStackElements()
    {
        PrintHeader("These are the employees in the stack.", true);
        
        foreach (var employee in EmployeeStack)
        {
            Console.WriteLine(employee.ToString());
            Console.WriteLine($"There are now {EmployeeStack.Count} employees left in the stack.");
        }
    }

    private static void PopStackElements()
    {
        PrintHeader("Now retrieving and removing from stack using Pop()", true);
        
        while (EmployeeStack.Any())
        {
            var employee = EmployeeStack.Pop();
            Console.WriteLine(employee.ToString());
            Console.WriteLine($"There are now {EmployeeStack.Count} employees left in the stack.");
            EmployeeList.Add(employee);
        }
    }

    private static void PushToStack()
    {
        foreach (var employee in EmployeeList)
        {
            EmployeeStack.Push(employee);
        }
        
        PrintHeader("All employees are back in the stack through Push()", false);
    }

    private static void PeekStack()
    {
        PrintHeader("Now retrieving from stack using Peek()", true);
        
        for (var i = 1; i <= 2; i++)
        {
            var employee = EmployeeStack.Peek();
            Console.WriteLine(employee.ToString());
            Console.WriteLine($"There are now {EmployeeStack.Count} employees left in the stack.");
        }
        
        Console.WriteLine(EmployeeStack.Count >= 3
            ? "Yes, the stack contains employee 3."
            : "No, the stack does not contain employee 3.");
    }

    private static void ListNameContains(Char symbol)
    {
        PrintHeader($"Using Contains() in the List, These are the employees whose Name values contain '{symbol}' ", true);
        
        List<Employee> employeeNamesWithI = new();
        
        foreach (var employee in EmployeeList)
        {
            if (employee.Name.Contains(symbol))
            {
                employeeNamesWithI.Add(employee);
            }
        }

        if (employeeNamesWithI.Count > 0)
        {
            foreach (var employee in employeeNamesWithI)
            {
                Console.WriteLine(employee.ToString());
            }
        }
        else
        {
            Console.WriteLine($"Unfortunately no employees have \"{symbol}\"s in their names.");
        }
    }

    private static void FindFirstGenderInList(Gender gender)
    {
        PrintHeader($"Using Find() in the List, this is the first appearance of Gender value: {gender}", true);
        
        var employee = EmployeeList.Find(e => e.Gender == gender);
        if (employee != null)
        {
            Console.WriteLine(employee.ToString());
        }
    }

    private static void FindAllGenderInList(Gender gender)
    {
        PrintHeader($"Using FindAll() in the List, these are all appearances of the Gender value: {gender}", true);
        
        var employees = EmployeeList.FindAll(e => e.Gender == gender);
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }
    }

    // To make the output easier to read we add separators and highlight the header in a different colour.
    private static void PrintHeader(string header, bool printLastSeparator)
    {
        Console.WriteLine("-------------------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(header);
        Console.ResetColor();
        
        if (printLastSeparator)
        {
            Console.WriteLine("-------------------------------------");
        }
    }
}