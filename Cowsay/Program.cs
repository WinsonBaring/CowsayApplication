using System;
using Microsoft.Extensions.DependencyInjection;
using Cowsay.Services;
using Cowsay.Interfaces;
using Cowsay.Core;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            // .AddSingleton<ICowsayService, CowsayService>()
            .AddSingleton<ICowsayService, Dragon>()
            .AddSingleton<ICowsayService, Cow>()
            .AddSingleton<MenuLoop>()
            .BuildServiceProvider();

            var menu = serviceProvider.GetRequiredService<MenuLoop>();
            menu.Start();
        }
}
