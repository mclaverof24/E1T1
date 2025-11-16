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
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace IdazkaritzaApp
{
    public class BezeroaCtrl
    {
        public IdazkaritzaAplikazioa IdazkaritzaErreferentzia { get; set; }
        public Bezeroa Bezeroa { get; set; }
        public int BezeroId { get { return Bezeroa.Id; } } // propietate auxiliarra, comboboxean bindinga erabiltzeko
        public string BezeroIzena { get { return Bezeroa.Id +" - "+ Bezeroa.Izena; } } // propietate auxiliarra, comboboxean bindinga erabiltzeko

        //Full-duplex komunikazio-eredua bi pipekin, noranzko bakarrekoa bakoitza.
        public NamedPipeServerStream BezeroaEntzunPipe { get; set; } 
        public NamedPipeServerStream BezeroariBidaliPipe { get; set; }

        public StreamReader Reader { get; private set; }
        public StreamWriter Writer { get; private set; }
        public Process Prozesua { get; set; }
        public Task BezeroaEntzunAtaza { get; set; }


        public void BezeroarenZerbitzariakHasi()
        {            
            ProcessStartInfo info = new ProcessStartInfo(@"..\..\..\..\Bezeroa\bin\Debug\net8.0-windows\BezeroaApp.exe");
            info.ArgumentList.Add(JsonSerializer.Serialize(Bezeroa));
            info.CreateNoWindow = false;
            info.WindowStyle = ProcessWindowStyle.Normal;
            info.UseShellExecute = true;
            
            // Bi ataza ezberdinetan sarrera eta irteera zerbitzariak prestatu, konexio itxaroten geratuko direnez, paraleloan egitea hobea da, interfaze grafikoa ez blokeatzeko tarte horretan.
            BezeroaEntzunAtaza = Task.Run(BezeroaEntzun);
            Task.Run(MezuZerbitzariaPrestatu);
            // Bezero honen aplikazioa simulatzeko prozesua hasi, behin zerbitzariak prestatuta. Azken hauek konexioa itxaroten daude eta, prozesua hastean, bere aldetik konektatuko da bezeroa bi zerbitzarietara.
            Prozesua = Process.Start(info);
        }

        public void BezeroaEntzun()
        {
            BezeroaEntzunPipe = new NamedPipeServerStream("eskaerak" + Bezeroa.Id, PipeDirection.In); // Soilik barrurako noranzkoa izango du, eskaerak jasotzeko.
            BezeroaEntzunPipe.WaitForConnection();
            Reader = new StreamReader(BezeroaEntzunPipe);
            

            //Eskaerak jasotzera edo Bezeroak checkout sakatzera itxaron
            while (BezeroaEntzunPipe.IsConnected)
            {
                string eskaeraJson = Reader.ReadLine();
                if (eskaeraJson != null)
                {
                    Eskaera eskaera = JsonSerializer.Deserialize<Eskaera>(eskaeraJson);
                    eskaera.Beteta = false;
                    eskaera.Bezeroa = Bezeroa;
                    eskaera.Langilea = IdazkaritzaAplikazioa.Langileak[new Random().Next(0, 2)];
                    IdazkaritzaErreferentzia.Invoke(new MethodInvoker(() => IdazkaritzaErreferentzia.EskaeraGehitu(eskaera)));
                    
                    IdazkaritzaErreferentzia.Eskaerak.Add(eskaera);
                }
            }
            try 
            { 
                IdazkaritzaErreferentzia.Invoke(new MethodInvoker(() => IdazkaritzaErreferentzia.Bezeroak.Remove(this)));
            }
            catch { }
        }

        public void MezuZerbitzariaPrestatu()
        {
            BezeroariBidaliPipe = new NamedPipeServerStream("mezuak" + Bezeroa.Id, PipeDirection.Out);// Soilik kanporako noranzkoa izango du, mezuak bidaltzeko.
            BezeroariBidaliPipe.WaitForConnection();
            Writer = new StreamWriter(BezeroariBidaliPipe) { AutoFlush=true};// Writer-aren AutoFlush propietatea true bezala hasierazten dugu Writer.Flush aurrezteko            
        }

        public void MezuaBidali(Mezua mezua)
        {
            
            if (BezeroariBidaliPipe.IsConnected)
            {
                Writer.WriteLine(JsonSerializer.Serialize(mezua));
            }
        }

        //public void EskaeraGehitu()
        //{
        //    //BezeroaEntzun eskaera bat jasotzean, deserializatu eta BlockingCollectionera gehitu
        //}

        //public void CheckOut()
        //{
        //    Zerbitzaria.Close();
        //    Zerbitzaria.Dispose();
        //    Prozesua.Kill();
        //    Prozesua.Close();
        //}

    }
}
