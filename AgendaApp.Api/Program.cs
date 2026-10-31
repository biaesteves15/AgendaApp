using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapScalarApiReference(options =>
{
    options.WithTitle("Agenda de tarefas - Minimal API");
    options.WithTheme(ScalarTheme.BluePlanet).EnableDarkMode();
});

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Cadastrar tarefa
app.MapPost("/api/v1/tarefas", () =>
{
    return Results.Ok();
});

// Atualizar tarefa
app.MapPut("/api/v1/tarefas", () =>
{
    return Results.Ok();
});

// Excluir tarefa
app.MapDelete("/api/v1/tarefas", () =>
{
    return Results.Ok();
});

// Consultar tarefas
app.MapGet("/api/v1/tarefas", () =>
{
    return Results.Ok();
});

app.Run();