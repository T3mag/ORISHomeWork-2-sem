using TeamHost.Domain.Common;

namespace TeamHost.Domain.Entities{
    public class Country : BaseEntity{
        public uint Code { get; set; }
        public string Name { get; set; }
        public string? Fullname { get; set; }
        public string? Aplha2 { get; set; }
        public string? Aplha3 { get; set; }
        public List<Company> Companies { get; set; } = new List<Company>();
        public List<UserInfo> Users { get; set; } = new List<UserInfo>();
        public Country(){}
        public Country(int id, uint code, string name, string fullname, string aplha2 , string aplha3){
            Id = id;
            Code = code;
            Name = name;
            Fullname = fullname;
            Aplha2 = aplha2;
            Aplha3 = aplha3;
        }
    }
}
