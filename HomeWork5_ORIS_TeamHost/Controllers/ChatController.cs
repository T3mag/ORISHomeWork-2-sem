using Microsoft.AspNetCore.Mvc;

namespace hw5.Controllers;

public class ChatController : Controller{
    public IActionResult Index() {
        return View();
    }
}