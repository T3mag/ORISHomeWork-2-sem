namespace TeamHost.Application.Contracts.Chats.GetMessagesChats;
public class GetMessagesChatsResponse{
    public string? ChatTitle { get; set; }
    public string? ChatImage { get; set; }
    public Guid ChatId { get; set; }
    public bool IsGroup { get; set; }
    public List<GetMessagesChatsResponseItem>? Messages { get; set; }
}