using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedTestAPI.Models
{
    public class NumberRequestDTO
    {
        [JsonProperty("number")]
        public int[] Number { get; set; }
    }

    public class NumberResponseDTO
    {
        [JsonProperty("GCD")]
        public int GCD { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
