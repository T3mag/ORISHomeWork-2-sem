using TeamHost.Domain.Entities;
namespace TeamHost.Application.Contracts.Games.GetAllGames;
public class GetAllGamesResponse{
    public GetAllGamesResponse(List<GetAllGamesResponseItem> entities, int totalCount){
        Entities = entities;
        TotalCount = totalCount;
    }
    public List<GetAllGamesResponseItem> Entities { get; }
    public int TotalCount { get; set; }
}