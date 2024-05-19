namespace TeamHost.Application.Models;
public class SendMessageModel{
    public string? Text { get; set; }
    public bool IsYourMessage { get; set; }
    public List<Guid?>? SentTo { get; set; }
    public Guid? WhoSentId { get; set; }
    public Dictionary<Guid?, string?> Images { get; set; }
    public string? SenderName { get; set; }
}