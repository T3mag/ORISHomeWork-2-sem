namespace TeamHost.Application.Features.Games.DTOs{
    public class GetAllGamesResponse{
        public int TotalCount { get; set; }
        public List<GetGamesItemDto> Games { get; set; }
    }
}
