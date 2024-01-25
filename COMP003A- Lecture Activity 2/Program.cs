/* Author: Bryan Chavez
 * Cource: COMP003A-L01
 * Purpose: Lecture Activity for variables, type systems, MAth, and Console properties
 * Referennces: The C# Player's Guide 4e by RB Whitaker
 * */
namespace COMP003A__Lecture_Activity_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("What is your name?");
            username = Console.ReadLine();
            Console.WriteLine("Hi" + username);

            string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is" + favoriteColor);

            int score;
            score = 0;
            score = 4;
            score = 11;
            score = -1564;

            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current value of a" + a);
            Console.WriteLine("The current value of b" + b);

            b = a;
            a = -3;
            Console.WriteLine("The new value of a:" + a);
            Console.WriteLine("The new value of b:" + b);

            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("****************************************");

            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte:" + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);

            short aNumber = 5039;
            Console.WriteLine("aNumber:" + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber:" + aNumber);

            long aVeryBigNumber = 395904282569;
            Console.WriteLine("aVeryBigNumber:" + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBugNumber:" + aVeryBigNumber);

            int anInteger = 2147483647;

            char aLetter = 'A';
            string message = "Hello World";

            Console.WriteLine("Concatenation using +" + aLetter + " " + message);
            Console.WriteLine($"Concatenation using string interpolation : {aLetter} {message}");

            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.54623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2 : {number2}");
            Console.WriteLine($"Value of number3 : {number3}");

            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber : {avogadrosNumber}");

            bool itWorked= true;
            Console.WriteLine($"Value of itWorked : {itWorked}");
            itWorked = false;
            Console.WriteLine($"New value of itWorked : {itWorked}");

            string inputAgestring;
            int inputAge;
            int currentYear = 2023;
            Console.WriteLine($"Enter age in {currentYear}:"); 
            inputAgestring = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgestring);
            Console.WriteLine($"Your age is {inputAge}");

            Console.WriteLine("******************************************");

            int addition = 2 + 3;
            int subtraction=5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition : {addition}");
            Console.WriteLine($"Value of subtraction : {subtraction}");
            Console.WriteLine($"Value of multiplication : {multiplication}");
            Console.WriteLine($"Value of division : {division}");
            Console.WriteLine($"Value of modulo : {modulo}");

            int arithemetic1;
            arithemetic1 = 9 - 2;
            Console.WriteLine($"Value of arithemetic:{arithemetic1}");
            arithemetic1 = 3 + 3;
            Console.WriteLine($"Value of arithemetic1 : {arithemetic1}");
            int arithmetic2 = 3 + 1;
            Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2;
            Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

            int results =(2 + 1) * 8 - (3 * 2) * 2;
            Console.WriteLine($"Value of results: {results}");

            int compoundAssignmentOperator = 0;
            compoundAssignmentOperator += 5;
            compoundAssignmentOperator -= 2;
            compoundAssignmentOperator *= 4;
            compoundAssignmentOperator /= 2;
            compoundAssignmentOperator %= 2;
            int incrementDecrementOperators = 0;
            incrementDecrementOperators++;
            incrementDecrementOperators--;

            Console.WriteLine("************************************");

            Console.Write("What is your name, human? ");
            string userName = Console.ReadLine();

            Console.WriteLine("Press any key when you're ready to begin.");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Hello World!";

            Console.Beep(440, 1000); 











        }
    }
}