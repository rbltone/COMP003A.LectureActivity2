/*
 * Author: Anthony Perez
 * Course: COMP-003A
 * Purpose: Lecture activity for variables, type system, Math, and Console properties
 * Reference: The C# Player's Guide (4e) by RB Whitaker
*/

namespace COMP003A.LectureActivity2_;
class Program
{
    static void Main(string[] args)
    {
        /* working with variables */ 
        string username;
        Console.WriteLine("What is your name?");
        username = Console.ReadLine();
        Console.WriteLine("Hi " + username);


        string favoriteColor;
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine();
        Console.WriteLine("Your favorite color is " + favoriteColor);

        /* Working with variable integers */
        int score;
        score = 0;
        score = 4;
        score = 11;
        score = -1564;

        /* Reading from a variable does not change it */
        int a;
        int b;

        a = 5;
        b = 2;
        Console.WriteLine("The current value of a: + a");
        Console.WriteLine("The current value of b: + b");

        /* Variables are case-sensitive */
        string exampleVariable;
        string exampleVAriable;
        string exampleVARiable;

        Console.WriteLine("**************************************************");

        /* Declaring and using variables with integer types */
        byte aSingleByte = 34;
        Console.WriteLine("aSingleByte: " + aSingleByte);
        aSingleByte = 17;
        Console.WriteLine("aSingleByte: " + aSingleByte);

        short aNumber = 5039;
        Console.WriteLine("aNumber: " + aNumber);
        aNumber = -4354;
        Console.WriteLine("aNumber: " + aNumber);

        long aVeryBigNumber = 395904282569;
        Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
        aVeryBigNumber = 13;
        Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);

        int anInteger = 2147483647;

        /* Declaring, using, and concatenating characters are strings */
        char aLetter = 'A';
        string message = "Hello World!";

        Console.WriteLine("Concatenation using + : " + aLetter + " " + message);
        Console.WriteLine($"Concatenation using string interpolation : {aLetter} {message} ");

        /* Floating-point types */
        double number1 = 3.5623;
        float number2 = 3.5623f;
        decimal number3 = 3.5623m;
        Console.WriteLine($"Value of number1 :  {number1}");
        Console.WriteLine($"Value of number2 :  {number2}");
        Console.WriteLine($"Value of number3 :  {number3}");

        /* Scientific notation */
        double avogadrosNumber = 6.022e23;
        Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber}");

        /* bool type */
        bool itWorked = true;
        Console.WriteLine($"Value of itWorked: {itWorked}");
        itWorked = false;
        Console.WriteLine($"New value of itWorked: {itWorked}");

        /* convert */
        string inputAgeString;
        int inputAge;
        int currentYear = 2023;

        Console.WriteLine("**************************************************");
        /*
         * math operations: +
         * subtraction: -
         * multipliction: *
         * division: /
         * modulo: % (remainder)
         */
        int addition = 2 + 3;
        int subtraction = 5 - 2;
        int multiplication = 22 * 2;
        int division = 21 / 7;
        int modulo = 77 % 5;
        Console.WriteLine($"Value of addition: {addition}");
        Console.WriteLine($"Value of subtraction: {subtraction}");
        Console.WriteLine($"Value of multiplication: {multiplication}");
        Console.WriteLine($"Value of division: {division}");
        Console.WriteLine($"Value of modulo: {modulo}");

        int arithmetic1;
        arithmetic1 = 9 - 2;
        Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
        arithmetic1 = 3 + 3;
        Console.WriteLine($"New value of arithmetic1: {arithmetic1}");
        int arithmetic2 = 3 + 1;
        Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
        arithmetic2 = 1 + 2;
        Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

        // use multiple sets of parenthesis to group operations
        int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
        Console.WriteLine($"Valie of reault: {result}");

        /* compound assignment operator */
        int compoundAssignmentOperator = 0;
        compoundAssignmentOperator += 5;
        compoundAssignmentOperator -= 2;
        compoundAssignmentOperator *= 4;
        compoundAssignmentOperator /= 2;
        compoundAssignmentOperator %= 2;

        /* increment and decrement operators */
        int incrementDecrementOperators = 0;
        incrementDecrementOperators++;
        incrementDecrementOperators--;

        Console.WriteLine("**************************************************");
        Console.WriteLine("What is your name, human? ");
        string userName = Console.ReadLine();

        Console.WriteLine("Press any key when you're ready to begin.");
        Console.ReadKey();

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "Hello World!";

        Console.Beep(440, 1000);
    }

}

