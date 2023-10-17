/*
 * Author: Theodor Hägg (.NET23)
 * Website: https://www.github.com/etheoo98/Labb8-GenericCollectionsOOP
 * Date: October 16, 2023
 */

using GenericCollectionsOOP.Interfaces;
using GenericCollectionsOOP.Models;

namespace GenericCollectionsOOP;

internal static class Program
{
    private static readonly Stack<Employee> EmployeeStack = new();
    private static readonly List<Employee> EmployeeList = new();
    
    public static void Main()
    {
        var employee1 = new Employee("Andre", Gender.Male);
        var employee2 = new Employee("Ebba", Gender.Female);
        var employee3 = new Employee("Karin", Gender.Female);
        var employee4 = new Employee("Heikki", Gender.Male);
        var employee5 = new Employee("Marie", Gender.Female);
        
        EmployeeStack.Push(employee1);
        EmployeeStack.Push(employee2);
        EmployeeStack.Push(employee3);
        EmployeeStack.Push(employee4);
        EmployeeStack.Push(employee5);
        
        PrintStackElements();
        PopStackElements();
        PushToStack();
        PeekStack();
        StackContains(employee3);
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
    }

    private static void StackContains(Employee employee3)
    {
        PrintHeader(EmployeeStack.Contains(employee3)
                ? "Yes, the stack contains employee3."
                : "No, the stack does not contain employee3.", false);
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