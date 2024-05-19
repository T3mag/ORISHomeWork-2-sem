using Microsoft.AspNetCore.Mvc;
using PokemonsAPI.Models;
using PokemonsAPI.Services;

namespace PokemonsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokeService _pokeService;
        private readonly ILogger<PokemonController> _logger;
    
        public PokemonController(IPokeService pokeApiService, ILogger<PokemonController> logger)
        {
            _pokeService = pokeApiService;
            _logger = logger;
        }
        
        /// <summary>
        /// Получить покемона по Id
        /// </summary>
        /// <param name="id">ID покемона</param>
        /// <returns>Покемона по Id</returns>
        
        [HttpGet("ById/{id}")]
        public Task<Pokemon> GetPokemonById([FromRoute]int id)
        {
            return _pokeService.GetById(id);
        }
        
        
        /// <summary>
        /// Получить покемона по имени
        /// </summary>
        /// <param name="name">Имя покемона</param>
        /// <returns>Покемон по имени</returns>
        [HttpGet("ByName/{name}")]
        public Task<Pokemon> GetPokemonByName([FromRoute]string name)
        {
            return _pokeService.GetByName(name);
        }
        
        
        /// <summary>
        /// Фильтрация покемонов по стрингу
        /// </summary>
        /// <param name="name">часть или полное имя покемона</param>
        /// <returns>Отфильтрованный список покемонов</returns>
        [HttpGet("Filter/{name}")]
        public async Task<List<PokemonResult>> GetByFilter([FromRoute] string name)
        {
           List<PokemonResult> filteredPokemons = await _pokeService.Filter(name);
           return filteredPokemons;
        }
        
        /// <summary>
        /// Получить тип по названию 
        /// </summary>
        /// <param name="typeName">typeName</param>
        /// <returns>Тип покемона</returns>
        
        [HttpGet("ByType/{typeName}")]
        public Task<Move> GetPokemonType([FromRoute]string typeName)
        {
            return _pokeService.GetType(typeName);
        }
        
        /// <summary>
        /// Получить несколько покемонов 
        /// </summary>
        /// <param name="offset">кол-во покемонов</param>
        /// <returns>Список Покемонов</returns>
        
        [HttpGet("Pagination/{offset}")]
        public Task<PokemonResponse> Pagination([FromRoute]int offset)
        {
            return _pokeService.ForPaginashion(offset);
        }
        
        /// <summary>
        /// Получить всех покемонов
        /// </summary>
        /// <returns>массив покемонов</returns>
        [HttpGet]
        [Route("poke")]
        public Task<PokemonResponse> GetAllPokemons()
        {
            return _pokeService.GetAllPokemons();
        }
    }
}
