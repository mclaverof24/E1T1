using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using KlasePartekatuak;

namespace Idazkaritza
{
    public class BezeroaCtrl
    {
        public Bezeroa Bezeroa { get; set; }
        public int BezeroId { get { return Bezeroa.Id; } } // propietate auxiliarra, comboboxean bindinga erabiltzeko
        public string BezeroIzena { get { return Bezeroa.Id +" - "+ Bezeroa.Izena; } } // propietate auxiliarra, comboboxean bindinga erabiltzeko
        public NamedPipeServerStream Zerbitzaria { get; set; }
        public StreamReader Reader { get; private set; }
        public StreamWriter Writer { get; private set; }
        public Process Prozesua { get; set; }
        public Task BezeroaEntzunAtaza { get; set; }


        public void BezeroarenZerbitzariaHasi()
        {
            Zerbitzaria = new NamedPipeServerStream("hodia" + Bezeroa.Id);
            Writer = new StreamWriter(Zerbitzaria);



            ProcessStartInfo info = new ProcessStartInfo(@"..\..\..\..\Bezeroa\bin\Debug\net8.0-windows\Bezeroa.exe");
            info.ArgumentList.Add(JsonSerializer.Serialize(Bezeroa));
            info.CreateNoWindow = false;
            info.WindowStyle = ProcessWindowStyle.Normal;
            info.UseShellExecute = true;
            Prozesua = Process.Start(info);
            BezeroaEntzunAtaza = Task.Run(BezeroaEntzun);
        }

        public void BezeroaEntzun()
        {

            Zerbitzaria.WaitForConnection();
            Reader = new StreamReader(Zerbitzaria);
            

            //Eskaerak jasotzera edo Bezeroak checkout sakatzera ixtera itxaron
            while (true)
            {
                //Reader.ReadLine
            }
        }

        public void MezuaBidali(Mezua mezua)
        {
            //Writer.AutoFlush = true; // Autoflush aconsejable al parecer
            //crea task que envía mensaje y cierra task, local. El task de entzun está como propiedad de Bezeroa porque esa task se queda escuchando desde iniciar el Bezeroa.
            //Writer.WriteLine
            //Zerbitzaria.WaitForConnection();
            if (Zerbitzaria.IsConnected)
            {
                Writer.AutoFlush = true;
                Task.Run(() =>
                {
                    Writer.WriteLine(JsonSerializer.Serialize(mezua));
                });
            }
        }

        public void EskaeraGehitu()
        {
            //BezeroaEntzun eskaera bat jasotzean, deserializatu eta BlockingCollectionera gehitu
        }

        public void CheckOut()
        {
            Zerbitzaria.Close();
            Zerbitzaria.Dispose();
            Prozesua.Kill();
            Prozesua.Close();
        }

    }
}
