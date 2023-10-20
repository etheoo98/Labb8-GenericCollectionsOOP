[![wakatime](https://wakatime.com/badge/github/etheoo98/Labb8-GenericCollectionsOOP.svg)](https://wakatime.com/badge/github/etheoo98/Labb8-GenericCollectionsOOP)

# Labb8-GenericCollectionsOOP
C# console application made for a beginners programming course.

## Assignment Description
This assignment is about using two common generic types in C#. You will create a class and objects based on that class, which you will then manage using Stack and List.

### What you need to do

#### Part 1 - Stack
- Create a class named Employee:
  - This class should have several properties: **Id, Name, Gender, and Salary**.
- Create a Stack of Objects:
  - In the **Main()** method, create five objects of the class with different Id, Name, Gender, and Salary.
  - Then create a Stack and add the five objects you created using **Push()**.
- Print all objects in the stack:
  - Print all objects in your Stack.
  - You can use a foreach loop to print out all elements in the stack.
  - After each line or element, print out how many objects are left in the stack.
- Retrieve all objects using the Pop method:
  - Retrieve all objects in the stack using the **Pop()** method and print them out.
  - After each line or element, print out how many objects are left in the stack.
  - Add all objects back using the **Push()** method.
- Retrieve objects using the Peek method:
  - Retrieve two objects using the **Peek()** method.
  - After each line or element, print out how many objects are left in the stack.
- Check if object number 3 exists in the stack or not and print out the result.

#### Part 2 - List
- Create a List.
- Add five objects of the **Employee** class to your List.
- Create a condition using the **Contains()** method to check if a specific object exists in the list. If it does, print "*Employee2 object exists in the list*" to the console. Otherwise, print "*Employee2 object does not exist in the list*".
- Next, use the **Find()** method to find and print the first object in the list with **Gender = "Male"**.
- Then, use the **FindAll()** method to find and print all objects in the list with **Gender = "Male"**.
