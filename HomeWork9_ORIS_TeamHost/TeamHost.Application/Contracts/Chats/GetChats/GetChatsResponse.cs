namespace TeamHost.Application.Contracts.Chats.GetChats;
public class GetChatsResponse{
    public Guid ChatId { get; set; }
    public bool IsGroup { get; set; }
    public string? TitleChat { get; set; }
    public DateTime? LastSend { get; set; }
    public string? Image { get; set; }
    public string? LastReceivedMessage { get; set; }
    public Guid? FriendId { get; set; }
}