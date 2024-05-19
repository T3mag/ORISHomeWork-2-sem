using MediatR;
using TeamHost.Application.Contracts.Profile.GetProfileImage;

namespace TeamHost.Application.Features.Queries.Profile.GetProfileImage;


public class GetProfileImageQuery : IRequest<GetProfileImageResponse?>
{
}