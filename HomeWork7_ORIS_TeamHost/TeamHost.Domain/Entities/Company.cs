using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities{
    public class Company : BaseAuditableEntity{
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Game> Games { get; set; } = new List<Game>();
    }
}
