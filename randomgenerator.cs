using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Bunny Facts Generator!");

        List<string> bunnyFacts = GetBunnyFacts();

        while (true)
        {
            Console.WriteLine("\nPress Enter to get a random bunny fact (or type 'exit' to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            DisplayRandomBunnyFact(bunnyFacts);
        }

        Console.WriteLine("Goodbye!");
    }

    static List<string> GetBunnyFacts()
    {
        return new List<string>
        {
            "Bunnies have a panoramic field of vision, nearly 360 degrees!",
            "Rabbits are crepuscular, meaning they are most active during dawn and dusk.",
            "A group of bunnies is called a fluffle.",
            "Rabbits have 28 teeth, and their teeth never stop growing!",
            "Bunnies are expert jumpers and can leap up to 36 inches in a single hop.",
            "A female rabbit is called a doe, a male is a buck, and a baby is a kit or kitten.",
            "Rabbits are known for their grooming skills and will often groom themselves and their companions.",
            "Bunnies have an excellent sense of smell, hearing, and vision.",
            "Rabbits can live up to 10 years or more with proper care.",
            "Carrots are a popular treat for rabbits, but they should be given in moderation."
        };
    }

    static void DisplayRandomBunnyFact(List<string> bunnyFacts)
    {
        Random random = new Random();
        int randomIndex = random.Next(bunnyFacts.Count);
        string randomFact = bunnyFacts[randomIndex];

        Console.WriteLine("\nBunny Fact: " + randomFact);
    }
}
