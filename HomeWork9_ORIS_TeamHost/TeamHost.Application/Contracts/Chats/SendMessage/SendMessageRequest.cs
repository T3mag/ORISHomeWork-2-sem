namespace TeamHost.Application.Contracts.Chats.SendMessage;
public class SendMessageRequest{
    public SendMessageRequest(){}
    public SendMessageRequest(SendMessageRequest request){
        Message = request.Message;
    }
    public string Message { get; set; } = default!;
}