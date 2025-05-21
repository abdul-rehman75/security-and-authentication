using System;

public class XSSProtection
{
    public static bool IsValidXSSInput(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;

        return !(input.ToLower().Contains("<script") || input.ToLower().Contains("<iframe"));
    }

    public void TestXssInput()
    {
        string maliciousInput = "<script>alert('XSS');</script>";
        bool isValid = IsValidXSSInput(maliciousInput);
        Console.WriteLine(isValid ? "XSS Test Failed" : "XSS Test Passed");
    }
}
