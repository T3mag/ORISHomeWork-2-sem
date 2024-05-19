namespace TeamHost.Application.Features.Games.DTOs;
public class GetGamesItemDto{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string? MainImagePath { get; set; }
    public float Rating { get; set; }
    public List<string> Categories { get; set; }
    public List<string> Platforms { get; set; }
}