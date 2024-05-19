using MediatR;
using TeamHost.Application.Contracts.Games.GetByIdGame;
namespace TeamHost.Application.Features.Queries.Game.GetByIdGame;
public class GetByIdGameQuery : IRequest<GetByIdGameResponse> {
    public GetByIdGameQuery(Guid id) => Id = id;
    public Guid Id { get; set; }
}