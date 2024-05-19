using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities.Chats;
public class Chat : BaseEntity{
    public string? TitleChat { get; set; }
    public MediaFile? MediaFile { get; set; }
    public List<Messages> Messages { get; set; }
    public List<UserInfo> UserInfos { get; set; }
}