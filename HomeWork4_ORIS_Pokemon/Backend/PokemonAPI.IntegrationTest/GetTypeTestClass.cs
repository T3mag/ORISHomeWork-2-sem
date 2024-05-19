using System.Net;
using System.Net.Http.Json;
using PokemonsAPI.Models;

namespace PokemonAPI.IntegrationTest;
[TestClass]
public class GetTypeTestClass{
    private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5022") };
    
    [TestMethod]
    public async Task GetPokemonType_ReturnsOkStatus() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/ByType/tackle");
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }

    [TestMethod]
    public async Task GetPokemonType_ReturnsPokemonType(){
        var pokemonType = await HttpClient.GetFromJsonAsync<Move>($"/api/Pokemon/ByType/tackle");
        Assert.IsNotNull(pokemonType);
        Assert.AreEqual(typeName, pokemonType.Name);
    }

    [TestMethod]
    public async Task GetPokemonType_EmptyTypeName_ReturnsNotFound() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/ByType/");
        Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
    }

    [TestMethod]
    public async Task GetType_FromAPI() {
        var pokemonType = await HttpClient.GetFromJsonAsync<Move>($"/api/Pokemon/ByType/mega-punch");
        var apiPokemon = await HttpClient.GetFromJsonAsync<Move>($"https://pokeapi.co/api/v2/move/mega-punch");
        Assert.AreEqual(pokemonType!.Name, apiPokemon!.Name);
    }
}