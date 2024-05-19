using System.Net;
using System.Net.Http.Json;
using PokemonsAPI.Models;

namespace PokemonAPI.IntegrationTest;

[TestClass] 
public class FilterPokemonsTestClass {
    private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5022") }; 

    [TestMethod]
    public async Task GetPokemonsByFilter_ReturnsOkStatus() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/Filter/fire");
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }
    [TestMethod]
    public async Task GetPokemonsByFilter_ReturnsFilteredPokemons() {
        var filteredPokemons = await HttpClient.GetFromJsonAsync<List<PokemonResult>>($"/api/Pokemon/Filter/saur");
        Assert.IsNotNull(filteredPokemons);
        Assert.IsTrue(filteredPokemons.Any());
    }
    
    [TestMethod]
    public async Task FindPokemonByName() {
        var filteredPokemons = await HttpClient.GetFromJsonAsync<List<PokemonResult>>($"/api/Pokemon/Filter/bulbasaur");
        if (filteredPokemons!.Count == 1) {
            Assert.AreEqual(filteredPokemons[0].Name, filter);
        } else {
            Assert.AreEqual(2,1);
        }
    }
    
    [TestMethod]
    public async Task GetPokemonsByFilter_EmptyResult_ReturnsNoContent() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/Filter/nonexistent");
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }
    
    [TestMethod]
    public async Task GetPokemonsByFilter_EmptyResult() {
        var filter = "1337";
        var response = await HttpClient.GetFromJsonAsync<List<PokemonResult>>($"/api/Pokemon/Filter/1337");
        Assert.AreEqual(0, response!.Count);
    }
    
    [TestMethod]
    public async Task GetPokemonsByFilter_InvalidFilter_ReturnsNotFound() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/Filter/");
        Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
    }
}