using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public BlockingCollection<Eskaera> Eskaerak { get; set; }
        public static List<Langile> Langileak { get; set; }
        public CancellationTokenSource Cts { get; set; }
        public CancellationToken Token { get; set; }
        //public Langile Langile1 { get; set; }
        //public Langile Langile2 { get; set; }
        public static Dictionary<string, string> Herriak;
        public IdazkaritzaAplikazioa()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Eskaerak = new BlockingCollection<Eskaera>();

            //Langile1 = new Langile { Id=1, Izena="Gustavo Fring", LangileAtaza=new Task(()=>EskaerakBete(1))};
            //Langile1 = new Langile { Id = 2, Izena = "Trevor Philips", LangileAtaza = new Task(() => EskaerakBete(2)) };
            Langileak = new List<Langile>();
            Langileak.Add(new Langile { Id = 1, Izena = "Gustavo Fring" });
            Langileak.Add(new Langile { Id = 2, Izena = "Trevor Philips" });

            Bezeroak = new BindingList<BezeroaCtrl>();
            bezeroMezuHartzaileakComboBox.DataSource = Bezeroak;
            bezeroMezuHartzaileakComboBox.DisplayMember = "BezeroIzena";
            bezeroMezuHartzaileakComboBox.ValueMember = "BezeroId";

            Herriak = new Dictionary<string, string>
            {
                { "Gorliz", "43" },
                { "Hondarribia", "36" },
                { "Donostia San Sebastián", "69" },
                { "Deba", "29" },
                { "Mendexa", "63" },
                { "Orio", "61" },
                { "Mundaka", "68" },
                { "Mutriku", "56" },
                { "Zarautz", "79" },
                { "Vitoria-Gasteiz", "59" },
                { "Sopela", "85" },
                { "Aia", "16" },
                { "Valdegovía Gaubea", "55" },
                { "Legazpi", "51" },
                { "Erriberagoitia Ribera Alta", "46" },
                { "Bilbao", "20" },
                { "Zumaia", "81" }
            };
            herriaComboBox.DataSource = Herriak.Keys.ToList();
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
                BezeroaCtrl bezeroaCtrl = new BezeroaCtrl { IdazkaritzaErreferentzia = this, Bezeroa = bezeroBerria };
                Bezeroak.Add(bezeroaCtrl);
                HurrengoBezeroId++;
                bezeroaCtrl.BezeroarenZerbitzariakHasi();
            }
        }

        private void LanaldiaHasi_Click(object sender, EventArgs e)
        {
            lanaldiaHasiBotoia.Enabled = false;
            lanaldiaBukatuBotoia.Enabled = true;
            Cts = new CancellationTokenSource();
            Token = Cts.Token;
            foreach (Langile langile in Langileak)
            {
                langile.LangileAtaza = new Task(() => EskaerakBete());
                langile.LangileAtaza.Start();
            }
            //Langile1.LangileAtaza.Start();
            //Langile2.LangileAtaza.Start();
        }

        public void EskaerakBete()
        {
            while (!Token.IsCancellationRequested)
            {
                Eskaera eskaera = Eskaerak.Take();
                int denboraDebug = Eskaera.MotaDenbora[eskaera.Mota];
                Task.Delay(Eskaera.MotaDenbora[eskaera.Mota]).GetAwaiter().GetResult();// Ataza hau soilik blokeatzeko, ez hari nagusia
                //eskaerakDataGridView.Invoke(new MethodInvoker(() => eskaerakDataGridView.Rows[eskaera.TaulaErrenkadaIndizea].Cells["Egoera"].Value = "Beteta"));
                eskaerakDataGridView.Invoke(new MethodInvoker(() => eskaerakDataGridView.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["EskaeraErref"].Value == eskaera)
                .Cells["Egoera"].Value = "Beteta"));
            }
        }

        public void EskaeraGehitu(Eskaera eskaera)
        {
            eskaerakDataGridView.Rows.Add(eskaera, eskaera.Bezeroa.Id, eskaera.Bezeroa.Izena, eskaera.Mota, eskaera.Langilea.Izena, "Bete gabe");
            //eskaera.TaulaErrenkadaIndizea = eskaerakDataGridView.Rows.Count - 1;
        }

        private void Itxi_Click(object sender, FormClosingEventArgs e)
        {
            // Idazkaritza aplikazioa prozesu nagusia denez, ixtean berak sortutako prozesu guztiak (Bezeroen aplikazioak) itxiko dira
            foreach (BezeroaCtrl bezeroaCtrl in Bezeroak)
            {
                bezeroaCtrl.Prozesua.Kill();
                bezeroaCtrl.Prozesua.WaitForExit();

            }
            //Bezeroak.Clear();
        }

        private void LanaldiaBukatuBotoia_Click(object sender, EventArgs e)
        {
            lanaldiaBukatuBotoia.Enabled = false;
            lanaldiaHasiBotoia.Enabled = true;
            Cts.Cancel();
        }

        private void DatuakInportatuBotoia_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = "java",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            info.ArgumentList.Add("-jar");
            info.ArgumentList.Add(@"inportazioa.jar");
            Process inportazioProzesua = Process.Start(info);
            string sysout = inportazioProzesua.StandardOutput.ReadToEnd();
            string erroreak = inportazioProzesua.StandardError.ReadToEnd();
            inportazioProzesua.WaitForExit();
            if (erroreak.Length == 0)
            {
                MessageBox.Show(this, "Datu-basea eguneratu da.", "Inportazio zuzena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Debug.WriteLine("ondo");
        }

        private void EsportatuBotoia_Click(object sender, EventArgs e)
        {
            if (formatuaComboBox.SelectedItem!=null && herriaComboBox.SelectedItem!=null)
            {
                ProcessStartInfo info = new ProcessStartInfo
                {
                    FileName = "java",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };
                info.ArgumentList.Add("-jar");
                info.ArgumentList.Add(@"esportazioa.jar");
                string formatua = formatuaComboBox.SelectedItem.ToString();
                string herriIzena = herriaComboBox.SelectedItem.ToString();
                string herriKodea = Herriak[herriIzena];
                info.ArgumentList.Add(formatua);
                info.ArgumentList.Add(herriKodea);
                info.ArgumentList.Add(herriIzena);
                Process esportazioProzesua = Process.Start(info);
                string sysout = esportazioProzesua.StandardOutput.ReadToEnd();
                string erroreak = esportazioProzesua.StandardError.ReadToEnd();
                esportazioProzesua.WaitForExit();
                if (erroreak.Length == 0)
                {
                    MessageBox.Show(this, $"{herriIzena}(e)ko kanpinen informazioa duen {formatua} fitxategia sortu da.", "Esportazio zuzena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Debug.WriteLine("ondo");
            }
        }
    }
}
