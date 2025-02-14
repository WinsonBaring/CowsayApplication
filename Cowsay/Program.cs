using Microsoft.Extensions.DependencyInjection;
using Animal.Core;
using Animal.Interfaces;
using Animal.Services;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<AnimalInterface, Dragon>()
            // .AddSingleton<AnimalInterface, Cow>()
            .AddSingleton<MenuLoop>()
            .BuildServiceProvider();

        var menu = serviceProvider.GetRequiredService<MenuLoop>();
        menu.Start();
    }
}
