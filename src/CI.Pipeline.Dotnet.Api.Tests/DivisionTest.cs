namespace CI.Pipeline.Dotnet.Api.Tests;

public class DivisionTest
{
    [Fact]
    public void Division_Success()
    {
        var a = 10;
        var b = 2;
        var division = new Division();

        var result = division.Execute(a, b);
        
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Division_Zero_Success()
    {
        var a = 10;
        var b = 0;
        var division = new Division();

        var result = division.Execute(a, b);
        
        Assert.Equal(0, result);
    }
}