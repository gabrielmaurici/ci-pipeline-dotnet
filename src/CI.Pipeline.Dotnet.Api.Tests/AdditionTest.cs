namespace CI.Pipeline.Dotnet.Api.Tests;

public class AdditionTest
{
    [Fact]
    public void Addition_Success()
    {
        var a = 5;
        var b = 10;
        var addition = new Addition();

        var result = addition.Execute(a, b);
        
        Assert.Equal(1, result);
    }
}