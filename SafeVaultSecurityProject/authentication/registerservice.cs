using Microsoft.AspNetCore.Identity;

public class RegisterService
{
    private readonly PasswordHasher<string> _hasher = new PasswordHasher<string>();

    public string HashPassword(string username, string password)
    {
        return _hasher.HashPassword(username, password);
    }
}
