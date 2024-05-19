using MediatR;
using TeamHost.Application.Contracts.Chats;
using TeamHost.Application.Contracts.Chats.GetChats;

namespace TeamHost.Application.Features.Queries.Chats.GetChats;


public class GetChatsQuery : IRequest<List<GetChatsResponse>>
{
}