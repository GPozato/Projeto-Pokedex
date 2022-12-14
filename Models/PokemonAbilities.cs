using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("PokemonAbilities")]
    public class PokemonAbilities
    {
        [Key, Column(Order = 1)]
        public uint PokemonNumber { get; set; }
        [ForeignKey("PokemonNumber")]
        public Pokemons Pokemon { get; set; } = new();

        [Key, Column(Order = 2)]
        public uint AbilityId { get; set; }
        [ForeignKey("AbilityId")]
        public Abilities Ability { get; set; } = new();

    }
}