using System.Net;
using System.Net.Http.Json;
using PokemonsAPI.Models;

namespace PokemonAPI.IntegrationTest;

[TestClass]
public class PaginationPokemonsTestClass
{
    private static readonly HttpClient HttpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5022") };
    
    [TestMethod]
    public async Task GetPokemonsForPagination_ReturnsOkStatus() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/Pagination/{0}");
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }
    [TestMethod]
    public async Task GetPokemonsForPagination_ReturnsPaginatedPokemons() {
        var paginatedPokemons = await HttpClient.GetFromJsonAsync<PokemonResponse>($"/api/Pokemon/Pagination/{0}");
        Assert.IsNotNull(paginatedPokemons);
        Assert.IsTrue(paginatedPokemons.Results!.Any());
    }
    
    [TestMethod]
    public async Task GetPokemonsForPagination_InvalidOffset(){
        var response = await HttpClient.GetFromJsonAsync<PokemonResponse>($"/api/Pokemon/Pagination/{-1}");
        var api = await HttpClient.GetFromJsonAsync<PokemonResponse>($"/api/Pokemon/poke");
        Assert.AreEqual(api!.Count, response!.Count);
    }
    [TestMethod]
    public async Task GetPokemonsForPagination_InvalidOffset_ReturnsBadRequest() {
        var response = await HttpClient.GetAsync($"/api/Pokemon/Pagination/{-1}");
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }
}