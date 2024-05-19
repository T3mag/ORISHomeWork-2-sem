using MediatR;
using TeamHost.Application.Contracts.Games.GetAllGames;
namespace TeamHost.Application.Features.Queries.Game.GetAllGames;
public class GetAllGamesQuery : IRequest<GetAllGamesResponse>{ }