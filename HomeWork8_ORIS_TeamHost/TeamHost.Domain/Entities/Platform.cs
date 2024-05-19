using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities{
    public class Platform : BaseEntity{
        public string Name { get; set; }
        public string Code { get; set; }
        public int? ImageId { get; set; }
        public StaticFile? Image { get; set; }
        public List<Game> Games { get; set; }
    }
}
