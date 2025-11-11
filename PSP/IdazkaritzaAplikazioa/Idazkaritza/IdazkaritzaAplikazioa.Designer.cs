namespace IdazkaritzaApp
{
    partial class IdazkaritzaAplikazioa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            bezeroaErregistratuBotoia = new Button();
            label3 = new Label();
            ostatuMotaComboBox = new ComboBox();
            bezeroIzenaTextField = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            BezeroID = new DataGridViewTextBoxColumn();
            BezeroIzena = new DataGridViewTextBoxColumn();
            EskaeraMota = new DataGridViewTextBoxColumn();
            Langilea = new DataGridViewTextBoxColumn();
            Egoera = new DataGridViewTextBoxColumn();
            button3 = new Button();
            lanaldiaHasi = new Button();
            tabPage3 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            mezuaBidaliBotoia = new Button();
            bezeroMezuHartzaileakComboBox = new ComboBox();
            mezuEdukiaRichTextBox = new RichTextBox();
            Bideojokoa = new TabPage();
            label13 = new Label();
            label12 = new Label();
            button8 = new Button();
            button7 = new Button();
            Datuak = new TabPage();
            comboBox5 = new ComboBox();
            label15 = new Label();
            comboBox4 = new ComboBox();
            label14 = new Label();
            label11 = new Label();
            button6 = new Button();
            button5 = new Button();
            comboBox3 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            Bideojokoa.SuspendLayout();
            Datuak.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(Bideojokoa);
            tabControl1.Controls.Add(Datuak);
            tabControl1.Location = new Point(-2, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(703, 334);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bezeroaErregistratuBotoia);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(ostatuMotaComboBox);
            tabPage1.Controls.Add(bezeroIzenaTextField);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 9F);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(695, 306);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bezero berria";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bezeroaErregistratuBotoia
            // 
            bezeroaErregistratuBotoia.AccessibleName = "BezeroBerria";
            bezeroaErregistratuBotoia.Location = new Point(270, 236);
            bezeroaErregistratuBotoia.Margin = new Padding(3, 2, 3, 2);
            bezeroaErregistratuBotoia.Name = "bezeroaErregistratuBotoia";
            bezeroaErregistratuBotoia.Size = new Size(185, 22);
            bezeroaErregistratuBotoia.TabIndex = 11;
            bezeroaErregistratuBotoia.Text = "Bezeroa erregistratu";
            bezeroaErregistratuBotoia.UseVisualStyleBackColor = true;
            bezeroaErregistratuBotoia.Click += BezeroaErregistratu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 141);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Osatu mota:";
            // 
            // ostatuMotaComboBox
            // 
            ostatuMotaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ostatuMotaComboBox.FormattingEnabled = true;
            ostatuMotaComboBox.Items.AddRange(new object[] { "Denda", "Autokarabana", "Bungalow" });
            ostatuMotaComboBox.Location = new Point(270, 141);
            ostatuMotaComboBox.Margin = new Padding(3, 2, 3, 2);
            ostatuMotaComboBox.Name = "ostatuMotaComboBox";
            ostatuMotaComboBox.Size = new Size(133, 23);
            ostatuMotaComboBox.TabIndex = 9;
            ostatuMotaComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // bezeroIzenaTextField
            // 
            bezeroIzenaTextField.Location = new Point(270, 74);
            bezeroIzenaTextField.Margin = new Padding(3, 2, 3, 2);
            bezeroIzenaTextField.Name = "bezeroIzenaTextField";
            bezeroIzenaTextField.Size = new Size(110, 23);
            bezeroIzenaTextField.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 79);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 7;
            label2.Text = "Bezeroaren izena:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(277, 23);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 6;
            label1.Text = "BEZERO BERRIA";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(lanaldiaHasi);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(695, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Eskaerak";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(60, 94);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 7;
            label5.Text = "ESKAEREN ZERRENDA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(60, 22);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "LANALDIA";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BezeroID, BezeroIzena, EskaeraMota, Langilea, Egoera });
            dataGridView1.Location = new Point(26, 132);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(591, 141);
            dataGridView1.TabIndex = 5;
            // 
            // BezeroID
            // 
            BezeroID.HeaderText = "BezeroID";
            BezeroID.MinimumWidth = 6;
            BezeroID.Name = "BezeroID";
            BezeroID.Width = 125;
            // 
            // BezeroIzena
            // 
            BezeroIzena.HeaderText = "BezeroIzena";
            BezeroIzena.MinimumWidth = 6;
            BezeroIzena.Name = "BezeroIzena";
            BezeroIzena.Width = 125;
            // 
            // EskaeraMota
            // 
            EskaeraMota.HeaderText = "EskaeraMota";
            EskaeraMota.MinimumWidth = 6;
            EskaeraMota.Name = "EskaeraMota";
            EskaeraMota.Width = 125;
            // 
            // Langilea
            // 
            Langilea.HeaderText = "Langilea";
            Langilea.MinimumWidth = 6;
            Langilea.Name = "Langilea";
            Langilea.Width = 125;
            // 
            // Egoera
            // 
            Egoera.HeaderText = "Egoera";
            Egoera.MinimumWidth = 6;
            Egoera.Name = "Egoera";
            Egoera.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(332, 48);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 1;
            button3.Text = "Bukatu";
            button3.UseVisualStyleBackColor = true;
            // 
            // lanaldiaHasi
            // 
            lanaldiaHasi.Enabled = false;
            lanaldiaHasi.Location = new Point(156, 48);
            lanaldiaHasi.Margin = new Padding(3, 2, 3, 2);
            lanaldiaHasi.Name = "lanaldiaHasi";
            lanaldiaHasi.Size = new Size(82, 22);
            lanaldiaHasi.TabIndex = 0;
            lanaldiaHasi.Text = "Hasi";
            lanaldiaHasi.UseVisualStyleBackColor = true;
            lanaldiaHasi.Click += LanaldiaHasi_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(mezuaBidaliBotoia);
            tabPage3.Controls.Add(bezeroMezuHartzaileakComboBox);
            tabPage3.Controls.Add(mezuEdukiaRichTextBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(695, 306);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Mezua";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(24, 13);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 4;
            label7.Text = "MEZU BERRIA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 51);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 3;
            label6.Text = "Bezeroa";
            // 
            // mezuaBidaliBotoia
            // 
            mezuaBidaliBotoia.Location = new Point(508, 172);
            mezuaBidaliBotoia.Margin = new Padding(3, 2, 3, 2);
            mezuaBidaliBotoia.Name = "mezuaBidaliBotoia";
            mezuaBidaliBotoia.Size = new Size(82, 22);
            mezuaBidaliBotoia.TabIndex = 2;
            mezuaBidaliBotoia.Text = "Bidali";
            mezuaBidaliBotoia.UseVisualStyleBackColor = true;
            mezuaBidaliBotoia.Click += MezuaBidaliBotoia_Click;
            // 
            // bezeroMezuHartzaileakComboBox
            // 
            bezeroMezuHartzaileakComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bezeroMezuHartzaileakComboBox.FormattingEnabled = true;
            bezeroMezuHartzaileakComboBox.Location = new Point(117, 49);
            bezeroMezuHartzaileakComboBox.Margin = new Padding(3, 2, 3, 2);
            bezeroMezuHartzaileakComboBox.Name = "bezeroMezuHartzaileakComboBox";
            bezeroMezuHartzaileakComboBox.Size = new Size(209, 23);
            bezeroMezuHartzaileakComboBox.TabIndex = 1;
            bezeroMezuHartzaileakComboBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // mezuEdukiaRichTextBox
            // 
            mezuEdukiaRichTextBox.Location = new Point(24, 132);
            mezuEdukiaRichTextBox.Margin = new Padding(3, 2, 3, 2);
            mezuEdukiaRichTextBox.Name = "mezuEdukiaRichTextBox";
            mezuEdukiaRichTextBox.Size = new Size(431, 120);
            mezuEdukiaRichTextBox.TabIndex = 0;
            mezuEdukiaRichTextBox.Text = "";
            // 
            // Bideojokoa
            // 
            Bideojokoa.Controls.Add(label13);
            Bideojokoa.Controls.Add(label12);
            Bideojokoa.Controls.Add(button8);
            Bideojokoa.Controls.Add(button7);
            Bideojokoa.Location = new Point(4, 24);
            Bideojokoa.Margin = new Padding(3, 2, 3, 2);
            Bideojokoa.Name = "Bideojokoa";
            Bideojokoa.Size = new Size(695, 306);
            Bideojokoa.TabIndex = 3;
            Bideojokoa.Text = "Bideojokoa";
            Bideojokoa.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(200, 33);
            label13.Name = "label13";
            label13.Size = new Size(104, 15);
            label13.TabIndex = 3;
            label13.Text = "Exekutatzeko prest";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(40, 33);
            label12.Name = "label12";
            label12.Size = new Size(133, 15);
            label12.TabIndex = 2;
            label12.Text = "Bideojokoaren egoera:";
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(297, 138);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(150, 22);
            button8.TabIndex = 1;
            button8.Text = "Bideojokoa itxi";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(40, 138);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(150, 22);
            button7.TabIndex = 0;
            button7.Text = "Bideojokoa ireki";
            button7.UseVisualStyleBackColor = true;
            // 
            // Datuak
            // 
            Datuak.Controls.Add(comboBox5);
            Datuak.Controls.Add(label15);
            Datuak.Controls.Add(comboBox4);
            Datuak.Controls.Add(label14);
            Datuak.Controls.Add(label11);
            Datuak.Controls.Add(button6);
            Datuak.Controls.Add(button5);
            Datuak.Controls.Add(comboBox3);
            Datuak.Controls.Add(label10);
            Datuak.Controls.Add(label9);
            Datuak.Controls.Add(label8);
            Datuak.Location = new Point(4, 24);
            Datuak.Margin = new Padding(3, 2, 3, 2);
            Datuak.Name = "Datuak";
            Datuak.Size = new Size(695, 306);
            Datuak.TabIndex = 4;
            Datuak.Text = "Datuak";
            Datuak.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(152, 218);
            comboBox5.Margin = new Padding(3, 2, 3, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(133, 23);
            comboBox5.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 218);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 9;
            label15.Text = "Probintzia:";
            label15.Click += label15_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(152, 254);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(133, 23);
            comboBox4.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 254);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 7;
            label14.Text = "Herria:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(152, 82);
            label11.Name = "label11";
            label11.Size = new Size(364, 15);
            label11.TabIndex = 6;
            label11.Text = "(Euskal autonomi erkidegoko kanpin guztien informazioa inportatu)";
            label11.Click += label11_Click;
            // 
            // button6
            // 
            button6.Location = new Point(38, 80);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(82, 22);
            button6.TabIndex = 5;
            button6.Text = "Inportatu";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(402, 219);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 4;
            button5.Text = "Esportatu";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(152, 182);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(133, 23);
            comboBox3.TabIndex = 3;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 182);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 2;
            label10.Text = "Formatua:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(38, 149);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 1;
            label9.Text = "DATUAK ESPORTATU";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(38, 37);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 0;
            label8.Text = "DATUAK INPORTATU";
            // 
            // IdazkaritzaAplikazioa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IdazkaritzaAplikazioa";
            Text = "IdazkaritzaAplikazioa";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            Bideojokoa.ResumeLayout(false);
            Bideojokoa.PerformLayout();
            Datuak.ResumeLayout(false);
            Datuak.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button bezeroaErregistratuBotoia;
        private Label label3;
        private ComboBox ostatuMotaComboBox;
        private TextBox bezeroIzenaTextField;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private Button button3;
        private Button lanaldiaHasi;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BezeroID;
        private DataGridViewTextBoxColumn BezeroIzena;
        private DataGridViewTextBoxColumn EskaeraMota;
        private DataGridViewTextBoxColumn Langilea;
        private DataGridViewTextBoxColumn Egoera;
        private Label label5;
        private Label label4;
        private RichTextBox mezuEdukiaRichTextBox;
        private ComboBox bezeroMezuHartzaileakComboBox;
        private Label label7;
        private Label label6;
        private Button mezuaBidaliBotoia;
        private TabPage Bideojokoa;
        private TabPage Datuak;
        private Button button6;
        private Button button5;
        private ComboBox comboBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label13;
        private Label label12;
        private Button button8;
        private Button button7;
        private ComboBox comboBox5;
        private Label label15;
        private ComboBox comboBox4;
        private Label label14;
    }
}