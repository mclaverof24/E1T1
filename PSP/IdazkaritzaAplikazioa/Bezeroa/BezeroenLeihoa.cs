using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasePartekatuak
{
    public partial class BezeroenLeihoa : Form
    {
        public BezeroenLeihoa(Bezeroa bezeroa)
        {
            InitializeComponent();
            bezeroIdLabel.Text = bezeroa.Id.ToString();
            bezeroIzenaLabel.Text = bezeroa.Izena;
            ostatuMotaLabel.Text = bezeroa.OstatuMota;
            //eskaeraMotaComboBox.Items.Add("Eskuoihalak");
            //eskaeraMotaComboBox.Items.Add("Izarak");
            //eskaeraMotaComboBox.Items.Add("Zaborra");
            //eskaeraMotaComboBox.Items.Add("Jatetxea");

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
    }
}
