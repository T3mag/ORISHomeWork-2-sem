namespace TeamHost.Application.Contracts.Profile.PostLogin;
public class PostLoginRequest{
    public PostLoginRequest(){}
    public PostLoginRequest(PostLoginRequest request){
        Username = request.Username;
        Password = request.Password;
    }
    public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
}