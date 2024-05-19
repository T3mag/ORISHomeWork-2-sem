using TeamHost.Domain.Common;
using TeamHost.Domain.Entities.Chats;
namespace TeamHost.Domain.Entities;
public class MediaFile : BaseAuditableEntity{
    public string? Name { get; set; }
    public string? Path { get; set; }
    public ulong Size { get; set; }
    public Game? Game { get; set; }
    public UserInfo? UserInfo { get; set; }
    public List<Chat> Chats { get; set; }
}