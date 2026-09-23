// Week 1 Practicals

// // Task 1: Processing User Input
// void askingName()
// {
//     // Declare
//     String name;
//     int age;
//     int calculateAgeFromThirty;
//
//     // User Input - name and age
//     Console.Write("What is your name: ");
//     name = Console.ReadLine();
//
//     Console.Write("Please enter your age: ");
//     age = Convert.ToInt32(Console.ReadLine());
//
//
//     // Calculating how many years age is from 30
//     calculateAgeFromThirty = 30 - age;
//
//
//     // Output Results
//     Console.WriteLine($"Hello {name}, you will be 30 in {calculateAgeFromThirty} years");
// }
//
//
// askingName();






// // Task 2: Selection Statements
//
// void determineAge()
// {
//     // Declare
//     int age;
//     
//     Console.WriteLine("Enter your age: ");
//     age = Convert.ToInt32(Console.ReadLine());
//     
//     
//     // Determining age
//     if (age < 13)
//     {
//         Console.WriteLine("This is a child");
//     }
//     else if (age > 13 && age < 19)
//     {
//         Console.WriteLine("This is a teenager");
//     }
//     else if (age > 19)
//     {
//         Console.WriteLine("This is an adult");
//     }
//     else if (age > 110)
//     {
//         Console.WriteLine("Oldest person should be less than 110 years old");
//     }
// }
//
// determineAge();









// // Task 3: Logical Operators
// void logicalOperators()
// {
//     // Declare
//     int userInteger;
//     
//     Console.WriteLine("Please enter an integer: ");
//     userInteger = Convert.ToInt32(Console.ReadLine());
//
//     if (userInteger > 0)
//     {
//         Console.WriteLine("This integer is a positive number");
//     }
//     else if (userInteger < 0)
//     {
//         Console.WriteLine("This integer is a negative number");
//     }
//     else
//     {
//         Console.WriteLine("This integer equal to 0");
//     }
//
// }
//
// logicalOperators();







// // Task 4: Leap Year Checker
// void leapYear()
// {
//     // Declare
//     int year;
//
//
//     Console.WriteLine("Enter the year: ");
//     year = Convert.ToInt32(Console.ReadLine());
//
//     if (year % 4 == 0)
//     {
//         Console.WriteLine($"The year, {year} , is a leap year");
//     }
//     else if (year < 0)
//     {
//         Console.WriteLine("Invalid year, it should not be negative");
//     }
//     else
//     {
//         Console.WriteLine($"The year, {year} , is not a leap year");
//     }
// }
//
//
// leapYear();











// // Task 5: Even or Odd Checker
// void evenOddChecker()
// {
//     // Declare 
//     int integer;
//
//     // Input integer
//     Console.WriteLine("Enter integer: ");
//     integer = Convert.ToInt32(Console.ReadLine());
//     
//     // Checks whether even or odd
//     if (integer % 2 == 0)
//     {
//         Console.WriteLine($"The integer, {integer}, is even");
//     }
//     else
//     {
//         Console.WriteLine($"The integer, {integer}, is odd");
//     }
// }
// evenOddChecker();
