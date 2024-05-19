using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities;
public class UserInfo : BaseEntity{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronimic { get; set; }
    public string? About { get; set; }
    public DateTime? Birthday { get; set; }
    public Country? Country { get; set; }
    public int? CountryId { get; set; }
    public User? User { get; set; }
    public int? UserId { get; set; }
    public string NickName { get; set; }
    public List<Chats> ChatsList { get; set; }
}