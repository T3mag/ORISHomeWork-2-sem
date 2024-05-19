using MediatR;
using TeamHost.Application.Contracts.Profile.GetUserById;

namespace TeamHost.Application.Features.Queries.Profile.GetUserById;


public class GetUserByIdQuery : IRequest<GetUserByIdResponse>
{

    public GetUserByIdQuery(Guid id)
        => Id = id;


    public Guid? Id { get; set; }
}