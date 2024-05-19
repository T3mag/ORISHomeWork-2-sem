namespace PokemonsAPI.Models;

public class PokemonResponse
{
    /// <summary>
    /// Кол-во пришедших покемонов
    /// </summary>
    public int Count { get; set; }
    
    /// <summary>
    /// Список пришедших покемонов
    /// </summary>
    public List<PokemonResult>? Results { get; set; }
}