using TeamHost.Domain.Common;
using TeamHost.Domain.Entities.Chats;
namespace TeamHost.Domain.Entities;
public class UserInfo : BaseEntity{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronimic { get; set; }
    public string? About { get; set; }
    public DateTime? Birthday { get; set; }
    public Country? Country { get; set; }
    public Guid? CountryId { get; set; }
    public Guid? ImageId { get; set; }
    public MediaFile? Image { get; set; }
    public User? User { get; set; }
    public Guid? UserId { get; set; }
    public List<Chat> Chats { get; set; }
    public void UpdateInfo(string firstName, string lastName, string? patronomic, string? about, DateTime? birthday, Country? country, MediaFile? image) {
        FirstName = firstName;
        LastName = lastName;
        Patronimic = patronomic ?? Patronimic;
        About = about ?? About;
        Birthday = birthday ?? Birthday;
        Country = country ?? Country;
        Image = image ?? Image;
    }
}