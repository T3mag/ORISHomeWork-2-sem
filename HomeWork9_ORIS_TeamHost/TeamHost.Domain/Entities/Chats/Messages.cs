using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities.Chats;
public class Messages : BaseAuditableEntity{
    public string Message { get; set; } = default!;
    public Chat Chat { get; set; }
    public Guid ChatId { get; set; }
    public Guid? UserInfoId { get; set; }
    public UserInfo? UserInfo { get; set; }
}