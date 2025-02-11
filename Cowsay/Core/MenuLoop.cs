
using Microsoft.Extensions.DependencyInjection;
using Animal.Interfaces;

namespace Animal.Core
{

    public class MenuLoop {
        private readonly AnimalInterface _animalService;
        private bool isRunning = true;
        public MenuLoop(AnimalInterface animalService){
            this._animalService = animalService ?? throw new ArgumentNullException(nameof(animalService));
        }

        public void Start(){
            while (isRunning){
                DisplayMenu();

                string choice = Console.ReadLine() ?? "";
                Console.Clear();
                HandleChoice(choice);
            }
        }
        private void DisplayMenu(){
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("Press 'q' to quit");
            if(_animalService.AnimalType == "Cow"){
                Console.WriteLine("Press '1' to display the cowsay message");
            }
            if(_animalService.AnimalType == "Dragon"){
                Console.WriteLine("Press '1' to display the dragon message");
            }
        }
        private void HandleChoice(string choice){
            switch (choice){
                case "1":
                    string message =  Console.ReadLine() ?? "";
                    Console.WriteLine(_animalService.GenerateAnimalMessage(message));
                    Console.WriteLine("You selected option 1");
                    break;
                case "q":
                    Console.WriteLine("You selected option q");
                    isRunning = false;
                    break;
            }
        }
    }
}