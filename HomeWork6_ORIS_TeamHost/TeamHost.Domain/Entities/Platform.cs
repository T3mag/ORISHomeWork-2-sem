using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities;
public class Platform : BaseEntity {
    public string? Name { get; set; }
    public string? Code { get; set; }
    public MediaFile? MediaFile { get; set; }
    public ICollection<Game> Games { get; set; } = new List<Game>();
}   