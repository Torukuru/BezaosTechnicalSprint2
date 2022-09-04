// See https://aka.ms/new-console-template for more information

//IDE = VISUAL STUDIO CODE.
//The Basic or C# Traditional Syntax is being added by Visual Studio when I create the Console App 
//I should have used Visual Studio which is a bit easier but I already had vscode installed on my system so i decide to do it with vsCode

Console.WriteLine("Maximum Number of Guesses is Five");
Console.WriteLine("Guess a Number From 1 to Twenty!");


Random random = new Random(); //Create a Random Class
int randomNumber = random.Next(1,21); //Generate a ramdom number from 1 to 20
int guess = 0;
int previousGuess;
int numberofGuesses = 1;
bool end = false;
while(end == false) 
{ //While the end variable reads false Do these
    previousGuess = guess;
    guess = Convert.ToInt32(Console.ReadLine());

 if(guess == previousGuess || guess > 20) //If the User enters 0 or a number greater than 20, its an invalid Number
 {
    Console.WriteLine("Invalid Try, Try another Number");

}
    else if (guess != randomNumber && numberofGuesses == 5) //If the User Value is not equal to the Random Number and the he has guessed up to 5 times, GAME OVER
    {
        Console.WriteLine("Game Over");
        end = true;
    } 

    else if(guess == randomNumber)  //Once the User inputs the Random Number He wins
    {
           Console.WriteLine("You won");
        end = true;
    }

    else if(guess > randomNumber && previousGuess != guess) //help gives the user  a hint if he enters a number greater than the Random Number and also makes sure the user doesn't enter a number consecutively.
    {
        Console.WriteLine($"You have {5 - numberofGuesses} more tries ");
        Console.WriteLine("Try a lesser Number");
        numberofGuesses = numberofGuesses + 1;

    }

        else if(guess < randomNumber && previousGuess != guess) //help gives the user  a hint if he enters a number lesser than the Random Number and also makes sure the user doesn't enter a number consecutively.
    {
        Console.WriteLine($"You have {5 - numberofGuesses} more tries ");
        Console.WriteLine("Try a larger Number");
             numberofGuesses = numberofGuesses + 1;

    }
   
}    
