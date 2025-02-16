using System;
using Cowsay.Core.Base;
using Cowsay.Core;
public static class MenuLoop
{
    public static void Start()
    {
        DisplayOptions();

        Console.WriteLine("Enter the animal type");
        string input = Console.ReadLine() ?? String.Empty;

        // parse the input to the animal type
        AnimalType animalType = Enum.Parse<AnimalType>(input);
        AnimalBase animal = new(animalType);

        // inform the user about the animal type
        Console.Clear();
        Console.WriteLine("You choose the animal type: " + animalType);

        // ask the user for the message to display
        Console.WriteLine("Enter the message");
        string message = Console.ReadLine() ?? String.Empty;

        Console.WriteLine(animal.Say(message));
    }

    private static void DisplayOptions()
    {
        List<string> animalTypes = OptionBase.GetAnimalTypes();
        Console.WriteLine("Available animal types:");
        for (int i = 1; i < animalTypes.Count; i++)
        {
            Console.WriteLine($"{i}. {animalTypes[i]}");
        }
    }


}