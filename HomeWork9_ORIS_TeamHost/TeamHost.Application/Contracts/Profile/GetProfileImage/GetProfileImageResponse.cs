namespace TeamHost.Application.Contracts.Profile.GetProfileImage;
public class GetProfileImageResponse{
    public string? ImageUrl { get; set; }
    public Guid? CurrentUserId { get; set; }
}