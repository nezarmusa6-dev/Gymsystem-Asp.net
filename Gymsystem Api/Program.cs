using Gymsystem_Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapMemberEndpoint();

app.Run();

