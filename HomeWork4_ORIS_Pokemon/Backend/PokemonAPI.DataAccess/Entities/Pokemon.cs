namespace PokemonAPI.DataAccess.Entities;
public class Pokemon{ 
    public int Identifire { get; set; }
    public string? Name { get; set; }
    public int? Height { get; set; }
    public int? Weight { get; set; }
    public string? ImageUrl {
        get {
            return $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/home/{Identifire}.png";
        }
    }
    public Abilities[]? Abilities { get; set; }
    public Types[]? Types { get; set; }
    public Moves[]? Moves { get; set; }
    public Stats[]? Stats { get; set; }
}