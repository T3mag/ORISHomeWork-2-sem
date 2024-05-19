using MediatR;
using TeamHost.Application.Contracts.Chats.GetMessagesChats;

namespace TeamHost.Application.Features.Queries.Chats.GetMessagesChats;


public class GetMessagesChatsQuery : IRequest<GetMessagesChatsResponse>
{
    public GetMessagesChatsQuery(Guid chatId)
        => ChatId = chatId;
    

    public Guid ChatId { get; set; }
}