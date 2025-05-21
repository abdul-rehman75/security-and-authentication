using Xunit;

public class InputValidationTests
{
    [Fact]
    public void Should_Accept_Alphanumeric()
    {
        bool result = ValidationHelpers.IsValidInput("Test123");
        Assert.True(result);
    }

    [Fact]
    public void Should_Reject_Invalid_Characters()
    {
        bool result = ValidationHelpers.IsValidInput("Test<>");
        Assert.False(result);
    }
}
