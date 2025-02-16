using Cowsay.Core;

namespace Cowsay.Core;

public enum AnimalType
{
    BudFrogs,
    Bunny,
    Calvin, 
    Cheese,
    Cock,
    Cower,
    Daemon,
    Default,
    Dragon,
    DragonAndCow,
    Duck,
    Elephant,
    ElephantInSnake,
    Eyes,
    FlamingSheep,
    Fox,
    Ghostbusters,
    Gnu,
    Hellokitty,
    Kangaroo,
    Kiss,
    Koala,
    Kosh,
    LukeKoala
}
interface IAnimal{
    public AnimalType type {get; init;}
    public string Say(string message);
}