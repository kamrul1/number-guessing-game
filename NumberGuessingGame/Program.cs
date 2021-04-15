using System;


const int MIN = 0;
const int MAX = 100;



Random random = new();
var winNo = random.Next(MIN, MAX);

var isWin = false;

do
{
    Console.WriteLine(Environment.NewLine);
    Console.Write($"Guess a number in between {MIN} and {MAX}:");
    var guess = Console.ReadLine();

    bool isNoParsed = int.TryParse(guess, out int guessValue);

    if (isNoParsed == false)
    {
        Console.WriteLine("Didn't recognise your entry as a number.  Please enter a valid number again");
        continue;
    }


    if (guessValue > winNo)
    {
        Console.WriteLine("Number you entered is too high, try again");
        continue;
    }

    if (guessValue < winNo)
    {
        Console.WriteLine("Number you enterd is too low, try again");
        continue;
    }

    Console.WriteLine("Great you've done it.  You WIN!");
    isWin = true;
        
} while (isWin==false);