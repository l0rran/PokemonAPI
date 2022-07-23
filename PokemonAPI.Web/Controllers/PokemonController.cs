using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Repository.Data;
using PokemonAPI.Repository.DTO.Pokemon;
using PokemonAPI.Repository.Models.Pokemon;
using PokemonAPI.Repository.Services;
using System.Net;

namespace PokemonAPI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            
            _pokemonService = pokemonService;
        }

        [HttpGet(Name = "GetPokemon")]
        public async Task<ActionResult<IEnumerable<PokemonMinimalDTO>>> Get()
        {
            return await _pokemonService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PokemonDTO>> Get(int id)
        {
            PokemonDTO? pokemon = await _pokemonService.GetByIdAsync(id);
            if (pokemon is null)
            {
                return NotFound($"Pokemon id: {id} not found.");
            }

            if (!TryValidateModel(pokemon, nameof(Pokemon)))
            {
                return BadRequest();
            }

            return pokemon;
        }

    }
}
