
{
    Random random = new Random();
    bool playAgain = true;
    int min = 1;
    int max = 100;
    int guess;
    int number;
    int guesses;
    String response;

    while(playAgain)
    {
        guess = 0;
        guesses = 0;
        response = "";
        number = random.Next(min, max + 1);

        while (guess != number)
        {
            Console.WriteLine("Guess a number between " + min + " - " + max + ": ");
            guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Guess: " + guess);

            if (guess > number)
            {
                Console.WriteLine(guess + " is to high!\n");
            }
            else if (guess < number)
            {
                Console.WriteLine(guess + " is to low!\n");            
            }
            guesses++;
            
        }
        Console.WriteLine(number + " is the correct number!");
        Console.WriteLine("\nYOU WIN!");
        Console.WriteLine("It took you " + guesses + " guesses");

        Console.WriteLine("Would you like to play agin? (Y/N): ");
        response = Console.ReadLine();
        response = response.ToUpper();

        if (response == "Y")
        {
            playAgain = true;
        }
        else
        {
            playAgain= false;
        }
    }

    Console.WriteLine("Thanks for playing ... I guess");

    Console.ReadKey();
}