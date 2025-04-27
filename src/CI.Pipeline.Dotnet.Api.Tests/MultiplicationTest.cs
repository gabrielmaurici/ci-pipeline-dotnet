using CI.Pipeline.Dotnet.Api.Domain;

namespace CI.Pipeline.Dotnet.Api.Tests;

public class MultiplicationTest
{
    [Fact]
    public void Multiplaction_Success()
    {
        var a = 2;
        var b = 5;
        var multipliaction = new Multiplication();
        
        var result = multipliaction.Execute(a, b);
        
        Assert.Equal(10, result);
    }
}