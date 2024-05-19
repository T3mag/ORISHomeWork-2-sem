using Microsoft.AspNetCore.Mvc;
namespace hw5.Controllers;
public class StoreController : Controller{
    public IActionResult Index(){
        return View();
    }
}