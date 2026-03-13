
public class Program
{
    public static void printHangman(int wrong)
    {

        switch (wrong)
        {
            case 1:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.WriteLine("you have 9 chances left");
                break;

            case 2:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.WriteLine("you have 8 chances left");
                break;

            case 3:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|   |");
                Console.WriteLine("|   |");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.WriteLine("you have 7 chances left");
                break;

            case 4:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|   |");
                Console.WriteLine("|   |");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.WriteLine("you have 6 chances left");
                break;

            case 5:
                Console.WriteLine("\n+---+");
                Console.WriteLine(" |  |");
                Console.WriteLine(" |  |");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.WriteLine("you have 5 chances left");
                break;

            case 6:
                Console.WriteLine("\n+---+");
                Console.WriteLine(" |  |");
                Console.WriteLine(" |  |");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.WriteLine("you have 4 chances left");
                break;

            case 7:
                Console.WriteLine("\n+---+");
                Console.WriteLine(" |  |");
                Console.WriteLine(" |  |");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
                Console.WriteLine("you have 3 chances left");
                break;

            case 8:
                Console.WriteLine("\n+---+");
                Console.WriteLine(" |  |");
                Console.WriteLine(" |  |");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/ \\ |");
                Console.WriteLine("    |");
                Console.WriteLine("    ===");
                Console.WriteLine("you have 2 chances left");
                break;

            case 9:
                Console.WriteLine("\n+---+");
                Console.WriteLine(" |  |");
                Console.WriteLine(" |  |");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/ \\ |");
                Console.WriteLine("    |");
                Console.WriteLine("    ===");
                Console.WriteLine("Last life! Be careful!");
                break;

            case 10:
                Console.WriteLine("\n+---+");
                Console.WriteLine(" |  |");
                Console.WriteLine(" |  |");
                Console.WriteLine(" |  |");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/ \\ |");
                Console.WriteLine("    ===");
                Console.WriteLine("Game Over! ");
                break;

            default:
                break;
        }
        /* if (wrong == 1)
{
Console.WriteLine("\n+---+");
Console.WriteLine("|   |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("   ===");
Console.WriteLine("you have 9 chances left");
}
else if (wrong == 2)
{
Console.WriteLine("\n+---+");
Console.WriteLine("|   |");
Console.WriteLine("|   |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("   ===");
Console.WriteLine("you have 8 chances left");
}
else if (wrong == 3)
{
Console.WriteLine("\n+---+");
Console.WriteLine("|   |");
Console.WriteLine("|   |");
Console.WriteLine("O   |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("   ===");
Console.WriteLine("you have 7 chances left");
}
else if (wrong == 4)
{
Console.WriteLine("\n+---+");
Console.WriteLine("|   |");
Console.WriteLine("|   |");
Console.WriteLine("O   |");
Console.WriteLine("|   |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("   ===");
Console.WriteLine("you have 6 chances left");
}
else if (wrong == 5)
{
Console.WriteLine("\n+---+");
Console.WriteLine(" |  |");
Console.WriteLine(" |  |");
Console.WriteLine(" O  |");
Console.WriteLine("/|  |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("   ===");
Console.WriteLine("you have 5 chances left");
}
else if (wrong == 6)
{
Console.WriteLine("\n+---+");
Console.WriteLine(" |  |");
Console.WriteLine(" |  |");
Console.WriteLine(" O  |");
Console.WriteLine("/|\\ |");
Console.WriteLine("    |");
Console.WriteLine("    |");
Console.WriteLine("   ===");
Console.WriteLine("you have 4 chances left");
}
else if (wrong == 7)
{
Console.WriteLine("\n+---+");
Console.WriteLine(" |  |");
Console.WriteLine(" |  |");
Console.WriteLine(" O  |");
Console.WriteLine("/|\\ |");
Console.WriteLine("/   |");
Console.WriteLine("    |");
Console.WriteLine("   ===");
Console.WriteLine("you have 3 chances left");
}
else if (wrong == 8)
{
Console.WriteLine("\n+---+");
Console.WriteLine(" |  |");
Console.WriteLine(" |  |");
Console.WriteLine(" O  |");
Console.WriteLine("/|\\ |");
Console.WriteLine("/ \\ |");
Console.WriteLine("    |");
Console.WriteLine("    ===");
Console.WriteLine("you have 2 chances left");
}
else if (wrong == 9)
{
Console.WriteLine("\n+---+");
Console.WriteLine(" |  |");
Console.WriteLine(" |  |");
Console.WriteLine(" O  |");
Console.WriteLine("/|\\ |");
Console.WriteLine("/ \\ |");
Console.WriteLine("    |");
Console.WriteLine("    ===");
Console.WriteLine("Last life! Be careful!");
}
else if (wrong == 10)
{
Console.WriteLine("\n+---+");
Console.WriteLine(" |  |");
Console.WriteLine(" |  |");
Console.WriteLine(" |  |");
Console.WriteLine(" O  |");
Console.WriteLine("/|\\ |");
Console.WriteLine("/ \\ |");
Console.WriteLine("    ===");
Console.WriteLine("Game Over! ");
}
*/
    }

    public static int printWord(List<char> guessedLetters, String randomWord)
    {
        int counter = 0;
        int rightLetters = 0;
        Console.Write("\r\n");
        foreach (char c in randomWord)
        {
            if (guessedLetters.Contains(c))
            {
                Console.Write(c + " ");
                rightLetters += 1;
            }
            else
            {
                Console.Write("_  ");
            }
            counter += 1;
        }

        return rightLetters;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to hangman :)");
        Console.WriteLine("-----------------------------------------");

        Random random = new Random();
        List<string> wordDictionary = new List<string> { "sunflower", "house", "diamond", "memes", "yeet", "hello", "howdy", "like", "subscribe" };
        int index = random.Next(wordDictionary.Count);
        String randomWord = wordDictionary[index];
        //String PrintLine = " ";
        foreach (char x in randomWord)
        {
            Console.Write("_ ");
        }
        //Console.WriteLine(PrintLine);
        Console.WriteLine();

        Console.WriteLine($"Your word have {randomWord.Length} letters");

        int lengthOfWordToGuess = randomWord.Length;
        int amountOfTimesWrong = 0;
        List<char> currentLettersGuessed = new List<char>();
        int currentLettersRight = 0;

        // Use WHILE to keep the game running until someone wins or loses
        while (amountOfTimesWrong != 10 && currentLettersRight != lengthOfWordToGuess)

        {
            //Console.WriteLine(PrintLine);
            Console.Write("\nLetters guessed so far: ");
            foreach (char letter in currentLettersGuessed)
            {
                Console.Write(letter + " ");

            }
            // Prompt user for input
            Console.Write("\nGuess a letter or the whole word: ");
            string input= Console.ReadLine()?.ToLower();
            
            //whole word Logic
            if (input.Length > 1)
            {
                if (input.ToLower() == randomWord.ToLower())
                {
                    Console.WriteLine("You guessed the whole word! :)");
                    currentLettersRight = lengthOfWordToGuess; // This wins the game
                }
                else
                {
                    amountOfTimesWrong = amountOfTimesWrong + 1;
                    printHangman(amountOfTimesWrong);
                    Console.WriteLine("\nWrong word! :( ");
                    currentLettersRight = printWord(currentLettersGuessed, randomWord);
                }
                continue; // Skip the single-letter logic below and start the next turn
            }


            //single letter logic
            char letterGuessed = input[0];
            // Check if that letter has already been guessed
            if (currentLettersGuessed.Contains(letterGuessed))
            {
                printHangman(amountOfTimesWrong);
                Console.Write("\r\n You have already guessed this letter");
                currentLettersRight = printWord(currentLettersGuessed, randomWord);
                
            }
            else
            {
                // Check if letter is in randomWord
                bool right = false;
                for (int i = 0; i < randomWord.Length; i++) 
                { 
                    if (letterGuessed == randomWord[i]) 
                    { right = true; 
                    } 
                }

                // User is right
                if (right)
                {
                    printHangman(amountOfTimesWrong);
                    // Print word
                    currentLettersGuessed.Add(letterGuessed);
                    currentLettersRight = printWord(currentLettersGuessed, randomWord);
                    Console.Write("\r\n");
                }
                // User was wrong af
                else
                {
                    amountOfTimesWrong =amountOfTimesWrong+1;
                    currentLettersGuessed.Add(letterGuessed);
                    // Update the drawing
                    printHangman(amountOfTimesWrong);
                    // Print word
                    currentLettersRight = printWord(currentLettersGuessed, randomWord);
                    Console.Write("\r\n");

                }
            }
        }
        // --- Win/Loss Check ---
        if (currentLettersRight == randomWord.Length)
        {
            Console.WriteLine("\nCongrats! The word was :" +randomWord);
        }
        else
        {
            Console.WriteLine("\n The hangman died. The word was: " + randomWord);
        }
    }
}

