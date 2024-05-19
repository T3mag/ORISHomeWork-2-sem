using Newtonsoft.Json;
using PokemonsAPI.Models;
using Type = System.Type;

namespace PokemonsAPI.Services;

public class PokeService : IPokeService
{

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