using TeamHost.Domain.Common;
namespace TeamHost.Application.Contracts.Games.GetAllGames;
public class GetAllGamesResponseItem{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public List<string?>? ImageUrl { get; set; }
    public string? ShortDescription { get; set; }
    public double Rating { get; set; }
    public string? MainImage { get; set; }
    public List<string?>? LastImages { get; set; }
    public List<string?>? Platforms { get; set; }
    public decimal Price { get; set; }
    public List<string>? Category { get; set; }
}