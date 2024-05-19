using Microsoft.AspNetCore.Mvc;
namespace hw5.Controllers;
public class CommunityController : Controller{
    public IActionResult Index(){
        return View();
    }
}