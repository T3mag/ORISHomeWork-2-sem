using Newtonsoft.Json;
using PokemonsAPI.Models;

namespace PokemonsAPI.Services;

public class PokeService : IPokeService
{
    /// <summary>
    /// Получить всех покемонов 
    /// </summary>
    /// <returns>Кол-во и список всех покемонов</returns>
    public async Task<PokemonResponse> GetAllPokemons()
    {
        var client = new HttpClient();
        var poke = await client.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=1302");

        if (poke.IsSuccessStatusCode)
        {
            var pokejson = await poke.Content.ReadAsStringAsync();
            var pokeData = JsonConvert.DeserializeObject<PokemonResponse>(pokejson);
            return pokeData!;
        }

        return null!;
    }
    /// <summary>
    /// Получить покемона по Id
    /// </summary>
    /// <param name="id">Id покемона</param>
    /// <returns>Покемон</returns>
    public async Task<Pokemon> GetById(int id)
    {
        if (id <= 0)
        {
            return null!;
        }

        var client = new HttpClient();
        var poke = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}/");
        if (poke.IsSuccessStatusCode)
        {
            var pokejson = await poke.Content.ReadAsStringAsync();
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(pokejson);
            return pokemon!;
        }

        return null!;
    }
    /// <summary>
    /// Получить покемона по имени
    /// </summary>
    /// <param name="name">Имя покемона</param>
    /// <returns>Покемон</returns>
    public async Task<Pokemon> GetByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null!;
        }
        
        var client = new HttpClient();
        var poke = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name}/");
        if (poke.IsSuccessStatusCode)
        {
            var pokejson = await poke.Content.ReadAsStringAsync();
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(pokejson);
            return pokemon!;
        }

        return null!;
    }
    /// <summary>
    /// Получить мув покемона
    /// </summary>
    /// <param name="typeName">название мува</param>
    /// <returns>Мув покемона</returns>
    public async Task<Move> GetType(string typeName)
    {
        if (string.IsNullOrEmpty(typeName))
        {
            return null!;
        }
        var client = new HttpClient();
        var poke = await client.GetAsync($"https://pokeapi.co/api/v2/move/{typeName}");
        
        if (poke.IsSuccessStatusCode)
        {
            var pokejson = await poke.Content.ReadAsStringAsync();
            var pokemon = JsonConvert.DeserializeObject<Move>(pokejson);
            return pokemon!;
        }
        return null!;
    }

    /// <summary>
    /// Получить несколько покемонов для пагинации
    /// </summary>
    /// <param name="offset">кол-во пришедших покемонов</param>
    /// <returns>покемоны</returns>
    public async Task<PokemonResponse> ForPaginashion(int offset)
    {
        var client = new HttpClient();
        var poke = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon?offset={offset}&limit=49");
        
        if (poke.IsSuccessStatusCode)
        {
            var pokejson = await poke.Content.ReadAsStringAsync();
            var pokemon = JsonConvert.DeserializeObject<PokemonResponse>(pokejson);
            return pokemon!;
        }
        return null!;
    }
    /// <summary>
    /// Фильтрация покемонов
    /// </summary>
    /// <param name="name">часть или полное имя покемона</param>
    /// <returns>возможные варианты покемонов или определенный покемон</returns>
    public async Task<List<PokemonResult>> Filter(string name)
    {
        var pokemons = await GetAllPokemons();
        if (String.IsNullOrEmpty(name))
            return pokemons.Results!;

        List<PokemonResult> pokeFilter = new List<PokemonResult>();
        foreach (var pokeName in pokemons.Results!)
        {
            if (pokeName.Name!.Contains(name))
            {
                pokeFilter.Add(pokeName);
            }
        }
        return pokeFilter;
    }
}