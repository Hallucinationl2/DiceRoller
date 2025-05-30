using System;

class DiceRoller
{
    static void Main()
    {
        Random rng = new Random();
        string input;
        do
        {
            Console.Write("Натиснете Enter за да хвърлите зар или 'q' за изход: ");
            input = Console.ReadLine();
            if (input.ToLower() != "q")
            {
                int roll = rng.Next(1, 7);
                Console.WriteLine($"Хвърлихте: {roll}\n");
            }
        } while (input.ToLower() != "q");
    }
}