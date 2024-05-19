namespace PokemonAPI.DataAccess.Entities;

public class Abilities{
    public int Slot { get; set; }
    public Ability? Ability { get; set; }
}


public class Ability{
    public string Name { get; set; }
    public string Url { get; set; }
}