using Xunit;

public class AuthTests
{
    [Fact]
    public void Login_Should_Return_False_On_Invalid_Input()
    {
        var service = new LoginService();
        bool result = service.LoginUser("admin<script>", "pass");
        Assert.False(result);
    }

    [Fact]
    public void XSS_Validation_Should_Block_Scripts()
    {
        bool result = ValidationHelpers.IsValidXSSInput("<script>alert('hi')</script>");
        Assert.False(result);
    }
}
