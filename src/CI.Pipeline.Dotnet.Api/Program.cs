using System.Diagnostics.CodeAnalysis;
using CI.Pipeline.Dotnet.Api.Domain;

namespace CI.Pipeline.Dotnet.Api;

[ExcludeFromCodeCoverage]
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.MapPost("/addition", (Req request) 
                => new Addition().Execute(request.A, request.B)
        )
        .WithName("Addition")
        .WithOpenApi();

        app.MapPost("/subtraction", (Req request) 
            => new Subtraction().Execute(request.A, request.B)
        )
        .WithName("Subtraction")
        .WithOpenApi();

        app.MapPost("/multiplication", (Req request) 
            => new Multiplication().Execute(request.A, request.B)
        )
        .WithName("Multiplication")
        .WithOpenApi();

        app.MapPost("/division", (Req request)
            => new Division().Execute(request.A, request.B)
        )
        .WithName("Division")
        .WithOpenApi();

        app.MapPost("/power", (Req request)
                => new Power().Execute(request.A, request.B)
            )
            .WithName("Power")
            .WithOpenApi();
        
        app.Run();
    }
}
