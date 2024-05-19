using System.Net;
using System.Net.Http.Json;
using PokemonsAPI.Models;

namespace PokemonAPI.IntegrationTest;

[TestClass] 
public class GetAllPokemonsTestClass
{
    private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri( "http://localhost:5022" ) }; 
    
    [TestMethod]
    public async Task GetAllPokemons_ReturnsOkStatus() {
        var response = await HttpClient.GetAsync("/api/Pokemon/poke");
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }
    
    [TestMethod]
    public async Task GetAllPokemons_ReturnsAllPokemons() {
        var allPokemons = await HttpClient.GetFromJsonAsync<PokemonResponse>("/api/Pokemon/poke");
        Assert.IsNotNull(allPokemons);
        Assert.IsTrue(allPokemons.Results!.Any());
    }
    
    [TestMethod]
    public async Task ReturnAllPokemons() {
        var myPokemons = await HttpClient.GetFromJsonAsync<PokemonResponse>("/api/Pokemon/poke");
        var apiPokemons = await HttpClient.GetFromJsonAsync<PokemonResponse>("https://pokeapi.co/api/v2/pokemon?limit=1302");
        Assert.AreEqual(myPokemons!.Count, apiPokemons!.Count);
    }
    
    [TestMethod]
    public async Task PokemonMatching() {
        var pokemons = await HttpClient.GetFromJsonAsync<PokemonResponse>("/api/Pokemon/poke");
        var api = await HttpClient.GetFromJsonAsync<PokemonResponse>("https://pokeapi.co/api/v2/pokemon?limit=1302");
        var pokemonsName = pokemons!.Results;
        var apiPokemonName = api!.Results;
        bool flag = true;
        Console.WriteLine(flag);
        for ( int counter = 0; counter < pokemons.Count; counter++ ){
            Console.WriteLine(pokemonsName![counter].Name);
            Console.WriteLine(counter);
            if ( pokemonsName![counter].Name != apiPokemonName![counter].Name ) {
                Console.WriteLine(pokemonsName[counter].Name);
                flag = false;
                break;
            }
        }
        Assert.IsTrue(flag);
    }
}