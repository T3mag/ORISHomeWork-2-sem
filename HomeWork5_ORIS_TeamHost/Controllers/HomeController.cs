using Microsoft.AspNetCore.Mvc;
namespace hw5.Controllers;
public class HomeController : Controller{
    public IActionResult Index(){
        return View();
    }
}