using System;
using System.Runtime.CompilerServices;

namespace HelloWorld

//-------HelloWorld-------------------------------------------------------------------------------------------------
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            Console.WriteLine("This is how we start this coding thing!");
//            Console.WriteLine(42);
//            Console.WriteLine(1.23);
//            Console.WriteLine(2 + 3);
//            Console.WriteLine("At first learning code was like playing with two magnets with the sides that dont magnetize but stay appart. " +
//                "\nThat energy you feel when you try to push them together was how it felt to try and push this new way of thinking (coding info) into my brain. " +
//                "\nI cant believe I finally understood.");
//            Console.WriteLine("Goodbye World!");

//            Console.ReadLine();
//        }
//    }
//}
//-------- PRIMITIVES ----------------------------------------------------------------------------------------------
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double doublevalue = 2.16440330489723961032;
//            console.writeline(doublevalue);

//            float floatvalue = 2.16440330489723961032f;
//            console.writeline(floatvalue);

//            console.readline();
//        }
//    }
//}
//-------- STRINGS -------------------------------------------------------------------------------------------------
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int numberOfSuits = 4;
//            Console.WriteLine("I have " + numberOfSuits + " suits.");
//            ________________________________________

//            int numberOfMaids = 7;
//            int numberOfMops = 5;

//            if (numberOfMaids == numberOfMops)
//            {
//                Console.WriteLine("They might get it clear in half a year.");
//            }

//            String shoeDescription = "Their shoes were clean and neat";

//            if (shoeDescription.Equals("Their shoes were clean and neat"))
//            {
//                Console.WriteLine("This is odd, because, you know,");
//                Console.WriteLine("They hadn't any feet.");
//            }
//            _________________________________________

//            string myGreeting = "Helllo";
//            Console.WriteLine(myGreeting.ToUpper());
//            Console.WriteLine(myGreeting.ToLower());
//            Console.WriteLine(myGreeting);

//            Console.WriteLine("Enter a color, please.");
//            string response = Console.ReadLine();

//            if (response.ToLower().Equals("pink"))
//            {
//                Console.WriteLine("Pink roses are better than red roses.");
//            }
//            ______________________________________________

//            string palindrome = "A dog, a panic, in a pagoda";
//            string whatsPalindrome = "I dont know what is the meaning of the first string";
//            int palindromeLength = palindrome.Length;
//            Console.WriteLine($"{palindrome} has {palindromeLength} characters.");
//            Console.WriteLine($"{whatsPalindrome} has {whatsPalindrome.Length} characters.");

//            if (palindrome.Length < whatsPalindrome.Length)
//            {
//                Console.WriteLine($"{palindrome} has {whatsPalindrome.Length - palindrome.Length} less characters than {whatsPalindrome}");
//            }
//            if (whatsPalindrome.Length < palindrome.Length)
//            {
//                Console.WriteLine($"{palindrome} has {whatsPalindrome.Length - palindrome.Length} more characters than {whatsPalindrome}");
//            }
//            _________________________________________________

//            Console.WriteLine("Escape: \"This is an example of escaping\".");

//            Console.WriteLine("Escaping, the use of special characters in strings. \nLike this new line");
//            Console.WriteLine("\tAnd like this paragraph indent");
//        }
//    }
//}
//-------CODE WORKOUT-------------------------------------------------------------------------------------------------
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------First/Last Name
            Console.WriteLine("Hello, \nWhat is your first name?");
            string firstName = Console.ReadLine();
            //int firstNameLength = firstName.Length;

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            //int lastNameLength = lastName.Length;

            Console.WriteLine($"\nWelcome {firstName} {lastName}!");
            //-------Length
            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine($"Super cool fact, your first name is shorter than your last name. wow\n");
            }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine($"Super cool fact, your first name is longer than your last name. wow\n");
            }
            else if (firstName.Length == lastName.Length)
            {
                Console.WriteLine($"Super cool fact, your first name is the same length as your last name. wow\n");
            };
            //-------Riddle
            Console.WriteLine($"\n{firstName}, solve my riddle!\n " +
                $"\t\nI have keys, but no locks. " +
                $"\t\nI have a space but no room. " +
                $"\t\nYou can enter, but can't go outside. " +
                $"\t\nWhat am I?");

            string answer = Console.ReadLine();
            //--------Answer
            if (answer.ToLower().Equals("keyboard"))
            {
                Console.WriteLine("That Is Correct!");
            }
            else
            {
                Console.WriteLine("...I'm board, try again");
            };
            //-------Equal or Not
            Console.WriteLine($"\n{firstName}, please enter a word...");
            string difficultWord = Console.ReadLine();

            Console.WriteLine($"{firstName}, now another word...");
            string anotherWord = Console.ReadLine();

            if (difficultWord.ToLower().Equals(anotherWord.ToLower()))
            {
                Console.WriteLine("You have entered the same word twice");
            }
            else
            {
                Console.WriteLine("The words you have provided are not the same");
            }
            //--------Username
            Console.WriteLine("\nPlease create a Username **must be at least 8 characters long and contain word 'code'**\n");
            string username = Console.ReadLine();
            if (username.Length >= 8 && username.ToLower().Contains("code"))
            {
                Console.WriteLine($" Welcome {username}!");
            }
            else
            {
                Console.WriteLine("Please provide a username with valid credentials");
            };
            //--------Password
            Console.WriteLine("\nPlease create a Password");
            string password = Console.ReadLine();

            Console.WriteLine("Please verify to continue");
            string verifyPassword = Console.ReadLine();

            if (password.Equals(verifyPassword))
            {
                Console.WriteLine("\nTHOU SHALL PASS, FOR THOU CREATED A VALID PASSWORD");
            }
            else
            {
                Console.WriteLine("\nPASSWORD DOES NOT MATCH, PLEASE TRY AGAIN");
            };
        }
    }
}