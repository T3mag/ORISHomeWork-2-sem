using TeamHost.Domain.Common;
namespace TeamHost.Domain.Entities{
    public class StaticFile : BaseAuditableEntity{
        public StaticFile(string path, string name){
            Path = path;
            Name = name;
            Extension = name.Split('.').LastOrDefault();
        }
        public StaticFile(){ }
        public string Path { get; set; }
        public int? Size { get; set; }
        public string Name { get; set; }
        public string? Extension { get; private set; }
        public Game? Game { get; set; }
        public int? GameId { get; set; }
        public Chats? Chats { get; set; }
        public int? ChatId { get; set; }
        public Platform? Platform { get; set; }
    }
}
