namespace TeamHost.Application.Features.Games.DTOs;
public class GetByIdGameResponse{
    public string? Name { get; set; }
    public string? MainImage { get; set; }
    public List<string?> MediaFiles { get; set; }
    public string? Description { get; set; }
    public double Rating { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public List<string?> Platforms { get; set; }
    public List<string> Categories { get; set; }
    public string? Company { get; set; }
    public decimal Price { get; set; }
}