using Cowsay.Core;
using System.Diagnostics;


namespace Cowsay.Core.Base;

public class AnimalBase : IAnimal
{
    public AnimalBase(AnimalType type)
    {
        this.type = type;
    }
    public AnimalType type { get; init; }
    public string Say(string message)
    {

        ProcessStartInfo cowsay = new()
        {
            FileName = "cowsay",
            Arguments = GetAnimalType(),
            RedirectStandardOutput = true,
            RedirectStandardInput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using Process process = new() { StartInfo = cowsay };

        process.Start();
        process.StandardInput.WriteLine(message);
        process.StandardInput.Close();
        string result = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        return result;
    }
    private string GetAnimalType()
    {
        return type switch
        {

            AnimalType.BudFrogs => "-f bud-frogs",
            AnimalType.Bunny => "-f bunny",
            AnimalType.Calvin => "-f calvin",
            AnimalType.Cheese => "-f cheese",
            AnimalType.Cock => "-f cock",
            AnimalType.Cower => "-f cower",
            AnimalType.Daemon => "-f daemon",
            AnimalType.Default => "-f default",
            AnimalType.Dragon => "-f dragon",
            AnimalType.DragonAndCow => "-f dragon-and-cow",
            AnimalType.Duck => "-f duck",
            AnimalType.Elephant => "-f elephant",
            AnimalType.ElephantInSnake => "-f elephant-in-snake",
            AnimalType.Eyes => "-f eyes",
            AnimalType.FlamingSheep => "-f flaming-sheep",
            AnimalType.Fox => "-f fox",
            AnimalType.Ghostbusters => "-f ghostbusters",
            AnimalType.Gnu => "-f gnu",
            AnimalType.Hellokitty => "-f hellokitty",
            AnimalType.Kangaroo => "-f kangaroo",
            AnimalType.Kiss => "-f kiss",
            AnimalType.Koala => "-f koala",
            AnimalType.Kosh => "-f kosh",
            AnimalType.LukeKoala => "-f luke-koala",
            _ => "-f cow"  // Default case, returns cow if unknown animal type
        };
    }
}
