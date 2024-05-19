using TeamHost.Domain.Entities;

namespace TeamHost.Application.Contracts.Profile.PostRegister;


public class PostRegisterRequest
{

    public PostRegisterRequest()
    {
    }


    public PostRegisterRequest(PostRegisterRequest request)
    {
        Username = request.Username;
        Email = request.Email;
        Password = request.Password;
    }
    

    public string Username { get; set; } = default!;


    public string Email { get; set; } = default!;


    public string Password { get; set; } = default!;
}