namespace PokemonsAPI.Models;

public class Move
{
    /// <summary>
    /// Название хода
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Адрес на api
    /// </summary>
    public string? Url { get; set; }
    /// <summary>
    /// Тип
    /// </summary>
    public PokemonType? Type { get; set; }
}