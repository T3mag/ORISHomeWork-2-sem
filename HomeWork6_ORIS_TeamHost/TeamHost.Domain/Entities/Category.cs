using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities;
public class Category : BaseAuditableEntity {
    public string Name { get; set; } = default!;
    public ICollection<Game> Games { get; set; } = new List<Game>();
}