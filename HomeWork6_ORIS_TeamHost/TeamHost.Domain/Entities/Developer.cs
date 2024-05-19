using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities;
public class Developer : BaseAuditableEntity {
    public string Name { get; set; } = default!;
    public Guid? CountryId { get; set; }
    public Country? Country { get; set; }
    public ICollection<Game> Games { get; set; } = new List<Game>();
}