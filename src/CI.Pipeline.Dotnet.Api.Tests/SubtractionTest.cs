namespace CI.Pipeline.Dotnet.Api.Tests;

public class SubtractionTest
{
    [Fact]
    public void Subtraction_Success()
    {
        var a = 20;
        var b = 10;
        var subtraction = new Subtraction();
        
        var result = subtraction.Execute(a, b);
        
        Assert.Equal(10, result);
    }
}