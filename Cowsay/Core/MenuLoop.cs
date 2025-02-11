
using Microsoft.Extensions.DependencyInjection;
using Cowsay.Interfaces;

namespace Cowsay.Core
{

    public class MenuLoop {
        private readonly ICowsayService _cowsayService;
        private readonly ICowsayService _dragonService;
        private bool isRunning = true;
        public MenuLoop(ICowsayService cowsayService, ICowsayService dragonService){
            _cowsayService = cowsayService;
            _dragonService = dragonService;
        }

        public void Start(){
            while (isRunning){
                DisplayMenu();

                string choice = Console.ReadLine() ?? "";
                Console.Clear();
                HandleChoice(choice);
            }
        }
        private static void DisplayMenu(){
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("Press 'q' to quit");
            Console.WriteLine("Press '1' to display the cowsay message");
            Console.WriteLine("Press '2' to display the dragon message");
        }
        private void HandleChoice(string choice){
            switch (choice){
                case "1":
                    string message =  Console.ReadLine() ?? "";
                    Console.WriteLine(_cowsayService.GenerateCowsayMessage(message));
                    Console.WriteLine("You selected option 1");
                    break;
                case "2":
                    string message2 =  Console.ReadLine() ?? "";
                    Console.WriteLine(_dragonService.GenerateCowsayMessage(message2));
                    Console.WriteLine("You selected option 2");
                    break;
                case "q":
                    Console.WriteLine("You selected option q");
                    isRunning = false;
                    break;
            }
        }
    }
}