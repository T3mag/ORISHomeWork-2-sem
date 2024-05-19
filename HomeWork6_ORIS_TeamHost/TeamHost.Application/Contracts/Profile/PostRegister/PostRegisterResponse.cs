namespace TeamHost.Application.Contracts.Profile.PostRegister;

public class PostRegisterResponse
{

    public bool IsSucceed { get; set; }


    public List<string>? Errors { get; set; }
}