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
            triples.Add(new Triple("/pokemons/Bulbasaur.json", "hasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Bulbasaur.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Ivysaur.json", "hasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Ivysaur.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Venusaur.json", "hasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Venusaur.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Charmander.json", "hasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Charmeleon.json", "hasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Charizard.json", "hasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Squirtle.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Wartortle.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Blastoise.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Caterpie.json", "hasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Metapod.json", "hasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Butterfree.json", "hasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Butterfree.json", "hasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Weedle.json", "hasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Weedle.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Kakuna.json", "hasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Kakuna.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Beedrill.json", "hasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Beedrill.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Pidgey.json", "hasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Pidgey.json", "hasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Pidgeotto.json", "hasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Pidgeotto.json", "hasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Pidgeot.json", "hasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Pidgeot.json", "hasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Pikachu.json", "hasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Raichu.json", "hasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Sandshrew.json", "hasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Sandslash.json", "hasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Clefairy.json", "hasType", PokemonType.Fairy));
            triples.Add(new Triple("/pokemons/Clefable.json", "hasType", PokemonType.Fairy));
            triples.Add(new Triple("/pokemons/Vulpix.json", "hasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Ninetales.json", "hasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Jigglypuff.json", "hasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Jigglypuff.json", "hasType", PokemonType.Fairy));
            triples.Add(new Triple("/pokemons/Wigglytuff.json", "hasType", PokemonType.Normal));
            triples.Add(new Triple("/pokemons/Wigglytuff.json", "hasType", PokemonType.Fairy));
            triples.Add(new Triple("/pokemons/Mankey.json", "hasType", PokemonType.Fighting));
            triples.Add(new Triple("/pokemons/Primeape.json", "hasType", PokemonType.Fighting));
            triples.Add(new Triple("/pokemons/Abra.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Kadabra.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Alakazam.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Machop.json", "hasType", PokemonType.Fighting));
            triples.Add(new Triple("/pokemons/Machoke.json", "hasType", PokemonType.Fighting));
            triples.Add(new Triple("/pokemons/Machamp.json", "hasType", PokemonType.Fighting));
            triples.Add(new Triple("/pokemons/Tentacool.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Tentacool.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Tentacruel.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Tentacruel.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Geodude.json", "hasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Geodude.json", "hasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Graveler.json", "hasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Graveler.json", "hasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Golem.json", "hasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Golem.json", "hasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Ponyta.json", "hasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Rapidash.json", "hasType", PokemonType.Fire));
            triples.Add(new Triple("/pokemons/Slowpoke.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Slowpoke.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Slowbro.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Slowbro.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Magnemite.json", "hasType", PokemonType.Steel));
            triples.Add(new Triple("/pokemons/Magnemite.json", "hasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Magneton.json", "hasType", PokemonType.Steel));
            triples.Add(new Triple("/pokemons/Magneton.json", "hasType", PokemonType.Electric));
            triples.Add(new Triple("/pokemons/Seel.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Dewgong.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Gastly.json", "hasType", PokemonType.Ghost));
            triples.Add(new Triple("/pokemons/Gastly.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Haunter.json", "hasType", PokemonType.Ghost));
            triples.Add(new Triple("/pokemons/Haunter.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Gengar.json", "hasType", PokemonType.Ghost));
            triples.Add(new Triple("/pokemons/Gengar.json", "hasType", PokemonType.Poison));
            triples.Add(new Triple("/pokemons/Onix.json", "hasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Onix.json", "hasType", PokemonType.Ground));
            triples.Add(new Triple("/pokemons/Exeggcute.json", "hasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Exeggcute.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Exeggutor.json", "hasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Exeggutor.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Tangela.json", "hasType", PokemonType.Grass));
            triples.Add(new Triple("/pokemons/Mr. Mime.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Mr. Mime.json", "hasType", PokemonType.Fairy));
            triples.Add(new Triple("/pokemons/Scyther.json", "hasType", PokemonType.Bug));
            triples.Add(new Triple("/pokemons/Scyther.json", "hasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Jynx.json", "hasType", PokemonType.Ice));
            triples.Add(new Triple("/pokemons/Jynx.json", "hasType", PokemonType.Psychic));
            triples.Add(new Triple("/pokemons/Magikarp.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Gyarados.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Gyarados.json", "hasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Omanyte.json", "hasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Omanyte.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Omastar.json", "hasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Omastar.json", "hasType", PokemonType.Water));
            triples.Add(new Triple("/pokemons/Aerodactyl.json", "hasType", PokemonType.Rock));
            triples.Add(new Triple("/pokemons/Aerodactyl.json", "hasType", PokemonType.Flying));
            triples.Add(new Triple("/pokemons/Dratini.json", "hasType", PokemonType.Dragon));
            triples.Add(new Triple("/pokemons/Dragonair.json", "hasType", PokemonType.Dragon));
            triples.Add(new Triple("/pokemons/Dragonite.json", "hasType", PokemonType.Dragon));
            triples.Add(new Triple("/pokemons/Dragonite.json", "hasType", PokemonType.Flying));
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
            triples.Add(new Triple(PokemonType.Grass, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Bad, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Good, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Bad, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Bad, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Good, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Bad, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Bad, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Good, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Bad, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Grass, RelationType.Normal, PokemonType.Fairy));

            //Ice
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Bad, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Bad, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Good, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Bad, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Good, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Good, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Good, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Ice, RelationType.Normal, PokemonType.Fairy));


            //Fighting

            triples.Add(new Triple(PokemonType.Fighting, RelationType.Good, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Normal, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Normal, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Good, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Bad, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Bad, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Bad, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Bad, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Good, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.NoEffect, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Good, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Good, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Fighting, RelationType.Bad, PokemonType.Fairy));


            //Poison

            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Good, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Bad, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Bad, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Bad, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Bad, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Poison, RelationType.NoEffect, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Poison, RelationType.Good, PokemonType.Fairy));


            //Ground

            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Good, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Good, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Bad, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Good, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Ground, RelationType.NoEffect, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Bad, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Good, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Good, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Ground, RelationType.Normal, PokemonType.Fairy));


            //Flying
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Bad, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Good, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Good, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Good, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Bad, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Flying, RelationType.Normal, PokemonType.Fairy));



            //Psychic
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Good, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Good, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Bad, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.NoEffect, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Psychic, RelationType.Normal, PokemonType.Fairy));


            //Bug
            triples.Add(new Triple(PokemonType.Bug, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Bad, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Good, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Bad, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Bad, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Bad, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Good, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Bad, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Good, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Bug, RelationType.Bad, PokemonType.Fairy));

            //Rock

            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Good, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Good, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Bad, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Bad, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Good, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Good, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Rock, RelationType.Normal, PokemonType.Fairy));


            //
            triples.Add(new Triple(PokemonType.Ghost, RelationType.NoEffect, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Good, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Good, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Bad, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Ghost, RelationType.Normal, PokemonType.Fairy));

            //Dragon
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Good, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Dragon, RelationType.NoEffect, PokemonType.Fairy));

            //Dark
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Bad, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Good, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Good, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Bad, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Normal, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Dark, RelationType.Bad, PokemonType.Fairy));

            //Steel
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Bad, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Bad, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Bad, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Good, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Good, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Normal, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Steel, RelationType.Good, PokemonType.Fairy));




            //Fairy
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Normal));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Bad, PokemonType.Fire));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Water));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Electric));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Grass));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Ice));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Good, PokemonType.Fighting));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Bad, PokemonType.Poison));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Ground));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Flying));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Psychic));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Bug));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Rock));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Ghost));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Good, PokemonType.Dragon));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Good, PokemonType.Dark));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Bad, PokemonType.Steel));
            triples.Add(new Triple(PokemonType.Fairy, RelationType.Normal, PokemonType.Fairy));
            return triples;
        }
       
    }
    
}
