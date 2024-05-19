using TeamHost.Domain.Entities;
namespace TeamHost.Application.Contracts.Profile.GetUserById;
public class GetUserByIdResponse{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string? Patronymic { get; set; }
    public DateTime? Birthday { get; set; }
    public string? About { get; set; }
    public Country? Country { get; set; }
    public string? ProfileImageUrl { get; set; }
}