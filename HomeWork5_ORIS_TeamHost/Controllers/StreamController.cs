using Microsoft.AspNetCore.Mvc;
namespace hw5.Controllers;
public class StreamController : Controller{
    public IActionResult Index(){
        return View();
    }
}