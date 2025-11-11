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
        public NamedPipeClientStream Bezeroa { get; set; }
        public StreamReader Reader { get; set; }
        public StreamWriter Writer { get; set; }
        public Task EntzunAtaza { get; set; }
        public void BezeroaHasi(int id)
        {
            Bezeroa = new NamedPipeClientStream("hodia" + id);
            
            Reader = new StreamReader(Bezeroa);
            Writer = new StreamWriter(Bezeroa);
            EntzunAtaza = Task.Run(ZerbitzariaEntzun);
        }

        public void ZerbitzariaEntzun()
        {
            Bezeroa.Connect();
            while (true)
            {
                Mezua mezua = JsonSerializer.Deserialize<Mezua>(Reader.ReadLine());
                Debug.WriteLine(mezua);
                mezuakDataGridView.Invoke(new MethodInvoker(() => { mezuakDataGridView.Rows.Add(mezua.Data, mezua.Edukia); }));
            }
        }

        public BezeroenLeihoa(Bezeroa bezeroa)
        {
            InitializeComponent();
            bezeroIdLabel.Text = bezeroa.Id.ToString();
            bezeroIzenaLabel.Text = bezeroa.Izena;
            ostatuMotaLabel.Text = bezeroa.OstatuMota;
            BezeroaHasi(bezeroa.Id);


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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mezuakDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
