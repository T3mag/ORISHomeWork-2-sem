using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeamHost.Application.Contracts.Profile.EditProfile;
using TeamHost.Application.Contracts.Profile.PostLogin;
using TeamHost.Application.Contracts.Profile.PostRegister;
using TeamHost.Application.Features.Queries.Profile.EditProfile;
using TeamHost.Application.Features.Queries.Profile.GetUserById;
using TeamHost.Application.Features.Queries.Profile.PostLogin;
using TeamHost.Application.Features.Queries.Profile.PostRegister;
using TeamHost.Application.Interfaces;
using TeamHost.Domain.Entities;
namespace TeamHost.Areas.Account.Controllers;
[Area("Account")]
public class ProfileController : Controller{
    private IMediator mediator;
    private SignInManager<User> signInManager;
    private IUserContext userContext;
    public ProfileController(
        IMediator mediator,
        SignInManager<User> signInManager,
        IUserContext userContext)
    {
        this.mediator = mediator;
        this.signInManager = signInManager;
        this.userContext = userContext;
    }
    [Authorize]
    [HttpGet]
    public async Task<IActionResult> Index() {
        var result = await mediator.Send(new GetUserByIdQuery(userContext.CurrentUserId!.Value));
        return View(result);
    }
    [Authorize]
    [HttpGet]
    public async Task<IActionResult> EditProfile() {
        return View();
    }
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> EditProfile([FromForm] EditProfileRequest request) {
        var result = await mediator.Send(new PutEditProfileCommand(request));
        if (!result) return BadRequest();
        return View(request);
    }
    [HttpGet]
    public IActionResult Login() {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login([FromForm] PostLoginRequest request, string? returnUrl = null) {
        var result = await mediator.Send(new PostLoginCommand(request));
        if (returnUrl != null && result) LocalRedirect(returnUrl);
        return result ? RedirectToAction("Index", "Home", new { area = "Home" }) : BadRequest();
    }
    [HttpGet]
    public IActionResult Register() {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Register([FromForm] PostRegisterRequest request) {
        var result = await mediator.Send(new PostRegisterCommand(request));
        if (!result.IsSucceed) result.Errors?.ForEach(error => ModelState.AddModelError(string.Empty, error));
        return RedirectToAction("Index", "Home", new { area = "Home" });
    }
    public async Task<IActionResult> Logout() {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home", new { area = "Home" });
    }
}