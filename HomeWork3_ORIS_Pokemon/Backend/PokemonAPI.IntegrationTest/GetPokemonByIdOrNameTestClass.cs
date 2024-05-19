using System.Net;
using System.Net.Http.Json;
using PokemonsAPI.Models;

namespace PokemonAPI.IntegrationTest;

[TestClass]
public class GetPokemonByIdOrNameTestClass
{
    private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri( "http://localhost:5022" ) }; 

    [TestMethod]
    public async Task GetPokemonById_ReturnsOkStatus() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/ById/1");
        Assert.AreEqual( HttpStatusCode.OK, response.StatusCode );
    }

    [TestMethod]
    public async Task GetPokemonById_FromPokeAPI() {
        var myPokemon = await HttpClient.GetFromJsonAsync<Pokemon>($"/api/Pokemon/ById/1");
        var apiPokemon = await HttpClient.GetFromJsonAsync<Pokemon>($"https://pokeapi.co/api/v2/pokemon/1/");
        Assert.AreEqual( myPokemon!.Name!,apiPokemon!.Name! );
    }
    
    [TestMethod]
    public async Task GetPokemonByName_ReturnsOkStatus() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/ByName/bulbasaur");
        Assert.AreEqual( HttpStatusCode.OK, response.StatusCode );
    }
    
    [TestMethod]
    public async Task GetPokemonByName_FromPokeAPI(){
        var pokemon = await HttpClient.GetFromJsonAsync<Pokemon>($"/api/Pokemon/ByName/pikachu");
        var api = await HttpClient.GetFromJsonAsync<Pokemon>($"https://pokeapi.co/api/v2/pokemon/pikachu/");
        Assert.AreEqual( pokemon!.Name!,api!.Name! );
    }
    
    [TestMethod]
    public async Task GetPokemonFromTwoMethods() {
        var myPokemonByName = await HttpClient.GetFromJsonAsync<Pokemon>($"/api/Pokemon/ByName/pikachu");
        var myPokemonById = await HttpClient.GetFromJsonAsync<Pokemon>($"/api/Pokemon/ById/25");
        Assert.AreEqual((myPokemonByName!.Weight , myPokemonByName.Height!),
            (myPokemonById!.Weight!, myPokemonById.Height!));
    }
    [TestMethod]
    public async Task GetPokemonById_InvalidId_ReturnsNoContent() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/ById/-1");
        Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
    }
    
    [TestMethod]
    public async Task GetPokemonByName_InvalidName_ReturnsNoContent() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/ById/string.Empty");
        Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
    }
}