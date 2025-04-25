namespace CI.Pipeline.Dotnet.Api.Tests;

public class PowerTest
{
    [Fact]
    public void Power_Success()
    {
        var a = 2;
        var b = 2;
        var power = new Power();

        var result = power.Execute(a, b);
        
        Assert.Equal(4, result);
    }
}