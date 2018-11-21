using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_file_gen
{
    class Triple
    {
        const string prefix = "https://pokemon.ereskovsky.com";
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("predicate")]
        public string Predicate { get; set; }
        [JsonProperty("object")]
        public string Object { get; set; }
        public Triple(string subj, string pred, string obj)
        {
            Subject = /*prefix + */subj;
            Object = obj;
            Predicate = prefix + pred;
        }
    }
    
}
