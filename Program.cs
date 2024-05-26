using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using GameManagement.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = new List<GameDto>
{
    new GameDto(1, "Halo", "A Sci-Fi FPS", "Shooter", 59.99m, new DateOnly(2001, 11, 15)),
    new GameDto(2, "Halo 2", "A Sci-Fi FPS", "Shooter", 59.99m, new DateOnly(2004, 11, 9)),
    new GameDto(3, "Halo 3", "A Sci-Fi FPS", "Shooter", 59.99m, new DateOnly(2007, 9, 25)),
    new GameDto(4, "Halo 4", "A Sci-Fi FPS", "Shooter", 59.99m, new DateOnly(2012, 11, 6)),
    new GameDto(5, "Halo 5", "A Sci-Fi FPS", "Shooter", 59.99m, new DateOnly(2015, 10, 27)),
    new GameDto(6, "Halo Infinite", "A Sci-Fi FPS", "Shooter", 59.99m, new DateOnly(2021, 12, 8))
};

app.MapGet("/games", () => games);
app.MapGet("/games/{id}", (int id) =>
{
    var game = games.Find(g => g.Id == id);
    return game != null ? Results.Ok(game) : Results.NotFound();
});

// Create a new game
app.MapPost("/games", (CreateGameDto game) =>
{
    var newGame = new GameDto(games.Count + 1, game.Name, game.Description, game.Genre, game.Price, game.ReleaseDate);
    games.Add(newGame);
    return Results.Created($"/games/{newGame.Id}", newGame);
});

app.MapGet("/", () => "Hello Terence, Welcome to ASP.NET Core!");

app.Run();
