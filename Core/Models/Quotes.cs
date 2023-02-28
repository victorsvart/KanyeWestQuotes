using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Quotes
    {
        public string Name { get; set; }
        public string Quote { get; set; }
        [JsonConstructor] public Quotes() { }
    }
}
