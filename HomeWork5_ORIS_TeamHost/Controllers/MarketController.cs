using Microsoft.AspNetCore.Mvc;
namespace hw5.Controllers;
public class MarketController : Controller {
    public IActionResult Index() {
        return View();
    }
}