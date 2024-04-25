//using System;
// This is the imported Assemblies and 'namespaces' that allow for stuff like "Console.Writeline"

/*
General Notes to keep handy:
- Variable | A Name given to a storage location in memory {The Following are Considered, PRIMITIVE DATA TYPES}
    | 1. Integral Numbers
        a. byte [Byte] {0 - 255}
            i. Byte (1) is the name, Byte (2) is the .net type, the numbers, is the range of data it can store
        b. short [Int16] {-32,786 - 32,786}
        c. int [Int32] {-2.1B - 2.1B}
            i. Default Data Type
        d. long [Int64] {...}
    |2. Real Numbers
        a. float [Single} {-3.4*10^38 - 3.4*10^38}
        b. double [Double] {...}
            i. Default Data type
        c. decimal [Decimal] {-7.8*10^28 - 7.8*10^28}
    |3. Characters
        a. char [Char] {Unicode Character}
    |4. Boolean
        a. bool [Boolean] {True/False}
    |5. String (Non-Primitive)
    |6. Array (Non-Primitive)
    |7. Enum (Non-Primitive)
    |8. Class (Non-Primitive)
- Constant | An immutable (unchangeable) value
- Use 'Code Snippets'
    > A Code Snippet is when you only have to write a couple letters, and Visual Studio is able to recognize what you are trying to write.
      kinda like auto fill on your phone or a browser shortcut.
        i. For Example, typing "cw" then pressing tab, you will have written out a full "Console.WriteLine()" 
-Other Code Snippets
    | 1. 
- Use IntelliSense
    > This allows you to type only the first 2 letters of a variable into the parameter of a "Console.WireLine" and it will then auto 
      complete after you press tab. This is more like an auto complete on your phone, but better
- Press Ctrl + Alt + J in order to get to the 'Object Browser'
- Escape Sequences are small forms of text that allow you to alter a string literal, with characters that would be difficult to do otherwise.
    | 1.\a = Bell (alert)
    | 2.\b = Backspace
    | 3.\f = form feed
    | 4.\n = new line
    | 5.\r = carriage return
    | 6.\t = horizontal tab
    | 7.\v = vertical tab
    | 8.\' = single quote
    | 9.\" = quote
    | 10.\\ = back-slash
    | 11.\? = A literal question mark 
 */

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Encyclopedia
// - The Name of our Program and the code inside of it. The classes created in this namespace, can’t be used in a
//different namespace outside of it
{
    internal class Program
    //internal is the C# access modifier. Internal types or members are accessible only within files in the same assembly.
    //class is a type of program that allows for the functionality of functions and other data in a single place
    //Program is the name of the class
    {
        static void Main(string[] args)
        /* 
        - Static says that this method is not an instance, rather it is the method itself (the blueprint)
        - Void. The 'return type'. Void means nothing. Meaning this method is to return no value, it simply contains code.
        - This is the 'Main' Method.It is a very special Method keyword which is the entry point of the program
        - C# is case sensitive, meaning CAPITALIZATION MATTERS A LOT
        - All methods have inputs and outputs, and the "(string[] args)" is the input.
        - "(string[] args)" is also known as the argument or the parameter
        - "(string[] args)" - The parameter is 'args' of type string array (string[])
        - "args" is the array of string that pass on the message to the computer, how to configure files and code before execution  
        - This {} curly braces are necessary after a line of code is typed.
        - This is applicable to, [namespaces, classes, and methods] 
        */
        {
            //THEORY
            // > Studying the Program, rather than looking for results and writing it


            Console.WriteLine("\t Write Line Demonstration");
            Console.WriteLine("Hello World");
            /* 
             - Console is the class we are referring to. It is able to read or write data to and from the Console
             - Console is known by and is being used form the "System" namespace
             - "." is the access of the execution of the method WriteLine known to and usable by the Console class
             - WriteLine is the Method that allows the printing of text on the console
             - The parameter ("Hello World") is optional, but since it is a string, it has to be in quotation marks ("")
             - The Text "Hello World" is then shown to the user or in the console display
            */

            Console.WriteLine("C# Program");

            Console.ReadLine();
            /* 
             - Console is the class we are referring to. It is able to read or write data to and from the Console
             - Console is known by and is being used form the "System" namespace
             - "." is the access of the execution of the method ReadLine known to and usable by the Console class
             - ReadLine is the Method that allows the user to enter a line of text
             - The () contains the list of parameters of which there are none for the ReadLine Method
             - Once the user types something and presses enter, the code will read and then move on
             - An input of data must be provided by the user
             - The data is not displayed for anyone to see, rather is used in the background of the console
             */

            int a;
            /*
            This is called DECLARING A VARIABLE
            To declare a variable you must state:
                | 1. The variable Type
                    a. int
                    b. string
                    c. float
                    d. char
                | 2. The variables Identifier. {Conventional Naming Systems Recommended}
                    a. Requirements: 
                        i. It cannot start with a number
                        ii. Cannot include White space (No Spacing)
                        iii. Cannot Be a Keyword (Like Int) {To compensate, use something like @int)
                        iv. Recommendation, Use MEANINGFUL names
                    b. Naming Systems
                        i. Camel Case - firstName
                            > Use for Variables
                        ii. Pascal Case - FirstName
                            > Use for Constants
                        iii. Hungarian Notation - strFirstName 
                            > This uses the type of variable, before the Pascal naming System is used

                | 3. End in a Semicolon
            */

            int b = 3;
            /*
            - Optionally when declaring a variable, you can also initialize the variable
            - Meaning you can set the variables value
                |Notice it is grayed out, this is because it is currently going unused
            - You are not allowed to use a variable unless you initialize it
            - C# is case sensitive so the variable int "number" is not clashing or in conflict with the new int "Number"
              as capitalization is very important is C#
            */

            float c = 1.2f;
            /*
             Since a Double is the default data type for real numbers, you must declare with 'f' that you are declaring a float
             You can't exactly declare a float as a double. That would come up as a error 
             */
            decimal d = 1.3m;
            //Same rule applies to decimals, but instead of 'f', you must use 'm'

            //OVERFLOWING

            checked //This checks for overflow, and throws the program an exception
            {
                byte e = 255;
                //Maximum Capacity for a 'byte' to hold

                //threeNumber = threeNumber + 1; //0
                //Attempting to Store 256 in a byte will give an error
            }


            // SCOPE
            //     {
            byte f = 1;
            // 'a' can be accessed anywhere within the most recent curly braces (2 curly braces can be referred to as a block)
            // 'a' Can also be accessed from any of its child blocks
            // 'b' or 'c' cannot be accessed within their parent blocks on the other hand
            //     {
            byte g = 2;
            //     {
            byte h = 3;
            //     }
            //     }
            //     }

            //NON-THEORY

            Console.WriteLine("\n\t Integer Explanations");

            byte i = 2;
            int j = 10;
            float k = 20.95f;
            char l = 'A';
            string m = "Mosh";
            bool n = false;
            //Note: Another easy way to do this, it to replace all variable types with "var" and allow the VS (visual studios) compiler
            // to figure it out


            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);

            Console.WriteLine("\n\t Min and Max Values");
            Console.WriteLine($"{0}, {1}", byte.MinValue, byte.MaxValue); // This is an example of STRING INTERPOLATION. It expresses an empty value, that is filled by the followed up var
                                                                          // String interpolation always begins with a dollar sign
                                                                          // Another way to do this, is by replacing the {0} with a string literal, which could look like "Console.WriteLine($"{byte.MinValue}, {byte.MaxValue}";"
                                                                          // {0}, is considered a placeholder. It will be replaced with the next following argument it is presented with. in this case
                                                                          // the MinValue of the data type byte

            const float o = 3.14f;
            //This can no longer be changed. it is completely static, and cannot be edited in the program

            //IMPLICIT TYPE CONVERVERSION

            byte p = 1; //                           00000001  This is the Binary Implications of the byte we just stored
            int q = p; // 00000000 00000000 00000000 00000001  This is the Binary Implications of the int we just stored

            // When converting a byte to an integer, the program compensates the byte's empty values with 0's (Each 8 0's - Bytes)
            // This means there is no data loss when transferring the byte to an int
            // Another example of this is the type conversion of an int to a float

            int r = 1;
            float s = r;

            // No data is lost in this conversion either

            //This next example will not be compiled by the program.

            /*
            int iThree = 1; ;
            byte numTwo = iThree;
            */

            // This will not compile as there is chance for data loss (ie. An int could POSSIBLY store more info than the byte can hold)
            // To fix this issue, you need to use EXPLICIT TYPE CONVERSION

            int t = 1;
            byte u = (byte)t;

            // By telling the program what we want the byte to be considered (ie. not an int) it will run no matter if there is data loss)

            float v = 1.0f;
            int w = (int)v;

            // This also works because it uses what is called 'CASTING' (The "(int)" thing)

            //Occasionally, you will need to convert types that are not compatible
            //For Example: 

            /*
            string s = "1";
            int iFive = (int)s;
            */
            // But something like this won't compile, for the program. So we have to use the CONVERT CLASS or the PARSE METHOD

            string x = "1";
            int y = Convert.ToInt32(x);
            int z = int.Parse(x);

            // The Conert Class contains methods such as, {ToByte(), ToInt16(), ToInt32(), ToInt64(), ect}

            //Another interesting way to use the types is something like:
            Console.WriteLine("\n\t Convert Class and Type Explanation");
            Console.WriteLine(x.GetType);

            //This will now output the type that s is, in this case, System.String

            // OPERATORS {Arithmetic Operations, Comparison Operators, Assignment Operators, Logical Operators, Bitwise Operators}

            //ARITHMETIC
            /*
            Add(+) = a + b
            Substract(-) = a - b
            Multiply(*) = a * b
            Divide(/) = a / b
            Remainder(%) = a % b
            Increment(++) = a++ [Same as, a = a + 1]
                > b = a++ will first assign a to b, then add 1 to a
                > b = ++a will first add 1 to a, then assign a to b
            Decrement(--) = a-- [Same as, a = a - 1] 
             */

            //COMPARISON OPERATORS
            /*
            Equal(==) = a == b
            Not Equal(!=) = a != b
            Greater Than(>) = a > b
            Greater Than or Equal To(>=) = a >= b
            Less Than(<) = a < b
            Less Than or Equal to(<=) = a <= b
            */

            //ASSIGNMENT OPERATORS
            /*
            Assignment(=) = a = 1
            Add(+=) = a += 3 [Same as, a = a + 3]
            Substract(-=) = a -= 3 [Same as, a = a - 3]
            Multiply(*=) = a *= 3 [Same as, a = a * 3]
            Divide(/=) = a /= 3 [Same as, a = a / 3]
            */

            //LOGICAL OPERATORS
            /*
            And(&&) = a && b
            Or(||) = a || b
            Not(!) = !a
            */

            //BITWISE OPERATORS
            /*
            And(&) = a & b
            Or(|) = a | b
            */








            // CONSOLE METHOD USES (PRIMARY USEFUL ONES)
            Console.WriteLine("\n\t Console Method Uses");
            Console.WriteLine(); // Writes a string literal, on a new line
            Console.Write(""); // Writes a string literal on the already existing line of when its called
            Console.WriteLine("Read Key");
            Console.ReadKey(); //  Stops the program, only when a key is pressed by the user
            Console.WriteLine("\nRead Line");
            Console.ReadLine(); // Reads the next user's input, they write a sentence, hit enter, and that is now taken by the console


            // USER INPUT
            Console.WriteLine("\n\t User Input Demonstration");
            Console.WriteLine("Write Sum");
            string name = Console.ReadLine(); // Self Explanatory

            // THE MATH CLASS

            double aOne = 3;
            double bOne = 5;


            double cOne = Math.Pow(aOne, 2); // This will now output the 3^2 equal to 9. 3 to the second POWer

            double dOne = Math.Sqrt(bOne); // This would output the square root of 9, as bOne is now equal to 9. So this will output 3

            double eOne = Math.Abs(aOne); // This will now output the absolute value of aOne, which is 3

            double fOne = Math.Round(aOne); // If aOne was a decimal, this would output aOne, rounded to the nearest whole number

            double gOne = Math.Ceiling(aOne); // If aOne were a Decimal, this would output of aOne, round Up to the nearest integer

            double hOne = Math.Floor(aOne); // If aOne were a Decimal, this would output of aOne, round down to the nearest integer

            double iOne = Math.Max(aOne, bOne); // This will now output the maximum value between aOne and bOne, being bOne (5 > 3)

            double jOne = Math.Min(aOne, bOne); // This will now output the minimum value between aOne and bOne, being aOne (5 < 3)


            // RANDOM NUMBERS

            Random randomName = new Random();

            int aTwo = randomName.Next(1, 7); // This will give a 'random' number between 1-6, because of how C# works, the 7 is 'exclusive' and is not in the data pool
            int bTwo = randomName.Next(1, 7); // This will do the same with a seperate random number
            int cTwo = randomName.Next(1, 7); // Same as above

            double dTwo = randomName.NextDouble(); // This will assign dTwo, a random decimal between 0 and 1

            // MATHEMATICAL EXERCISE 
            // FINDING THE HYPOTENUSE AND ANGLE OF A RIGHT TRIANGLE
            Console.WriteLine("\n\t FINDING THE HYPOTENUSE AND ANGLE OF A RIGHT TRIANGLE");
            double aThree = 5; // One Side
            double bThree = 7; // Another Side

            double aThreeSquared = Math.Pow(aThree, 2); // Squaring the small side
            double bThreeSquared = Math.Pow(bThree, 2); // Squaring the Larger side

            double cThree = Math.Sqrt(aThreeSquared + bThreeSquared); // Finding the hypotenuse

            Console.WriteLine(cThree);

            double dThree = aThree / cThree; // Declaring a sine ratio of the small side and the hypotenuse

            double eThree = Math.Asin(dThree); // Find the Angle (In Radians) of the Sin Angle

            double fThree = eThree * (180 / Math.PI); // Converts the Radians of the angle to Degrees

            Console.WriteLine(fThree);


            // STRING METHOD

            string aFour = "John Doe";

            aFour = aFour.ToUpper(); // Makes the entire string Upper Case
            aFour = aFour.ToLower(); // Makes the entire string Lowercase

            string bFour = "123-456-7890";
            bFour = bFour.Replace("-", " "); // Replaces all dashes with Spaces

            string cFour = "JimmyBob";
            cFour = cFour.Insert(cFour.Length, "@gmail.com"); // Inserts "@gmail.com" at the end of the code. The first Parameter must be where to insert text

            string dFour = "Supercalifragilisticexpialidocious";
            int eFour = dFour.Length; // This property will find the length of a string and its characters

            string fFour = aFour.Substring(0, 4); // This will now seperate "John Doe"'s First name from his full name and assign it to 'fFour'



            // IF STATEMENTS ( Pretty Self Explanatory)

            Console.WriteLine("\n\t If Statements");

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("That is an invalid age!");
            }

            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }




            // SWITCHES = An efficient alternative to writing loads of else if statements

            Console.WriteLine("\n\t Switches");

            Console.WriteLine("What Day is it today?");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday": // If day is equal to the case, Monday, it will then proceed with its own code. Otherwise it will move to the next case and check
                    Console.WriteLine("It's Monday...");
                    break;

                case "Tuesday": // If day is equal to the case, Tuesday, it will then proceed with its own code. Otherwise it will move to the next case and check
                    Console.WriteLine("It's Tuesday...");
                    break;

                case "Wednesday": // If day is equal to the case, Wednesday, it will then proceed with its own code. Otherwise it will move to the next case and check
                    Console.WriteLine("It's Wednesday...");
                    break;

                case "Thursday": // If day is equal to the case, Thursday, it will then proceed with its own code. Otherwise it will move to the next case and check
                    Console.WriteLine("It's Thursday...");
                    break;

                case "Friday": // If day is equal to the case, Friday, it will then proceed with its own code. Otherwise it will move to the next case and check
                    Console.WriteLine("It's Friday!!");
                    break;

                case "Saturday": // If day is equal to the case, Saturday, it will then proceed with its own code. Otherwise it will move to the next case and check
                    Console.WriteLine("It's Saturday!!!");
                    break;

                case "Sunday": // If day is equal to the case, Sunday, it will then proceed with its own code. Otherwise it will move to the next case and check
                    Console.WriteLine("It's Sunday!");
                    break;
                default: // If the switch finds no matches, it will default to this case
                    Console.WriteLine(day + " isnt a day you fuckin Morron");
                    break;
            }

            // LOOPS

            //While loop - Repeats code WHILE a condition is true


            Console.WriteLine("\n\t While Loops");

            Console.WriteLine("Enter string here");
            string aFive = Console.ReadLine();

            while (aFive == "")
            {
                Console.WriteLine("Enter string here");
                aFive = Console.ReadLine();
            }

            // For Loop - Repeat code for an amount of time determined by the parameter

            Console.WriteLine("\n\t For Loops ");

            for (int bFive = 10; bFive >= 0; bFive--) // First, Initialize an index - how many times you want something to run (bFive), determine for how long. Then 
                                                      // determine the increment or decrement for the variable, every time the loop runs
            {
                Console.WriteLine(bFive);
            }

            //NESTED LOOPS - Loop in a loop
            // Examples :D

            Console.WriteLine("\n\t Nested Loops");

            Console.WriteLine("Rows?");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Columns?");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Symbol?");
            string symbol = Console.ReadLine();
            Console.WriteLine("\n");

            for (int aSix = 0; aSix < rows; aSix++)
            {
                for (int bSix = 0; bSix < columns; bSix++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }


            // EXAMPLE ROCK PAPER SCISSORS GAME

            Console.WriteLine("\n\t  ROCK PAPER SCISSORS GAME");

            // Initialize a Random object to generate random numbers
            Random random = new Random();

            // Initialize a boolean variable to control the game loop
            bool playAgain = true;

            // Initialize variables to store player's choice, computer's choice, and user's answer
            String player;
            String computer;
            String answer;

            // Game loop starts
            while (playAgain)
            {
                // Reset player's and computer's choices, and user's answer for each game iteration
                player = "";
                computer = "";
                answer = "";

                // Loop until the player enters a valid choice (ROCK, PAPER, or SCISSORS)
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                // Generate a random number (1, 2, or 3) to determine computer's choice
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";  // If random number is 1, computer chooses ROCK
                        break;
                    case 2:
                        computer = "PAPER"; // If random number is 2, computer chooses PAPER
                        break;
                    case 3:
                        computer = "SCISSORS"; // If random number is 3, computer chooses SCISSORS
                        break;
                }

                // Display player's and computer's choices
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                // Determine the outcome of the game based on player's and computer's choices
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!"); // If both choose ROCK, it's a draw
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!"); // If computer chooses PAPER, player loses
                        }
                        else
                        {
                            Console.WriteLine("You win!"); // If computer chooses SCISSORS, player wins
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!"); // If computer chooses ROCK, player wins
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!"); // If both choose PAPER, it's a draw
                        }
                        else
                        {
                            Console.WriteLine("You lose!"); // If computer chooses SCISSORS, player loses
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!"); // If computer chooses ROCK, player loses
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!"); // If computer chooses PAPER, player wins
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!"); // If both choose SCISSORS, it's a draw
                        }
                        break;
                }

                // Ask the user if they want to play again
                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                // Set the value of playAgain based on user's answer
                if (answer == "Y")
                {
                    playAgain = true; // If user chooses 'Y', continue playing
                }
                else
                {
                    playAgain = false; // If user chooses 'N', end the game
                }

            }

            // Display a thank you message after the game ends
            Console.WriteLine("Thanks for playing!");

            //Arrays - variable that can store several variables
            Console.WriteLine("\n\t Arrays ");

            string[] cars = { "BMW", "Mustang", "Corvette" };

            cars[0] = "Tesla"; // Everything begins counting at 0

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            for (int aSeven = 0; aSeven < cars.Length; aSeven++) // Good and flexible, but long to type
            {
                Console.WriteLine(cars[aSeven]);
            }

            string[] otherCars = new string[3]; // This initializes an array which can hold 3 values within it, without declaring values immediately

            //For Each Loops - a simpler way to iterate over an array, but less flexible
            Console.WriteLine("\n\t Foreach Loops ");

            string[] moreCars = { "BMW", "Mustang", "Corvette" };

            foreach (String car in cars) // Foreach ([data type] [new string name] in [array]) do this thing
            {
                Console.WriteLine(car);
            }

            //METHODS - a Simple way to re use code several times in many different places
            Console.WriteLine("\n\t Methods \n ");


            // Call the singHappyBirthday method three times
            singHappyBirthday();
            singHappyBirthday();
            singHappyBirthday();

            Console.WriteLine("\n\t Methods Part 2... \n ");

            // Declare a string variable to store the name of the person
            string nameOfPerson = "Romeo";

            // Call the singHappyBirthdayToYou method with the name of the person as an argument
            singHappyBirthdayToYou(nameOfPerson);
            singHappyBirthdayToYou(nameOfPerson);
            singHappyBirthdayToYou(nameOfPerson);

            // THE RETURN KEYWORD
            Console.WriteLine("\n\t The Return Keyword...\n ");

            double aEight = 5;
            double bEight = 7;
            Console.WriteLine("After being given 2 variables a parameter, the method RETURNS " + Multiply(aEight, bEight));

            // Note: Methods can have the same name, but they MUST HAVE DIFFERENT PARAMETERS

            //THE PARAMS KEYWORD - Can be applied to a method parameter, so it can hold a variable quantity of arguments. Parameter must be a single dimensional array
            Console.WriteLine("\n\t Params Keyword... \n ");

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

            Console.WriteLine(total);


            Console.WriteLine("\n\t Exceptions... \n ");
            // EXCEPTIONS - Errors during execution
            //Types of Exceptions:
            /*
                try - try some code that is considered dangerous
                catch - catches and handles exceptions when they occur
                finally - always executes regardless if exception is caught or not
             */

            double aNine;
            double bNine;
            double result;

            try // Tries this 'dangerous' code and finds possible exceptions
            {
                Console.Write("Enter Number 1:");
                aNine = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number 2:");
                bNine = Convert.ToInt32(Console.ReadLine());

                result = aNine / bNine;

                Console.WriteLine("result " + result);
            }
            catch (FormatException e) // Catches Format exceptions only. (Can't divide 3 by PIE)
            {
                Console.WriteLine("Enter Only numbers please");
            }
            catch (DivideByZeroException e) // Catches Divide by Zero exceptions only. (Can't divide 3 by 0)
            {
                Console.WriteLine("You cant divide by zero. Idot");
            }
            catch (Exception e) // Catches any exceptions left over that are not specified
            {
                Console.WriteLine("Sum Went Wrong");
            }
            finally // Runs after the code above is run regardless of exceptions
            {
                Console.WriteLine("Thanks for visiting!");
            }

            Console.WriteLine("\n\t Conditional Operators... \n ");
            // Conditional Operators - used in conjunction with assignment if a condition is true/false

            // (condition) ? x:y If the condition is true do x, if its false, do y

            double temperature = 20;
            string message;

            /*
            if (temperature >= 15) 
            {
                message = "It's warm Outside";
            }
            else
            {
                message = "It's cold outside";
            }

            Console.WriteLine(message);
            */

            // a Condition Operator is able to do the above, but simpler

            message = temperature >= 15 ? "It's warm outside" : "It's cold outside";
            Console.WriteLine(message);

            // MULTIDIMENSIONAL ARRAYS
            Console.WriteLine("\n\t MULTIDIMENSIONAL ARRAYS... \n ");

            string[] ford = { "Mustang", "F-150", "Explorer" };
            string[] chevy = { "Corvette", "Camaro", "Silverado" };
            string[] toyota = { "Corolla", "Camry", "Rav4" };

            string[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                     { "Corvette", "Camaro", "Silverado" },
                                     { "Corolla", "Camry", "Rav4" } };

            parkingLot[0, 2] = "Fusion";
            /* 
             foreach(string car in parkingLot)
             {
                 Console.WriteLine(car);
             }

            */

            // These are both ways in which you are able to print the multidimensional arrays

            for (int aEleven = 0; aEleven < parkingLot.GetLength(0); aEleven++)
            {
                for (int bEleven = 0; bEleven < parkingLot.GetLength(1); bEleven++)
                {
                    Console.Write(parkingLot[aEleven, bEleven]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            // CLASSES
            Console.WriteLine("\n\t CLASSES... \n ");

            //Noticed there is a new class within the solution explorer (Ctrl + Alt + L) [Messages Class]
            // This is how to access and methods found within the Messages class

            Messages.Hello();

            //OBJECTS - An instance of a class
            //          A class can be used as blueprint to create objects (OOP)
            //          Objects can have fields and methods (characteristics and actions)

            Human human1 = new Human(); // This now creates a human object, named human1
            human1.name = "Rick";
            human1.age = 65;

            human1.Eat();
            human1.Sleep();


            // You can use Human [name] = new Human(); to create a new object. Consider the Human class, as the blueprint for human creation. 
            // Applicably, Random is class that is commonly picked from to create a new random

            //CONSTRUCTORS - A special method in a class 
            //              Same name as the class
            //              Can be used to assign arguments to fields when creating objects

            Human human2 = new Human("Morty", 16);

            // OVERLOADED CONSTRUCTORS - Technique to create multiple constructors
            //                              with a different set of parameters
            //                              name + parameter = signature

            Pizza pizza1 = new Pizza("Stuffed Crust", "Red Sauce", "Mozzarella"); // If we wanted only a cheese pizza let's say
                                                                                  // There is now a new constructor that allows for no toppings, which would allow for ^^^ to be instituted

            // INHERITANCE - 1 or more child classes receiving fields, methods, ect. from a common parent
            Console.WriteLine("\n\t Inheritance... \n ");

            Car car1 = new Car();
            Bicycle bicycle1 = new Bicycle();
            Boat boat1 = new Boat();

            Console.WriteLine(car1.speed);
            Console.WriteLine(car1.wheels);
            car1.Go();

            Console.WriteLine(bicycle1.speed);
            Console.WriteLine(bicycle1.wheels);
            bicycle1.Go();

            Console.WriteLine(boat1.speed);
            Console.WriteLine(boat1.wheels);
            boat1.Go();

            // All of the 'Child' classes ( via the :) are able to access and use methods from their parents class

            // Abstract Classes - modifier that indicates  missing components or incomplete implementations

            // Vehicle vehicle = new Vehicle(); // This class is incomplete. It doesn't have access to any of the variables we established
            // in its 'offspring' classes (maxSpeed, and wheels)

            // OBJECTS IN AN ARRAY
            Console.WriteLine("\n\t OBJECTS IN AN ARRAY... \n ");
            Cars[] garage = { new Cars("Mustang"), new Cars("Corvette"), new Cars("Lambo") };

            foreach (Cars car in garage)
            {
                Console.WriteLine(car.model);
            }

            // OBJECTS AS ARGUMENTS

            Console.WriteLine("\n\t Objects as Arguments...\n");

            Cars car2 = new Cars("Mustang", "red");

            ChangeColor(car2, "silver");
            Console.WriteLine(car2.color + " " + car2.model);

            //Method Overriding - provides a new version of a method inherited from a parent class 
            //                      Inherited method must be: abstract, virtual, or already overridden
            //                      Used with ToString(), polymorphism

            Console.WriteLine("\n\t Method Overriding...\n");

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            // The ToString() Method - Converts an object to its string representation so it can be displayed
            Console.WriteLine("\n\t The ToString() Method...\n");

            Cars car3 = new Cars("Chevy", "Corvette", 2022, "Blue");

            Console.WriteLine(car3.ToString()); // This will not display properly

            // POLYMORPHISM - Word that means to have many forms
            //              Objects can be identified by more than one type
            //              Ex: A Dog is also a: Canine, Animal, Organism
            Console.WriteLine("\n\t Polymorphism...\n");

            Car car5 = new Car(); // Don't worry about the 0, we'll talk about it later
            Bicycle bike = new Bicycle();
            Boat boat2 = new Boat();

            //Car[] vehicles = { car5, bike, boat2 }; // This would not ordinarily work
            Vehicle[] vehicles = { car5, bike, boat2 }; // This works because all objects are considered Vehicles

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            //Interfaces - defines a "contract" that all the classes inheriting from it should follow 
            //          An interface declares "what a class should have"
            //          An inheriting class defines "how it should do it"
            //          Benefit = More security + multiple inheritance + "plug and play"
            Console.WriteLine("\n\t Interfaces...\n");

            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();

            // Lists - An array, but you can change its size
            Console.WriteLine("\n\t Lists...\n");

            List<String> food = new List<String>();
            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("HotDog");
            food.Add("Hamburger");

            Console.WriteLine(food[0]);

            food.Remove("Pizza");
            Console.WriteLine(food[0]);

            food.Insert(1, "Sushi");
            Console.WriteLine(food.Count);

            Console.WriteLine(food.IndexOf("HotDog"));

            Console.WriteLine(food.LastIndexOf("Hamburger"));

            Console.WriteLine(food.Contains("Sushi")); // Returns a bool

            food.Sort(); // Sorts Alphabetically
            food.Reverse(); // Sorts in Reverse order
            string[] foodarrray = food.ToArray();

            food.Clear(); // Clears the list

            //LISTS OF OBJECTS
            Console.WriteLine("\n\t Lists of Objects...\n");

            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Alex");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Player playerz in players)
            {
                Console.WriteLine(playerz.userName);
            }

            //GETTERS AND SETTERS - add security to fields by encapsulation 
            //                      They're assessors found within properties 
            //properties - combine aspects of both field and methods (share name with a field)
            //Get accessors - used to return the property value
            //Set accessors - used to assign a new value
            //value keyword - defines the value being assigned by the set (parameter)

            Car car7 = new Car(400);

            //car.realSpeed = 100000000; This wouldn't work since realSpeed is a PRIVATE INT
            car7.RealSpeed = 100000000; // This attempts to set the int's value, but the property is called instead, and doesn't allow
                                        // it
            Console.WriteLine(car7.RealSpeed); // This calls the property instead of the int

            //ENUMS - Special "class" that contains integer constants
            Console.WriteLine("\n\t Enums...\n");

            Console.WriteLine(Planets.Pluto + "is a Planet"); //Returns the name, not the Integer
            Console.WriteLine(Planets.Mercury + $"is a Planet #{(int)Planets.Mercury}");

            String planetName = PlanetRadius.Earth.ToString();
            Console.WriteLine(planetName);

            int radius = (int)PlanetRadius.Earth;
            Console.WriteLine($"Radius of {planetName} is {radius}");

            //Generics - "not specific to a particular data type
            //          add <T> to: classes, methods, fields ect.
            //          allows for code reusaboility for different data types

            Console.WriteLine("\n\t Generics...\n");

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };



            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            //Due to Generics, the world "Thing", is now taken as a Generic variable, open to use in many things

            //MULTITHREADING
            // Thread - an execution path of a program
            //          We can use multiple threads to perform
            //          different tasks of our program at the same time
            //          Current thread running is the Main Thread

            Console.WriteLine("\n\t Multi-Threading...\n");

            Thread mainThread = Thread.CurrentThread; // Will assign the currently running thread, to a local variable
            mainThread.Name = "Main Thread";
            // Console.WriteLine(mainThread);

            Thread thread1 = new Thread(() => CountDown("Timer One")); // This must be done for any method that requires parameters
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();

            Console.WriteLine($"{mainThread.Name} is complete!");


            Console.ReadKey();

        }

        // Define a method to sing Happy Birthday
        static void singHappyBirthday()
        {
            Console.WriteLine("Happy Birthday To You");
            Console.WriteLine("Happy Birthday To You");
            Console.WriteLine("Happy Birthday To You");
            Console.WriteLine();
        }

        // Define a method to sing Happy Birthday to a specific person
        static void singHappyBirthdayToYou(string nameOfPerson) // To use a variable declared outside of the method, use the parameter with type and name of variable
        {
            Console.WriteLine("Happy Birthday To You");
            Console.WriteLine("Happy Birthday To You");
            Console.WriteLine("Happy Birthday To " + nameOfPerson);
            Console.WriteLine();
        }

        static double Multiply(double a, double b) // It doesn't matter what you name the variables in the parameter, as long as they are in the right order when called
        {
            double cEight = a * b;

            return cEight;// This will now make the method "static double Multiply(double a, double b)" return the double of var 'cEight'. Which is why it says double
            // instead of void. The method must be called what it returns
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }

        public static void ChangeColor(Cars car, string color) // In order to create this method, you must name the kind of object (Cars)
                                                               // then name it. then declare what you want changed. In this case, the color
        {
            car.color = color;
        }

        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
        }

        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds!");
                Thread.Sleep(1000); // Amount of Miliseconds for this thread to wait in between intervals of counting
            }
            Console.WriteLine("Timer #1 is complete");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds!");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete");
        }

    }

    class Human
    {
        public string name;
        public int age;

        public Human() // This is simply for the functionally of the 'object' demonstrations
        {

        }

        public Human(string name, int age) // This is out constructor, which we are able to assign variables and values to
        {
            this.name = name;
            this.age = age;
        }
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }

    class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;


        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }

    abstract class Vehicle // Using the word abstract, will now stop the creation of any vehicle objects, in other words, a class used 
                           // only for the storage of methods and variables.
    {
        public int speed = 0;

        public virtual void Go()
        {
            Console.WriteLine("This vehicle is moving");
        }


    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
        private int realSpeed;
        public override void Go()
        {
            Console.WriteLine("The Car is moving");
        }

        public Car()
        {

        }
        public Car([Optional] int realSpeed) // This is later, I was kinda inconsiderate when it comes to naming, sooooo yeah. This is why the 0
                                             // existed before lmao

        // Oh also, you can put Optional within [], in order for one or morer variables to be set
        // to their default value, and make it less of a hassle writing out constructors
        {
            RealSpeed = realSpeed;
        }

        public int RealSpeed // This is a property btw
        {
            get { return realSpeed; } // Reads the value
            set                        // Writes the new value if value is above a threshold
            {
                if (value > 500)
                {
                    realSpeed = 500;
                }
                else
                {
                    realSpeed = value;
                }
            }
        }

    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;

        public override void Go()
        {
            Console.WriteLine("The bike is moving");
        }

    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;

        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }

    }

    class Cars
    {
        public String model;
        public String color;
        int year;
        String make;


        public Cars(String model)
        {
            this.model = model;
        }
        public Cars(String model, String color)
        {
            this.model = model;
            this.color = color;
        }

        public Cars(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public override string ToString()
        {
            String message = $"This is a {make} {model}";
            return message;
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The Animal goes brrrrrrr");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The Dog goes woof");
        }
    }
    class Cat : Animal
    {

    }

    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The Rabbit runs away");
        }
    }
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The Hawk is searching for food");
        }

    }
    class Fish : IPredator, IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The Fish swims away");
        }
        public void Hunt()
        {
            Console.WriteLine("The Fish is searching for smaller fish");
        }
    }
    class Player
    {
        public String userName;

        public Player(string userName)
        {
            this.userName = userName;
        }
    }
    class Carz
    {
        string model;

        public string Model // This is a property btw
        {
            get; // This is an ez way to implement the get and set from earlier
            set;
        }
        public Carz(string model)
        {
            this.Model = model;
        }

    }

    enum Planets // By default, each name is the order in which it is in. (Mercury = 0, Venus = 1, ect...)
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}

