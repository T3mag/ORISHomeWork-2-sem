using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities;
public class UserInfo : BaseEntity {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Patronimic { get; set; }
    public string? About { get; set; }
    public DateTime? Birthday { get; set; }
    public Country? Country { get; set; }
    public Guid? CountryId { get; set; }
    public User? User { get; set; }
    public Guid? UserId { get; set; }
    public void UpdateInfo(string firstName, string lastName, string? patronomic, string? about, DateTime? birthday, Country? country) {
        FirstName = firstName;
        LastName = lastName;
        Patronimic = patronomic;
        About = about;
        Birthday = birthday;
        Country = country;
    }
}