using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeamHost.Application.Features.Games.DTOs;

namespace TeamHost.Web.Areas.Auth.Controllers;
[Area("Auth")]
public class RegisterController : Controller
{

    
    public IActionResult Index()
    {
        Console.WriteLine("Регистрируем");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromForm] AuthDtoRequest authDtoRequest)
    {
        return RedirectToAction("Index", "Home", new { area = "Home" });
    }
    
    public async Task<IActionResult> Logout()
    {
        return RedirectToAction("Index", "Home", new { area = "Home" });
    }
}

