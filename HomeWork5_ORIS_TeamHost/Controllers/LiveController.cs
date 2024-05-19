using Microsoft.AspNetCore.Mvc;

namespace hw5.Controllers;
public class LiveController : Controller {
    public IActionResult Index() {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> SendStreamUrl(string streamUrl) {
        return Ok();
    }
}