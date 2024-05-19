using PokemonsAPI.Models;

namespace PokemonsAPI.Services;

public interface IPokeService
{
    public Task<PokemonResponse> GetAllPokemons();

    public Task<Pokemon> GetById(int id);

    public Task<Pokemon> GetByName(string name);

    public Task<List<PokemonResult>> Filter(string name);
    
    public Task<Move> GetType(string typeId);

    public Task<PokemonResponse> ForPaginashion(int offset);
}