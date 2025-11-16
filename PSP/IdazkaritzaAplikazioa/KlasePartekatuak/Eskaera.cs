using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KlasePartekatuak
{
    public class Eskaera
    {
        //[JsonIgnore]
        //public int Id { get; set; }
        [JsonIgnore]
        public Bezeroa Bezeroa { get; set; }
        [JsonIgnore]
        public Langile Langilea { get; set; }
        public string Mota { get; set; }
        [JsonIgnore]
        public bool Beteta { get; set; }
        [JsonIgnore]
        public int TaulaErrenkadaIndizea { get; set; }

        public static readonly Dictionary<string,int> MotaDenbora = new Dictionary<string, int>
        {
            { "Zaborra", 1000 },
            { "Jatetxea", 1000 },
            { "Eskuoihalak", 2000 },
            { "Izarak", 3000 }
        };
    }

    
}
