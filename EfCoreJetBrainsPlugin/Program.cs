using Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>();

var app = builder.Build();

app.Run();
