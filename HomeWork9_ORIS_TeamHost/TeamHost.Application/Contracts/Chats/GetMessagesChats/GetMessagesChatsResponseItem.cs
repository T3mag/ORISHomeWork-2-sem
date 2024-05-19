namespace TeamHost.Application.Contracts.Chats.GetMessagesChats;
public class GetMessagesChatsResponseItem{
    public string? Message { get; set; }
    public string? ReceiveMessageName { get; set; }
    public string? ReceiveMessageImage { get; set; }
    public bool IsYourMessage { get; set; }
}