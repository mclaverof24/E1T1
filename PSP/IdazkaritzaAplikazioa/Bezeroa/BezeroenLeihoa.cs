using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlasePartekatuak;

namespace BezeroaApp
{
    public partial class BezeroenLeihoa : Form
    {
        public int BezeroId { get; set; }
        //Full-duplex komunikazio-eredua bi pipekin, noranzko bakarrekoa bakoitza.
        public NamedPipeClientStream IdazkaritzaEntzunPipe { get; set; }
        public NamedPipeClientStream IdazkaritzariBidaliPipe { get; set; }

        public StreamReader Reader { get; set; }
        public StreamWriter Writer { get; set; }
        public Task EntzunAtaza { get; set; }
        public void ZerbitzarietaraKonektatu()
        {
            Task.Run(EskaerenZerbitzariraKonektatu);
            EntzunAtaza = Task.Run(ZerbitzariaEntzun);
        }

        public void ZerbitzariaEntzun()
        {
            IdazkaritzaEntzunPipe = new NamedPipeClientStream(".", "mezuak" + BezeroId, PipeDirection.In);
            IdazkaritzaEntzunPipe.Connect();
            Reader = new StreamReader(IdazkaritzaEntzunPipe);
            while (IdazkaritzaEntzunPipe.IsConnected)
            {
                string mezuaJson = Reader.ReadLine();
                if (mezuaJson != null)
                {
                    Mezua mezua = JsonSerializer.Deserialize<Mezua>(mezuaJson);
                    Debug.WriteLine(mezua);
                    mezuakDataGridView.Invoke(new MethodInvoker(() => { mezuakDataGridView.Rows.Add(mezua.Data, mezua.Edukia); }));
                }

            }
        }

        public void EskaerenZerbitzariraKonektatu()
        {
            IdazkaritzariBidaliPipe = new NamedPipeClientStream(".", "eskaerak" + BezeroId, PipeDirection.Out);
            IdazkaritzariBidaliPipe.Connect();
            Writer = new StreamWriter(IdazkaritzariBidaliPipe) { AutoFlush = true };
        }

        public BezeroenLeihoa(Bezeroa bezeroa)
        {
            InitializeComponent();
            bezeroIdLabel.Text = bezeroa.Id.ToString();
            bezeroIzenaLabel.Text = bezeroa.Izena;
            ostatuMotaLabel.Text = bezeroa.OstatuMota;
            BezeroId = bezeroa.Id;
            eskaeraMotaComboBox.DataSource = Eskaera.MotaDenbora.Keys.ToList();
            ZerbitzarietaraKonektatu();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BezeroenLeihoa_Load(object sender, EventArgs e)
        {

        }

        private void mezuakDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EskaeraEgin_Click(object sender, EventArgs e)
        {
            if (eskaeraMotaComboBox.SelectedItem != null)
            {
                Eskaera eskaera = new Eskaera { Mota = eskaeraMotaComboBox.SelectedItem.ToString() };
                if (IdazkaritzariBidaliPipe.IsConnected)
                {
                    Writer.WriteLine(JsonSerializer.Serialize(eskaera));
                    Debug.WriteLine(eskaera.ToString());
                }
            }
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            IdazkaritzaEntzunPipe.Close();
            IdazkaritzaEntzunPipe.Dispose();
            IdazkaritzariBidaliPipe.Close();
            IdazkaritzariBidaliPipe.Dispose();
            Close();
        }
    }
}
