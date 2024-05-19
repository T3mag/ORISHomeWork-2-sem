namespace PokemonsAPI.Models;

public class PokemonResponse
{
    public int Count { get; set; }
    public List<PokemonResult>? Results { get; set; }
}