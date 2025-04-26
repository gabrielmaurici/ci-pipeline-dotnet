namespace CI.Pipeline.Dotnet.Api.Domain;

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
