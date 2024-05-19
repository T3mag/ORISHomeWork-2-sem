using Microsoft.AspNetCore.Mvc;
namespace hw5.Controllers;
public class WalletController : Controller{
    public IActionResult Index() {
        return View();
    }
}