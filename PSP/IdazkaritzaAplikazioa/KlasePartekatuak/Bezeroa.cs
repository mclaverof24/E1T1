using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KlasePartekatuak
{
    public class Bezeroa
    {
        public int Id { get; set; }
        public string Izena { get; set; }
        public string OstatuMota { get; set; }
        
    }
}
