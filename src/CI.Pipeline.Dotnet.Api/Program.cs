using System.Diagnostics.CodeAnalysis;

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

public class Addition
{
    public int Execute(int a, int b) => a + b;
};

public class Subtraction
{
    public int Execute(int a, int b) => a - b;
};

public class Multiplication
{
    public int Execute(int a, int b) => a * b;
};

public class Division
{
    public int Execute(int a, int b)
    {
        if (b == 0)
            return 0;

        return a / b;
    }
}

public class Power
{
    public double Execute(int a, int b) => Math.Pow(a, b);
};

public class Req
{
    public int A { get; set; }
    public int B { get; set; }
}