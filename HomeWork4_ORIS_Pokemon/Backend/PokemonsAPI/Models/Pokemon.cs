namespace PokemonsAPI.Models;

public class Pokemon
{
    /// <summary>
    /// ID покемона
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Имя покемона
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// Рост покемона
    /// </summary>
    public int? Height { get; set; }
    
    /// <summary>
    /// Вес покемона
    /// </summary>
    public int? Weight { get; set; }
    
    /// <summary>
    /// Список Стат
    /// </summary>
    public List<Stats>? Stats { get; set; }
    
    /// <summary>
    /// Ссылка на картинку покемона
    /// </summary>
    public Sprites? Sprites { get; set; }
    
    /// <summary>
    /// Массив типов покемона
    /// </summary>
    public List<Types>? Types { get; set; }
    
    /// <summary>
    /// Массив абилок покемона
    /// </summary>
    public List<Abilities>? Abilities { get; set; }
    
    /// <summary>
    /// Массив мувов покемона
    /// </summary>
    public List<Moves>? Moves { get; set; }
}