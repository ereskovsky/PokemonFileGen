using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_file_gen
{
    class TripleDoc
    {
        [JsonProperty("triple")]
        public Triple Triple { get; set; }
    }
}
