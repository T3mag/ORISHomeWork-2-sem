using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities{
    public class Game : BaseAuditableEntity{
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        public float Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; } = default!;
        public int? MainFileId { get; set; }
        public List<StaticFile>? Images { get; set; } = default!;
        public List<Category> Category { get; set; }
        public List<Platform> Platforms { get; set; }
    }
}
