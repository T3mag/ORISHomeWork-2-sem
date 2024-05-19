using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeamHost.Application.Features.Queries.Game.GetAllGames;
using TeamHost.Application.Features.Queries.Game.GetByIdGame;
namespace TeamHost.Areas.Main.Controllers;
[Area("Main")]
public class StoreController : Controller {
    private readonly IMediator _mediator;
    public StoreController(IMediator mediator) => _mediator = mediator;
    [HttpGet]
    public async Task<IActionResult> Index() {
        var result = await _mediator.Send(new GetAllGamesQuery()); 
        return View(result);
    }
    [HttpGet("card-store/{id}")]
    public async Task<IActionResult> Details( [FromRoute] Guid id, CancellationToken cancellationToken) {
        var result = await _mediator.Send(new GetByIdGameQuery(id), cancellationToken);
        return View(result);
    }
}