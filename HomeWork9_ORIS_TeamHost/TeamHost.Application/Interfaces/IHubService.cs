using TeamHost.Application.Models;
namespace TeamHost.Application.Interfaces;
public interface IHubService{
    public Task SendNewMessageAsync(SendMessageModel model);
}