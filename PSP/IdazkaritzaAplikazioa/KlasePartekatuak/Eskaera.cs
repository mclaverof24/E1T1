using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KlasePartekatuak
{
    public class Eskaera
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Mota { get; set; }
        [JsonIgnore]
        public bool Beteta { get; set; }
    }
}
