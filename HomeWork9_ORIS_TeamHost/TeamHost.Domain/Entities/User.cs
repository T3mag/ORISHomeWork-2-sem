using Microsoft.AspNetCore.Identity;
namespace TeamHost.Domain.Entities;
public class User : IdentityUser<Guid>{
    public UserInfo UserInfo { get; set; }
}