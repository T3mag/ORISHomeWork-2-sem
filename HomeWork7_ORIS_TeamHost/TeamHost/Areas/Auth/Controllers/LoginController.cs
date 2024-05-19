using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeamHost.Application.Features.Games.DTOs;

namespace TeamHost.Web.Areas.Auth.Controllers;


[Area("Auth")]
public class LoginController : Controller
{
    
    public IActionResult Index()
    {
        Console.WriteLine("Логинимся");
        return View();
    }
    

    [HttpPost]
    public async Task<IActionResult> Login([FromForm] LoginDtoRequest loginDtoRequest)
    {
        return RedirectToAction("Index", "Home", new { area = "Home" });
    }
}

