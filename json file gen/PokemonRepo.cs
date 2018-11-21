using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_file_gen
{
    class PokemonRepo
    {
        private static List<Triple> triples = new List<Triple>();
        
        public static List<Triple> GetPokemonTypeTripleFiles()
        {
            triples.Add(new Triple("/pokemons/Rattata.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Raticate.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Spearow.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Spearow.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Fearow.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Fearow.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Arbok.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Ekans.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Nidoran ♀ (Female).json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Nidorina.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Nidoqueen.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Nidoqueen.json", "/pokemonHasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Nidoran ♂ (Male).json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Nidorino.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Nidoking.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Nidoking.json", "/pokemonHasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Zubat.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Zubat.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Golbat.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Golbat.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Oddish.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Oddish.json", "/pokemonHasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Gloom.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Gloom.json", "/pokemonHasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Vileplume.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Vileplume.json", "/pokemonHasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Paras.json", "/pokemonHasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Paras.json", "/pokemonHasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Parasect.json", "/pokemonHasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Parasect.json", "/pokemonHasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Venonat.json", "/pokemonHasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Venonat.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Venomoth.json", "/pokemonHasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Venomoth.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Diglett.json", "/pokemonHasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Dugtrio.json", "/pokemonHasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Meowth.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Persian.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Psyduck.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Golduck.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Growlithe.json", "/pokemonHasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Arcanine.json", "/pokemonHasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Poliwag.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Poliwhirl.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Poliwrath.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Poliwrath.json", "/pokemonHasType", PokemonType.Fighting));
            triples.Add(new Triple("/pokemons/Bellsprout.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Bellsprout.json", "/pokemonHasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Weepinbell.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Weepinbell.json", "/pokemonHasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Victreebel.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Victreebel.json", "/pokemonHasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Farfetch'd.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Doduo.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Doduo.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Dodrio.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Dodrio.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Grimer.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Muk.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Shellder.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Cloyster.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Cloyster.json", "/pokemonHasType", PokemonType.Ice));
            triples.Add(new Triple("/pokemons/Drowzee.json", "/pokemonHasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Hypno.json", "/pokemonHasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Krabby.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Kingler.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Voltorb.json", "/pokemonHasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Electrode.json", "/pokemonHasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Cubone.json", "/pokemonHasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Marowak.json", "/pokemonHasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Hitmonlee.json", "/pokemonHasType", PokemonType.Fighting));
            triples.Add(new Triple("/pokemons/Hitmonchan.json", "/pokemonHasType", PokemonType.Fighting));
            triples.Add(new Triple("/pokemons/Lickitung.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Koffing.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Weezing.json", "/pokemonHasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Rhyhorn.json", "/pokemonHasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Rhyhorn.json", "/pokemonHasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Rhydon.json", "/pokemonHasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Rhydon.json", "/pokemonHasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Chansey", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Horsea", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Seadra.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Goldeen.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Seaking.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Staryu.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Starmie.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Starmie.json", "/pokemonHasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Electabuzz.json", "/pokemonHasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Magmar.json", "/pokemonHasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Pinsir.json", "/pokemonHasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Tauros.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Lapras.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Lapras.json", "/pokemonHasType", PokemonType.Ice));
            triples.Add(new Triple("/pokemons/Ditto.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Eevee.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Vaporeon.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Jolteon.json", "/pokemonHasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Porygon.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Kabuto.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Kabuto.json", "/pokemonHasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Kabutops.json", "/pokemonHasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Kabutops.json", "/pokemonHasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Snorlax.json", "/pokemonHasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Moltres.json", "/pokemonHasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Moltres.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Zapdos.json", "/pokemonHasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Zapdos.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Articuno.json", "/pokemonHasType", PokemonType.Ice));
            triples.Add(new Triple("/pokemons/Articuno.json", "/pokemonHasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Mewtwo.json", "/pokemonHasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Mew.json", "/pokemonHasType", PokemonType.Psychic));
            return triples;
        }
        public static List<Triple> GetTypeRelations() {
            //Electric
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Good  ,PokemonType.Water));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Bad  ,PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Bad  ,PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Electric, RelationType.NoEffect  ,PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Good  ,PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal  ,PokemonType.Fairy));
            //Grass
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Good, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Bad, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Bad, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Electric, RelationType.NoEffect, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Good, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Electric, RelationType.Normal, PokemonType.Fairy));
            return triples;
        }
       
    }
    
}
