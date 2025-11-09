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
        [JsonIgnore]
        public NamedPipeServerStream Zerbitzaria { get; set; }
        [JsonIgnore]
        public StreamReader Reader { get; private set; }
        [JsonIgnore]
        public StreamWriter Writer { get; private set; }
        [JsonIgnore]
        public Process Prozesua { get; set; }
        [JsonIgnore]
        public Task Ataza { get; set; }

        
        public void BezeroaHasi()
        {
            Zerbitzaria = new NamedPipeServerStream("hodia" + Id);
            
            
            ProcessStartInfo info = new ProcessStartInfo(@"..\..\..\..\Bezeroa\bin\Debug\net8.0-windows\Bezeroa.exe");
            info.ArgumentList.Add(JsonSerializer.Serialize(this));
            info.CreateNoWindow = false;
            info.WindowStyle = ProcessWindowStyle.Normal;
            info.UseShellExecute = true;
            Prozesua = Process.Start(info);
            Ataza = Task.Run(BezeroaEntzun);
        }

        public void BezeroaEntzun() {

            Zerbitzaria.WaitForConnection();
            Reader = new StreamReader(Zerbitzaria);
            Writer= new StreamWriter(Zerbitzaria); // Autoflush aconsejable al parecer
            //Eskaerak jasotzera edo Bezeroak checkout sakatzera ixtera itxaron
        }

        public void EskaeraGehitu()
        {
            //BezeroaEntzun eskaera bat jasotzean, deserializatu eta BlockingCollectionera gehitu
        }

        public void CheckOut() {
            Zerbitzaria.Close();
            Zerbitzaria.Dispose();
            Prozesua.Kill();
            Prozesua.Close();
        }
    }
}
