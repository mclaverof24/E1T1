using System;
using System.Collections.Concurrent;
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
using IdazkaritzaApp;
using KlasePartekatuak;


namespace IdazkaritzaApp
{
    public partial class IdazkaritzaAplikazioa : Form
    {
        public BindingList<BezeroaCtrl> Bezeroak { get; set; }
        public int HurrengoBezeroId { get; set; } = 1;
        public static BlockingCollection<Eskaera> Eskaerak { get; set; }
        public Langile Langile1 { get; set; }
        public Langile Langile2 { get; set; }
        public IdazkaritzaAplikazioa()
        {
            InitializeComponent();
            Langile1 = new Langile { Id=1, Izena="Gustavo Fring", LangileAtaza=new Task(()=>EskaerakBete(1))};
            Langile1 = new Langile { Id = 2, Izena = "Trevor Philps", LangileAtaza = new Task(() => EskaerakBete(2)) };
            Bezeroak = new BindingList<BezeroaCtrl>();
            bezeroMezuHartzaileakComboBox.DataSource = Bezeroak;
            bezeroMezuHartzaileakComboBox.DisplayMember = "BezeroIzena";
            bezeroMezuHartzaileakComboBox.ValueMember = "BezeroId";
            //ostatuMotaComboBox.Items.Add("Denda");
            //ostatuMotaComboBox.Items.Add("Autokarabana");
            //ostatuMotaComboBox.Items.Add("Bungalow");
            //bezeroMezuHartzaileakComboBox.Items.Add("237 Trevor Philips");
            //bezeroMezuHartzaileakComboBox.Items.Add("451 Walter H. White");
            //bezeroMezuHartzaileakComboBox.Items.Add("666 Jesse Pinkman");
            //comboBox3.Items.Add("CSV");
            //comboBox3.Items.Add("XML");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BezeroaErregistratuClick(object sender, EventArgs e)
        {

        }

        private void MezuaBidaliBotoia_Click(object sender, EventArgs e)
        {
            if (bezeroMezuHartzaileakComboBox.SelectedItem != null && mezuEdukiaRichTextBox.Text.Length > 0)
            { // Mezuaren hartzailea aukeratu bada eta mezua hutsik ez badago, bidali 
                Mezua mezua = new Mezua { Data = DateTime.Now, Edukia = mezuEdukiaRichTextBox.Text };
                Bezeroak.FirstOrDefault(b => b.Bezeroa.Id == int.Parse(bezeroMezuHartzaileakComboBox.SelectedValue.ToString())).MezuaBidali(mezua);
            }
        }

        private void BezeroaErregistratu_Click(object sender, EventArgs e)
        {
            if (bezeroIzenaTextField.Text.Length > 0 && ostatuMotaComboBox.SelectedItem != null) //Izena eta ostatu mota sartu badira formularioan, erregistratu
            {
                Bezeroa bezeroBerria = new Bezeroa { Id = HurrengoBezeroId, Izena = bezeroIzenaTextField.Text, OstatuMota = ostatuMotaComboBox.SelectedItem.ToString() };
                BezeroaCtrl bezeroaCtrl = new BezeroaCtrl { Bezeroa = bezeroBerria };
                Bezeroak.Add(bezeroaCtrl);
                HurrengoBezeroId++;
                bezeroaCtrl.BezeroarenZerbitzariaHasi();
            }
        }

        private void LanaldiaHasi_Click(object sender, EventArgs e)
        {
            Langile1.LangileAtaza.Start();
            Langile2.LangileAtaza.Start();
        }

        public static void EskaerakBete(int i) {
            while (Eskaerak.IsCompleted) {
                Eskaera eskaera=Eskaerak.Take();
                Debug.WriteLine(i+" - "+eskaera.ToString());
            }
        }
    }
}
