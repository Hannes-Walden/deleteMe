using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
public class Program
{

    // VSCODE COMMAND PALETTE!!!

    public static void Main(string[] args)
    {
        Console.WriteLine("Starting!");

        // First we need a web service builder.
        // (factory design pattern..)
        // CreateBuilder creates a builder (a factory)

        var builder = WebApplication.CreateBuilder();
        builder.Services.AddControllers();

        // builder.Build creates a web app
        var webapi = builder.Build();

        webapi.MapControllers();

        // after that we can use the builder to create the web api.
        webapi.Run();

        // once we have the web api we can start it.
    }
}