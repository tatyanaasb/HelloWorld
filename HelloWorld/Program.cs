using System;
using System.Runtime.CompilerServices;

namespace HelloWorld

//------- HelloWorld -------------------------------------------------------------------------------------------------
{
    class Program
{
        static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //    Console.WriteLine("This is how we start this coding thing!");
        //    Console.WriteLine(42);
        //    Console.WriteLine(1.23);
        //    Console.WriteLine(2 + 3);
        //    Console.WriteLine("At first learning code was like playing with two magnets with the sides that dont magnetize but stay appart. " +
        //        "\nThat energy you feel when you try to push them together was how it felt to try and push this new way of thinking (coding info) into my brain. " +
        //        "\nI cant believe I finally understood.");
        //    Console.WriteLine("Goodbye World!");

        //    Console.ReadLine();
        //}
        //-------- PRIMITIVES ----------------------------------------------------------------------------------------------
        //{
        //    double doubleValue = 2.16440330489723961032;
        //    Console.Writeline(doubleValue);

        //    float floatValue = 2.16440330489723961032f;
        //    Console.Writeline(floatValue);

        //    Console.Readline();
        //}
        //-------- STRINGS -------------------------------------------------------------------------------------------------
        //{
        //    int numberOfSuits = 4;
        //    Console.WriteLine("I have " + numberOfSuits + " suits.");
        //    ________________________________________

        //    int numberOfMaids = 7;
        //    int numberOfMops = 5;

        //    if (numberOfMaids == numberOfMops)
        //    {
        //        Console.WriteLine("They might get it clear in half a year.");
        //    };

        //    string shoeDescription = "Their shoes were clean and neat";

        //    if (shoeDescription.Equals("Their shoes were clean and neat"))
        //    {
        //        Console.WriteLine("This is odd, because, you know,");
        //        Console.WriteLine("They hadn't any feet.");
        //    };
        //}
        //    _________________________________________
        //{
        //    string myGreeting = "Helllo";
        //    Console.WriteLine(myGreeting.ToUpper());
        //    Console.WriteLine(myGreeting.ToLower());
        //    Console.WriteLine(myGreeting);

        //    Console.WriteLine("Enter a color, please.");
        //    string response = Console.ReadLine();

        //    if (response.ToLower().Equals("pink"))
        //    Console.WriteLine("Pink roses are better than red roses.");
        //}
        //    ______________________________________________
        //{
        //    string palindrome = "A dog, a panic, in a pagoda";
        //    string whatsPalindrome = "I dont know what is the meaning of the first string";
        //    int palindromeLength = palindrome.Length;
        //    Console.WriteLine($"{palindrome} has {palindromeLength} characters.");
        //    Console.WriteLine($"{whatsPalindrome} has {whatsPalindrome.Length} characters.");

        //    if (palindrome.Length < whatsPalindrome.Length)
        //    {
        //        Console.WriteLine($"{palindrome} has {whatsPalindrome.Length - palindrome.Length} less characters than {whatsPalindrome}");
        //    }
        //    if (whatsPalindrome.Length < palindrome.Length)
        //    {
        //        Console.WriteLine($"{palindrome} has {whatsPalindrome.Length - palindrome.Length} more characters than {whatsPalindrome}");
        //    };
        //    _________________________________________________
        //    Console.WriteLine("Escape: \"This is an example of escaping\".");

        //    Console.WriteLine("Escaping, the use of special characters in strings. \nLike this new line");
        //    Console.WriteLine("\tAnd like this paragraph indent");
        //}

        //------- CODE WORKOUT -------------------------------------------------------------------------------------------------
        //{
        //    //-------First/Last Name-------
        //    Console.WriteLine("Hello, \nWhat is your first name?");
        //    string firstName = Console.ReadLine();
        //    //int firstNameLength = firstName.Length;

        //    Console.WriteLine("What is your last name?");
        //    string lastName = Console.ReadLine();
        //    //int lastNameLength = lastName.Length;

        //    Console.WriteLine($"\nWelcome {firstName} {lastName}!");
        //    //-------Length-------
        //    if (firstName.Length < lastName.Length)
        //    {
        //        Console.WriteLine($"Super cool fact, your first name is shorter than your last name. wow\n");
        //    }
        //    else if (firstName.Length > lastName.Length)
        //    {
        //        Console.WriteLine($"Super cool fact, your first name is longer than your last name. wow\n");
        //    }
        //    else if (firstName.Length == lastName.Length)
        //    {
        //        Console.WriteLine($"Super cool fact, your first name is the same length as your last name. wow\n");
        //    };
        //    //-------Riddle--------
        //    Console.WriteLine($"\n{firstName}, solve my riddle!\n " +
        //        $"\t\nI have keys, but no locks. " +
        //        $"\t\nI have a space but no room. " +
        //        $"\t\nYou can enter, but can't go outside. " +
        //        $"\t\nWhat am I?");

        //    string answer = Console.ReadLine();
        //    //--------Answer--------
        //    if (answer.ToLower().Equals("keyboard"))
        //    {
        //        Console.WriteLine("That Is Correct!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("...I'm board, try again");
        //    };
        //    //-------Equal or Not-------
        //    Console.WriteLine($"\n{firstName}, please enter a word...");
        //    string difficultWord = Console.ReadLine();

        //    Console.WriteLine($"{firstName}, now another word...");
        //    string anotherWord = Console.ReadLine();

        //    if (difficultWord.ToLower().Equals(anotherWord.ToLower()))
        //    {
        //        Console.WriteLine("You have entered the same word twice");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The words you have provided are not the same");
        //    }
        //    //--------Username-------
        //    Console.WriteLine("\nPlease create a Username **must be at least 8 characters long and contain word 'code'**\n");
        //    string username = Console.ReadLine();
        //    if (username.Length >= 8 && username.ToLower().Contains("code"))
        //    {
        //        Console.WriteLine($" Welcome {username}!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please provide a username with valid credentials");
        //    };

        //    //--------Password-------
        //    Console.WriteLine("\nPlease create a Password");
        //    string password = Console.ReadLine();

        //    Console.WriteLine("Please verify to continue");
        //    string verifyPassword = Console.ReadLine();

        //    if (password.Equals(verifyPassword))
        //    {
        //        Console.WriteLine("\nTHOU SHALL PASS, FOR THOU CREATED A VALID PASSWORD");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nPASSWORD DOES NOT MATCH, PLEASE TRY AGAIN");
        //    };
        //}
        //--------- OPERATORS & EXPRESSION ----mini exercises-------------------------------------------------------------------------------
        //{
        //    //--------Muffin Recipe-------
        //    int flowerExpected = 7;
        //    int flowerIn = 2;
        //    Console.WriteLine(flowerExpected - flowerIn + " cups of flower to fulfil the recipe");

        //    //--------Restaurant Bill-------
        //    int person = 4;
        //    int totalPerPerson = 13;
        //    Console.WriteLine("$" + (person* totalPerPerson) + " is the total bill");

        //    //-------Diapers-------
        //    int diaperPackageCost = 8;
        //    int diaperBudget = 40;
        //    Console.WriteLine("Can buy " + (diaperBudget / diaperPackageCost) + " diaper packages");

        //    //-------Money Received-------
        //    int totalAmount = 41;
        //    int prevAmount = 29;
        //    Console.WriteLine("$" + (totalAmount - prevAmount) + " received");

        //    //-------Running Miles-------
        //    int juliasMiles = 47;
        //    int mileDifference = 30;
        //    Console.WriteLine("Prinav ran " + (juliasMiles - mileDifference) + " miles");

        //    //-------Envelopes-------
        //    int oneBoxCost = 3;
        //    int envelopeBudget = 12;
        //    Console.WriteLine(envelopeBudget / oneBoxCost + " boxes of envelopes");

        //    //-------Money Had-------
        //    double saladCost = 5.12;
        //    double afterSaladTotal = 27.10;
        //    Console.WriteLine("$" + (saladCost + afterSaladTotal) + " before buying the salad");

        //    //-------Students-------
        //    int totalStudents = 331;
        //    int totalBuses = 6;
        //    int totalByCar = 7;
        //    Console.WriteLine(((totalStudents - totalByCar) / totalBuses) + " students traveled in each bus");

        //    //-------Pencil Cost-------
        //    int totalPencils = 10;
        //    int pencilBudget = 24;
        //    Console.WriteLine("Each pencil cost $" + pencilBudget / totalPencils);

        //    //-------Sum of 3 Consecutive is 72-------
        //    int sumNum = ((72 - 3) / 3);
        //    Console.WriteLine($"The sum of {sumNum}, {sumNum+1} & {sumNum+2} is 72");

        //    //-------Sum of 3 Even Consecutive is 48-------
        //    int evenSumNum = ((48 - 6) / 3);
        //    Console.WriteLine($"The sum of {evenSumNum}, {evenSumNum + 2} & {evenSumNum + 4} is 48. {evenSumNum} is the smallest");

        //    //-------Boxes-------
        //    int purchasedBoxes = 7;
        //    int postFireBoxes = 22;
        //    Console.WriteLine("She started with " + (postFireBoxes* 2 - purchasedBoxes) + " boxes");
        //}
        //------- CONDITIONALS --------------------------------------------------------------------------------------------------------------------------
        //{
        //    int age = 42;
        //    if (age >= 16)
        //    {
        //        Console.WriteLine($"You are {age}, so you are legal to drive");
        //    };
        //    ___________________________
        //    int hoursOfSleep = 12;
        //    if (hoursOfSleep >= 8)
        //    {
        //        Console.WriteLine("You are likely to feel more rested.");
        //    };
        //    if (hoursOfSleep == 12)
        //    {
        //        Console.WriteLine("He is deffinitely well rested!");
        //    };
        //    ___________________________
        //    int heightInInches = 73;
        //    if (heightInInches >= 60)
        //    {
        //        Console.WriteLine("You are tall enough to ride");
        //    }
        //    else
        //    {
        //        Console.WriteLine("I'm sorry, you are not tall enough to ride");
        //    };
        //    ___________________________
        //    int heightInInches = 42;
        //    if (heightInInches >= 60)
        //    {
        //        Console.WriteLine("You are tall enough to ride.");
        //    }
        //    else if (heightInInches >= 30)
        //    {
        //        Console.WriteLine("Try the teacups. They look fun.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("I'm sorry, you are not tall enough to ride");
        //    };
        //    _____SWITCH CASE_________________________
        //    string ageGroup = "adult";
        //    switch (ageGroup)
        //    {
        //        case "adult":
        //            Console.WriteLine("You can ride the rollercoaster!");
        //            break;
        //        case "youngster":
        //            Console.WriteLine("The teacups are fun.");
        //            break;
        //        default:
        //            Console.WriteLine("Oh, you must be a toddler. Toddle on!");
        //            break;
        //    }
        //}
        ------- BRANCHING STATEMENTS ---------------------------------------------------------------------------------------------------------------
        {
            //-------Break Statement-------
            while (true)
            {
                Console.WriteLine("What is your favorite color?");
                string favoriteColor = Console.ReadLine();

                if (favoriteColor == "Blue")
                {
                    Console.WriteLine("Auuuuuuuugh!");
                    Console.WriteLine("You're just making Monty Python references.");
                    Console.WriteLine("Get out!");
                    break;
                }
    Console.WriteLine($"Your favorite color is {favoriteColor.ToLower()}");
            }
        }
        {
            //--------Continue Statement-------
            for (int count = 1; count <= 10; count++)
            {
                if (count % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine("Count is " + count);
            }
        }
        //-------Return Statement--------
        //written from instructions, breaks code because its supposed to act as an example of RETURN statement
        //not functional example to run and see clear results!
        {
            {
                Console.WriteLine("Message for 42: " + chooseMessage(42));
                Console.WriteLine("Message for 23: " + chooseMessage(23));
            }
            /*public*/ static string chooseMessage(int input)
{
    if (input % 2 == 0)
    {
        return "Even Steven!";
    }
    return "You're odd!";
}
        }
        //--------Nested Loops--------
        {
            for (int hours = 1; hours< 3; hours++)
            {
                for (int minutes = 0; minutes< 60; minutes += 5)
                {
                    Console.WriteLine($"The time is {hours:00}:{minutes:00}");
                }
            }
        }

    }
}

