using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_file_gen
{
    class Pokemon
    {
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("img")]
        public string Image { get; set; }
        [JsonProperty("height")]
        public string Height { get; set; }
        [JsonProperty("weight")]
        public string Weight { get; set; }
       
    }
    
}
