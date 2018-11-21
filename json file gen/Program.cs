using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace json_file_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateTypeRelationTriples();
        }

        public static void GeneratePokemonFiles() {
            string str = System.IO.File.ReadAllText("../../json1.json");
            List<Pokemon> list = JsonConvert.DeserializeObject<List<Pokemon>>(str);
            int i = 0;
            foreach (var item in list)
            {
                i++;
                var path = "../../pokemons/" + item.Name + ".json";
                System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(item));
                Console.WriteLine(item.Number);
            }
            Console.ReadKey();
        }
        public static void GeneratePokemonTypeTriples() {
            var pokemonTypeTriples = PokemonRepo.GetPokemonTypeTripleFiles();
            foreach (var item in pokemonTypeTriples)
            {
                Random rnd = new Random();
                int random = rnd.Next(1000000, 999999999);
                var path = "../../pokemonTypeTriples/pokemonHasType" + random +".json";
                TripleDoc trip = new TripleDoc { Triple = item };
                System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(trip));
                Thread.Sleep(100);
                Console.WriteLine(item.Subject);
            }
            Console.ReadKey();
        }
        public static void GenerateTypeRelationTriples() {
            var pokemonTypeTriples = PokemonRepo.GetTypeRelations();
            foreach (var item in pokemonTypeTriples)
            {
                var name = item.Subject.Replace("https://pokemon.ereskovsky.com", "") + item.Object.Replace("https://pokemon.ereskovsky.com", "");
                var path = $"../../typeRelation/{name}.json";
                TripleDoc trip = new TripleDoc { Triple = item };
                System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(trip));
                Thread.Sleep(100);
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
