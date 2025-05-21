using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public IActionResult Dashboard()
    {
        return View();
    }
}

[Authorize(Roles = "User")]
public class UserController : Controller
{
    public IActionResult Profile()
    {
        return View();
    }
}
