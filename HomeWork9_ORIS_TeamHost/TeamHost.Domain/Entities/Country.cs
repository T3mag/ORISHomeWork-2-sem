using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities;
public class Country : BaseAuditableEntity{
    public string Name { get; set; } = default!;
    public int Code { get; set; }
    public string? AplhaTwo { get; set; }
    public string? AplhaThree { get; set; }
    public ICollection<Developer> Developers { get; set; } = new List<Developer>();
    public ICollection<UserInfo> Users { get; set; } = new List<UserInfo>();
}