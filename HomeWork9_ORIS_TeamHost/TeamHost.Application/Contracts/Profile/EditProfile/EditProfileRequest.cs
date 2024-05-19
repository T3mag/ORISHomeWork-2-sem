using Microsoft.AspNetCore.Http;
namespace TeamHost.Application.Contracts.Profile.EditProfile;
public class EditProfileRequest{
    public EditProfileRequest(){}
    public EditProfileRequest(EditProfileRequest request){
        FirstName = request.FirstName;
        LastName = request.LastName;
        Patronymic = request.Patronymic;
        About = request.About;
        Birthday = request.Birthday;
        Country = request.Country;
        ProfileImage = request.ProfileImage;
    }
    public string FirstName { get; set; } = default!;    
    public string LastName { get; set; } = default!;
    public string? Patronymic { get; set; }
    public string? About { get; set; }
    public DateTime? Birthday { get; set; }
    public IFormFile? ProfileImage { get; set; }
    public Guid? Country { get; set; }
}