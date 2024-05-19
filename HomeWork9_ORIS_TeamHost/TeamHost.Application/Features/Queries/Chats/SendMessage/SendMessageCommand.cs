using MediatR;
using TeamHost.Application.Contracts.Chats.SendMessage;

namespace TeamHost.Application.Features.Queries.Chats.SendMessage;


public class SendMessageCommand : SendMessageRequest, IRequest
{

    public SendMessageCommand(Guid chatId, SendMessageRequest request)
        : base(request)
        => ChatId = chatId;
    

    public Guid ChatId { get; set; }
}