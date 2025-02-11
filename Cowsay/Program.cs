using System;
// using Microsoft.Extensions.DependencyInjection;
using Cowsay.Services;
using Cowsay.Interfaces;

class Program
{
    static void Main()
    {
        // Setup Dependency Injection
        Console.WriteLine("Hello, World!");
        // var serviceProvider = new ServiceCollection()
        //     .AddSingleton<ICowsayService, CowsayService>()
        //     .BuildServiceProvider();

        // var cowsayService = serviceProvider.GetService<ICowsayService>();

        // Console.Write("Enter your message: ");
        // string input = Console.ReadLine();

        // string output = cowsayService?.GenerateCowsayMessage(input); // ✅ Fixed method name
        // Console.WriteLine(output);
    }
}
