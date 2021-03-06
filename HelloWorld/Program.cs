﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading;

namespace HelloWorld

////------- HelloWorld -------------------------------------------------------------------------------------------------
{
    class Program
    {
        static void Main(string[] args)
        //{//<----- START
        //    //Comment out AND Uncomment areas with brackets specifying "<--START" & "<--FINISH" to not break code while running.
        //    //Code is writen this way only for learning purpose of specific subject while having everything in the same place. 
        //}//<----- FINISH


        //{//<----- START
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
        //}//<---- FINISH


        ////-------- PRIMITIVES ----------------------------------------------------------------------------------------------

        //{//<----- START
        //    double doubleValue = 2.16440330489723961032;
        //    Console.Writeline(doubleValue);

        //    float floatValue = 2.16440330489723961032f;
        //    Console.Writeline(floatValue);

        //    Console.Readline();
        //}//<----- FINISH


        ////-------- STRINGS -------------------------------------------------------------------------------------------------

        //{//<----- START
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
        //}//<----- FINISH


        //    _________________________________________

        //{//<----- START
        //    string myGreeting = "Helllo";
        //    Console.WriteLine(myGreeting.ToUpper());
        //    Console.WriteLine(myGreeting.ToLower());
        //    Console.WriteLine(myGreeting);

        //    Console.WriteLine("Enter a color, please.");
        //    string response = Console.ReadLine();

        //    if (response.ToLower().Equals("pink"))
        //    Console.WriteLine("Pink roses are better than red roses.");
        //}//<----- FINISH


        //    ______________________________________________

        //{//<----- START
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
        //    Console.WriteLine("Type \"menu\" to list options.<--activates quotations w/o disrupting code");
        //}//<----- FINISH


        ////------- CODE WORKOUT -------------------------------------------------------------------------------------------------

        //{//<----- START
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
        //}//<----- FINISH



        ////--------- OPERATORS & EXPRESSION ----mini exercises-------------------------------------------------------------------------------

        //{//<----- START
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
        //}//<----- FINISH


        ////------- CONDITIONALS --------------------------------------------------------------------------------------------------------------------------

        //{//<----- START
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
        //}//<----- FINISH


        ////------- BRANCHING STATEMENTS ---------------------------------------------------------------------------------------------------------------

        //{//<----- START
        //    //-------Break Statement-------
        //    while (true)
        //    {
        //        Console.WriteLine("What is your favorite color?");
        //        string favoriteColor = Console.ReadLine();

        //        if (favoriteColor == "Blue")
        //        {
        //            Console.WriteLine("Auuuuuuuugh!");
        //            Console.WriteLine("You're just making Monty Python references.");
        //            Console.WriteLine("Get out!");
        //            break;
        //        }
        //        Console.WriteLine($"Your favorite color is {favoriteColor.ToLower()}");
        //    }
        //}//<----- FINISH

        //{//<----- START
        //    //--------Continue Statement-------
        //    for (int count = 1; count <= 10; count++)
        //    {
        //        if (count % 3 == 0)
        //        {
        //            continue;
        //        }
        //        Console.WriteLine("Count is " + count);
        //    }
        //}//<----- FINISH

        //{//<----- START
        //    //-------Return Statement--------
        //      //written from instructions, breaks code because its supposed to act as an example of RETURN statement
        //      //not functional example to run and see clear results!
        //    {
        //        Console.WriteLine("Message for 42: " + chooseMessage(42));
        //        Console.WriteLine("Message for 23: " + chooseMessage(23));
        //    }
        //    /*public*/ static string chooseMessage(int input)
        //    {
        //        if (input % 2 == 0)
        //        {
        //            return "Even Steven!";
        //        }
        //        return "You're odd!";
        //    }
        //}//<----- FINISH

        //{//<----- START
        //    //--------Nested Loops--------
        //    for (int hours = 1; hours < 3; hours++)
        //    {
        //        for (int minutes = 0; minutes < 60; minutes += 5)
        //        {
        //            Console.WriteLine($"The time is {hours:00}:{minutes:00}");
        //        }
        //    }
        //}//<----- FINISH


        ////-------- WHILE LOOPS ------------------------------------------------------------------------------------------------------------------------

        //{//<----- START
        //    //-------While-------
        //    int count = 1;
        //    while (count < 11)
        //    {
        //        Console.WriteLine("The count is " + count);
        //        count++;
        //    }

        //    //-------DO While Loop-------
        //    string poridgeTemperature;
        //    do
        //    {
        //        Console.WriteLine("Please specify porridge temperature.");
        //        Console.WriteLine("Type \"help\" to list options.");
        //        poridgeTemperature = Console.ReadLine();
        //        if (poridgeTemperature.Equals("help"))
        //        {
        //            Console.WriteLine("Options: too hot, too cold, just right");
        //        }
        //    } while (poridgeTemperature.Equals("help"));

        //    //-------Infinite Loop-------
        //    while (true)
        //    {
        //        Console.WriteLine("I will run forever");
        //        Console.WriteLine("Or until you figure out how to stop me!");
        //    }
        //}//<----- FINISH


        ////------- PRACTICE --------------------------------------------------------------------------------------------------------------------------------

        //{//<----- START
        //    //-------Enter a Message--------
        //    string userMessage;
        //    int index = 1;

        ////    //---One Way----Keep commented out to see other ways
        ////    do
        ////    {
        ////        Console.WriteLine("Please enter a message");
        ////        Console.WriteLine("Exit by typing \"gb\"");
        ////        userMessage = Console.ReadLine();
        ////        if (userMessage == "gb")
        ////        {
        ////            break;
        ////        }
        ////    } while (true);

        ////    //----Another Complicated Way----Keep commented out to see other ways
        ////    //learning diferent ways of doing the same thing----
        ////    do
        ////    {
        ////        Console.WriteLine("Please enter a message");
        ////        Console.WriteLine("Exit by typing \"gb\"");
        ////        if (userMessage == "gb")
        ////        {
        ////            break;
        ////        }
        ////        userMessage = Console.ReadLine();
        ////        string[] message = { userMessage };
        ////        for (int i = 0; i < message.Length; i++)
        ////        {
        ////            Console.WriteLine(message[i]);
        ////        }
        ////    } while (true);

        //    //---- *BEST* Way?----
        //    do
        //    {
        //        Console.WriteLine("Please enter a message\n");
        //        userMessage = Console.ReadLine();
        //        Console.WriteLine("\n" + index + " " + userMessage);
        //        index++;
        //    } while (index <= 5);
        //}//<----- FINISH


        //{//<----- START
        //    //-------Pick a Number-------
        //    string numberGuess = "";
        //    string myNumber = "2020";
        //    int guessCount = 0;
        //    int guessLimit = 3;
        //    bool outOfGuesses = false;
        //    do
        //    {
        //        if (guessCount < guessLimit)
        //        {
        //            Console.WriteLine("\nCan you guess the number I picked");
        //            numberGuess = Console.ReadLine();
        //            guessCount++;
        //            if (numberGuess == myNumber)
        //            {
        //                Console.WriteLine("You got it!");
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Try again...\n");
        //            }
        //        }
        //        else
        //        {
        //            outOfGuesses = true;
        //        }
        //    } while (numberGuess != myNumber && !outOfGuesses);
        //    if (outOfGuesses)
        //    {
        //        Console.WriteLine("You've exhausted the maximum guesses, come back later.");
        //    }
        //}//<----- FINISH


        //{//<----- START
        //    //--------Atm PIN--------
        //    string atmPinEntry = "";
        //    string atmPIN = "0987";
        //    int pinEntryCount = 0;
        //    int pinEntryLimit = 3;
        //    bool outOfPinEntries = false;

        //    while (atmPinEntry != atmPIN && !outOfPinEntries)
        //    {
        //        if (pinEntryCount<pinEntryLimit)
        //        {
        //            Console.WriteLine("\nPlease enter a pin");
        //            atmPinEntry = Console.ReadLine();
        //            pinEntryCount++;
        //            if (atmPinEntry == atmPIN)
        //            {
        //                Console.WriteLine("\nWelcome, congrats on entering your PIN correctly!\n");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Try again...\n");
        //            }
        //        }
        //        else
        //        {
        //            outOfPinEntries = true;
        //            Console.WriteLine("\nSorry, you only get 3 tries to enter a correct PIN. Come back later\n");
        //        }
        //    }        
        //}//<----- FINISH


        ////-------- ARRAYS ------------------------------------------------------------------------------------------------------------------------------

        //{//<----- START
        //    //Cups INT
        //    int[] cupValues = new int[4];
        //    cupValues[0] = 42;
        //    cupValues[1] = 86;
        //    cupValues[2] = 31;
        //    cupValues[3] = 8;
        //    Console.WriteLine(cupValues[0]);
        //    Console.WriteLine(cupValues[1]);
        //    Console.WriteLine(cupValues[2]);
        //    Console.WriteLine(cupValues[3]);
        //    Console.WriteLine();

        //    //.Length
        //    int numberOfCups = cupValues.Length;
        //    Console.WriteLine(numberOfCups);
        //    cupValues = new int[2];
        //    Console.WriteLine(cupValues.Length);
        //    Console.WriteLine();

        //    //Words STRING
        //    string[] randomWords = { "Assignment operators", "Augmented reality", "Autonomous", "Conditional statements" };
        //    Console.WriteLine(randomWords[0]);
        //    Console.WriteLine(randomWords[1]);
        //    Console.WriteLine(randomWords[2]);
        //    Console.WriteLine(randomWords[3]);
        //    Console.WriteLine();

        //    //Names
        //    string[] names3Time = { "August", "June", "May" };
        //    Console.WriteLine(names3Time[0]);
        //    Console.WriteLine(names3Time[1]);
        //    Console.WriteLine(names3Time[2]);
        //    Console.WriteLine();

        //    //GPA
        //    string[] gpa5Time = { "3.0", "2.8", "3.2", "4.0", "2.9" };
        //    Console.WriteLine(gpa5Time[0]);
        //    Console.WriteLine(gpa5Time[1]);
        //    Console.WriteLine(gpa5Time[2]);
        //    Console.WriteLine(gpa5Time[3]);
        //    Console.WriteLine(gpa5Time[4]);
        //    Console.WriteLine();

        //    //Vacation Spots
        //    string[] vacationSpots4Time = { "Your", "Top 4", "Vacation", "Spots" };
        //    Console.WriteLine(vacationSpots4Time[1]);
        //    Console.WriteLine(vacationSpots4Time[0]);
        //    Console.WriteLine(vacationSpots4Time[3]);
        //    Console.WriteLine(vacationSpots4Time[2]);
        //    Console.WriteLine();

        //    //Last Name 
        //    string[] lastNameLength = { "B", "A", "I", "L", "E", "Y" };
        //    Console.WriteLine(lastNameLength.Length);
        //    Console.WriteLine();

        //    //.Split
        //    string source = "this, that, the other";
        //    string[] elements = source.Split(", ");
        //    Console.WriteLine(elements[0]);
        //    Console.WriteLine(elements[1]);
        //    Console.WriteLine(elements[2]);
        //    Console.WriteLine(elements.Length);
        //    Console.WriteLine();

        //    string sourceLN = "B, A, I, L, E, Y";
        //    string[] elementsLN = sourceLN.Split(", ");
        //    Console.WriteLine(elementsLN[0]);
        //    Console.WriteLine(elementsLN[1]);
        //    Console.WriteLine(elementsLN[2]);
        //    Console.WriteLine(elementsLN[3]);
        //    Console.WriteLine(elementsLN[4]);
        //    Console.WriteLine(elementsLN[5]);
        //    Console.WriteLine();

        //    //.ToCharArray()
        //    string myName = "Tatyana";
        //    char[] letters = myName.ToCharArray();
        //    Console.WriteLine("First name initial is " + letters[0]);

        //    //.IndexOf
        //    Console.WriteLine(myName.IndexOf('T'));
        //    Console.WriteLine(myName.ToCharArray(4, 1));
        //    Console.WriteLine("name".IndexOf('m'));
        //    Console.WriteLine("argument, compiler, computational thinking, iteration".IndexOf("iteration"));
        //    Console.WriteLine();

        //    //For Index of - Tool
        //    string[] myTools = { "hammer", "shovel", "wrench" };
        //    for (int index = 0; index < myTools.Length; index++)
        //    {
        //        if (myTools[index].Equals("shovel"))
        //        {
        //            Console.WriteLine("Shovel is element " + index);
        //            Console.WriteLine();
        //        }
        //    }

        //    //For Index of - Item
        //    string[] nameOfItems = { "Mouse", "Laptop", "Keyboard", "Headphones", "Phone" };
        //    for (int itemIndex = 0; itemIndex < nameOfItems.Length; itemIndex++)
        //    {
        //        if (nameOfItems[itemIndex].Equals("Phone"))
        //        {
        //            Console.WriteLine("The index of Phone is " + itemIndex);
        //            Console.WriteLine();
        //        }
        //    }

        //    //Names next to me
        //    string[] name4Time = { "Mouse", "Keyboard", "Headphones", "Phone" };
        //    Console.WriteLine(name4Time[0].ToCharArray(0, 1));
        //    Console.WriteLine(name4Time[1].ToCharArray(0, 1));
        //    Console.WriteLine(name4Time[2].ToCharArray(0, 1));
        //    Console.WriteLine(name4Time[3].ToCharArray(0, 1));
        //    Console.WriteLine();

        //    int indexRLCount = 1;
        //    do
        //    {
        //        Console.WriteLine("Please enter a name of a peer next to you");
        //        string nameAnswer = Console.ReadLine();
        //        char[] lettersAnswer = nameAnswer.ToCharArray();
        //        Console.WriteLine("First name initial is " + lettersAnswer[0]);
        //        Console.WriteLine();
        //        indexRLCount++;
        //    } while (indexRLCount <= 4);

        //    //Word contains a letter
        //    Console.WriteLine("Please enter a word");
        //    string wordAnswerContainer = Console.ReadLine();
        //    Console.WriteLine();
        //    Console.WriteLine("Please enter a letter");
        //    string letterAnswerContainer = Console.ReadLine();
        //    Console.WriteLine();
        //    if (wordAnswerContainer.Contains(letterAnswerContainer))
        //    {
        //        Console.WriteLine("Yep, it's got one of those");
        //        Console.WriteLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("That letter is not a part of this word");
        //        Console.WriteLine();
        //    }

        //    //Split and print 1 or 2
        //    string superheros = "Batman, Spiderman, Superman, Thor, Aquaman, Wonder Woman, The Arrow, The Flash";
        //    string[] elementsHeros = superheros.Split(", ");
        //    Console.WriteLine(elementsHeros[3]);
        //    Console.WriteLine(elementsHeros[7]);
        //    Console.WriteLine();
        //}//<----- FINISH


        ////-------- LISTS ------------------------------------------------------------------------------------------------------------------------------

        //{//<----- START
        //    //one way
        //    List<string> codeWords = new List<string>();
        //    codeWords.Add("algorithm");
        //    codeWords.Add("abstraction");
        //    codeWords.Add("arithmetic operators");
        //    codeWords.Insert(2, "parameter"); //inserts the list item on index 2 shifts everything over
        //    codeWords.Insert(0, "variable");
        //    codeWords.Insert(3, "variable");
        //    codeWords.RemoveAt(0);
        //    codeWords.Remove("variable");
        //    foreach (string words in codeWords)
        //    {
        //        Console.WriteLine(words + ".");
        //    }
        //    Console.WriteLine();


        //    //------the other way in (terms of first set of {}'s and starting words in the list)
        //    List<string> codingWords = new List<string>
        //    {
        //        "abstraction",
        //        "arithmetic operators",
        //        "algorithm"
        //    };
        //    Console.WriteLine(codingWords);
        //    Console.WriteLine("my list has " + codingWords.Count + " elements");
        //    codingWords.Add("binary");
        //    codingWords.Add("variable");
        //    codingWords.Add("parameter");
        //    foreach (string word in codingWords)
        //    {
        //        if (word.Equals("abstraction"))
        //        {
        //            Console.WriteLine("List has abstraction!");
        //        }
        //    }
        //    codingWords.Add("assignment operators");
        //    codingWords.Add("augmented reality");
        //    codingWords.Add("autonomous");
        //    codingWords.Add("conditional statements");
        //    codingWords.Add("argument");
        //    codingWords.Add("compiler");
        //    codingWords.Add("computational thinking");
        //    codingWords.Add("iteration");
        //    Console.WriteLine(codingWords);
        //    Console.WriteLine("my list has " + codingWords.Count + " elements");
        //    if (codingWords.Contains("iteration"))
        //    {
        //        Console.WriteLine("List contains iteration");
        //    }
        //    Console.WriteLine("Parameter is element " + codingWords.IndexOf("parameter"));
        //    Console.WriteLine();
        //    //Console.WriteLine(codingWords) <---- would not print out the elements of the List
        //    //---The FOREACH below actually prints out all elements
        //    foreach (string word in codingWords)
        //    {
        //        Console.WriteLine(word + "! ");
        //    }
        //    Console.WriteLine();
        //    //Simplest way to print all items in List.
        //    codingWords.ForEach(Console.WriteLine);
        //}//<----- FINISH


        ////-------- DICTIONARIES ------------------------------------------------------------------------------------------------------------------------------

        {//<----- START
            Dictionary<string, string> prices = new Dictionary<string, string>();
            prices.Add("menu item two", "34.95");
            prices.Add("menu item one", "19.95");

            foreach (var kvp in prices)
            {
                Console.WriteLine(kvp.Key + ": $" + kvp.Value);
            }
            Console.WriteLine();


            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(23052, "Student One");
            students.Add(68929, "Student Two");
            students.Add(57285, "Student Three");

            foreach (var student in students)
            {
                Console.WriteLine("The students are " + student.Key + "          " + student.Value);
            }
            Console.WriteLine();

            foreach (var student in students)
            {
                Console.WriteLine("Student Names " + student.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Total currently enrolled: " + students.Count);
            Console.WriteLine();

            students.Add(56789, "Student Four");
            students.Add(23289, "Student Five");
            students.Add(59279, "Student Six");
            students.Add(19268, "Student Seven");
            students.Add(17625, "Student Eight");
            students.Add(10298, "Student Nine");

            foreach (var student in students.Keys)
            {
                Console.WriteLine("Student ID's " + student);
            }
            Console.WriteLine();

            Console.WriteLine("Total currently enrolled: " + students.Count);
            Console.WriteLine();

            foreach (var student in students)
            {
                Console.WriteLine("The students are " + student.Key + "          " + student.Value);
            }
            Console.WriteLine();
        }//<----- FINISH

        //-------- THE END --------
    }
}