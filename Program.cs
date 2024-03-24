using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddInterfaceType<IReadingMaterials>();
    
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();