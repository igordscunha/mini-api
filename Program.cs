using Microsoft.EntityFrameworkCore;
using MiniApi.Data;
using MiniApi.Models;
using SQLitePCL;

var builder = WebApplication.CreateBuilder(args);

Batteries_V2.Init();

builder.Services.AddDbContext<_DbContext>();

var app = builder.Build();

app.MapGet("/", () => "Bem vindo a API criada com SQLite por Igor Cunha");

app.MapGet("/jogadores", async (_DbContext db) => await db.Jogadores.ToListAsync());

app.MapGet("/jogadores/{id}", async (int id, _DbContext db) =>
    await db.Jogadores.FindAsync(id) is Jogador jogador ? Results.Ok(jogador) : Results.NotFound("Não foi possível achar jogador com este ID.")
);

app.MapPost("/jogadores", async (Jogador jogador, _DbContext db) =>
{
    db.Jogadores.Add(jogador);
    await db.SaveChangesAsync();
    return Results.Created($"/jogadores/{jogador.Id}", jogador);
});

app.MapPut("/jogadores/{id}", async (int id, Jogador jogador, _DbContext db) =>
{
    var jogadorEditado = await db.Jogadores.FindAsync(id);

    if (jogadorEditado is null) return Results.NotFound("Não foi possível achar jogador com este ID.");

    jogadorEditado.Nome = jogador.Nome;
    jogadorEditado.Vida = jogador.Vida;
    jogadorEditado.Ataque = jogador.Ataque;
    jogadorEditado.Defesa = jogador.Defesa;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/jogadores/{id}", async (int id, _DbContext db) =>
{
    var jogadorDeletado = await db.Jogadores.FindAsync(id);

    if (jogadorDeletado is null) return Results.NotFound("Não foi possível achar jogador com este ID.");

    db.Jogadores.Remove(jogadorDeletado);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.UseHttpsRedirection();

app.Run();
