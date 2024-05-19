using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities;
public class Game : BaseAuditableEntity {
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? ShortDescription { get; set; }
    public float Rating { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public Guid DeveloperId { get; set; }
    public Developer? Developer { get; set; }
    public Guid MainImageId { get; set; }
    public MediaFile? MainImage { get; set; }
    public ICollection<Platform> Platforms { get; set; }
    public ICollection<MediaFile> MediaFiles { get; set; } = new List<MediaFile>();
    public ICollection<Category> Categories { get; set; } = new List<Category>();
}