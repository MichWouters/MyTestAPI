// See https://aka.ms/new-console-template for more information
using MyMaui.Business.Models;
using MyMaui.Business.Services;

Console.WriteLine("Hello, World!");
IGameServices service = new GameServices();
GameModel model = await service.GetGame();
Console.WriteLine(model.Title);
Console.ReadLine();