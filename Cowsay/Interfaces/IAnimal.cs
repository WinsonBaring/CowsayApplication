using System;
namespace Animal.Interfaces
{
    public interface AnimalInterface
    {
        string AnimalType { get;}
        string GenerateAnimalMessage(string message);
    }
}
