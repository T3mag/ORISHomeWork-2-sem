using Microsoft.AspNetCore.Mvc;
namespace hw5.Controllers;
public class FriendController : Controller{
    public IActionResult Index(){
        return View();
    }
}