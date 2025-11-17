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
            eskaerakDataGridView = new DataGridView();
            EskaeraErref = new DataGridViewTextBoxColumn();
            BezeroID = new DataGridViewTextBoxColumn();
            BezeroIzena = new DataGridViewTextBoxColumn();
            EskaeraMota = new DataGridViewTextBoxColumn();
            Langilea = new DataGridViewTextBoxColumn();
            Egoera = new DataGridViewTextBoxColumn();
            lanaldiaBukatuBotoia = new Button();
            lanaldiaHasiBotoia = new Button();
            tabPage3 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            mezuaBidaliBotoia = new Button();
            bezeroMezuHartzaileakComboBox = new ComboBox();
            mezuEdukiaRichTextBox = new RichTextBox();
            Bideojokoa = new TabPage();
            jokoaIrekiBotoia = new Button();
            Datuak = new TabPage();
            herriaComboBox = new ComboBox();
            label14 = new Label();
            label11 = new Label();
            datuakInportatuBotoia = new Button();
            esportatuBotoia = new Button();
            formatuaComboBox = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eskaerakDataGridView).BeginInit();
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
            tabPage2.Controls.Add(eskaerakDataGridView);
            tabPage2.Controls.Add(lanaldiaBukatuBotoia);
            tabPage2.Controls.Add(lanaldiaHasiBotoia);
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
            // eskaerakDataGridView
            // 
            eskaerakDataGridView.AllowUserToAddRows = false;
            eskaerakDataGridView.AllowUserToDeleteRows = false;
            eskaerakDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eskaerakDataGridView.Columns.AddRange(new DataGridViewColumn[] { EskaeraErref, BezeroID, BezeroIzena, EskaeraMota, Langilea, Egoera });
            eskaerakDataGridView.Location = new Point(26, 132);
            eskaerakDataGridView.Margin = new Padding(3, 2, 3, 2);
            eskaerakDataGridView.Name = "eskaerakDataGridView";
            eskaerakDataGridView.ReadOnly = true;
            eskaerakDataGridView.RowHeadersWidth = 51;
            eskaerakDataGridView.Size = new Size(591, 141);
            eskaerakDataGridView.TabIndex = 5;
            // 
            // EskaeraErref
            // 
            EskaeraErref.HeaderText = "EskaeraErref";
            EskaeraErref.MinimumWidth = 6;
            EskaeraErref.Name = "EskaeraErref";
            EskaeraErref.ReadOnly = true;
            EskaeraErref.Visible = false;
            EskaeraErref.Width = 125;
            // 
            // BezeroID
            // 
            BezeroID.HeaderText = "BezeroID";
            BezeroID.MinimumWidth = 6;
            BezeroID.Name = "BezeroID";
            BezeroID.ReadOnly = true;
            BezeroID.Width = 125;
            // 
            // BezeroIzena
            // 
            BezeroIzena.HeaderText = "BezeroIzena";
            BezeroIzena.MinimumWidth = 6;
            BezeroIzena.Name = "BezeroIzena";
            BezeroIzena.ReadOnly = true;
            BezeroIzena.Width = 125;
            // 
            // EskaeraMota
            // 
            EskaeraMota.HeaderText = "EskaeraMota";
            EskaeraMota.MinimumWidth = 6;
            EskaeraMota.Name = "EskaeraMota";
            EskaeraMota.ReadOnly = true;
            EskaeraMota.Width = 125;
            // 
            // Langilea
            // 
            Langilea.HeaderText = "Langilea";
            Langilea.MinimumWidth = 6;
            Langilea.Name = "Langilea";
            Langilea.ReadOnly = true;
            Langilea.Width = 125;
            // 
            // Egoera
            // 
            Egoera.HeaderText = "Egoera";
            Egoera.MinimumWidth = 6;
            Egoera.Name = "Egoera";
            Egoera.ReadOnly = true;
            Egoera.Width = 125;
            // 
            // lanaldiaBukatuBotoia
            // 
            lanaldiaBukatuBotoia.Enabled = false;
            lanaldiaBukatuBotoia.Location = new Point(332, 48);
            lanaldiaBukatuBotoia.Margin = new Padding(3, 2, 3, 2);
            lanaldiaBukatuBotoia.Name = "lanaldiaBukatuBotoia";
            lanaldiaBukatuBotoia.Size = new Size(82, 22);
            lanaldiaBukatuBotoia.TabIndex = 1;
            lanaldiaBukatuBotoia.Text = "Bukatu";
            lanaldiaBukatuBotoia.UseVisualStyleBackColor = true;
            lanaldiaBukatuBotoia.Click += LanaldiaBukatuBotoia_Click;
            // 
            // lanaldiaHasiBotoia
            // 
            lanaldiaHasiBotoia.Location = new Point(156, 48);
            lanaldiaHasiBotoia.Margin = new Padding(3, 2, 3, 2);
            lanaldiaHasiBotoia.Name = "lanaldiaHasiBotoia";
            lanaldiaHasiBotoia.Size = new Size(82, 22);
            lanaldiaHasiBotoia.TabIndex = 0;
            lanaldiaHasiBotoia.Text = "Hasi";
            lanaldiaHasiBotoia.UseVisualStyleBackColor = true;
            lanaldiaHasiBotoia.Click += LanaldiaHasi_Click;
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
            Bideojokoa.Controls.Add(jokoaIrekiBotoia);
            Bideojokoa.Location = new Point(4, 24);
            Bideojokoa.Margin = new Padding(3, 2, 3, 2);
            Bideojokoa.Name = "Bideojokoa";
            Bideojokoa.Size = new Size(695, 306);
            Bideojokoa.TabIndex = 3;
            Bideojokoa.Text = "Bideojokoa";
            Bideojokoa.UseVisualStyleBackColor = true;
            // 
            // jokoaIrekiBotoia
            // 
            jokoaIrekiBotoia.Location = new Point(204, 92);
            jokoaIrekiBotoia.Margin = new Padding(3, 2, 3, 2);
            jokoaIrekiBotoia.Name = "jokoaIrekiBotoia";
            jokoaIrekiBotoia.Size = new Size(279, 118);
            jokoaIrekiBotoia.TabIndex = 0;
            jokoaIrekiBotoia.Text = "Bideojokoa ireki";
            jokoaIrekiBotoia.UseVisualStyleBackColor = true;
            jokoaIrekiBotoia.Click += JokoaIrekiBotoia_Click;
            // 
            // Datuak
            // 
            Datuak.Controls.Add(herriaComboBox);
            Datuak.Controls.Add(label14);
            Datuak.Controls.Add(label11);
            Datuak.Controls.Add(datuakInportatuBotoia);
            Datuak.Controls.Add(esportatuBotoia);
            Datuak.Controls.Add(formatuaComboBox);
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
            // herriaComboBox
            // 
            herriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            herriaComboBox.FormattingEnabled = true;
            herriaComboBox.Location = new Point(152, 240);
            herriaComboBox.Margin = new Padding(3, 2, 3, 2);
            herriaComboBox.Name = "herriaComboBox";
            herriaComboBox.Size = new Size(133, 23);
            herriaComboBox.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 240);
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
            // datuakInportatuBotoia
            // 
            datuakInportatuBotoia.Location = new Point(38, 80);
            datuakInportatuBotoia.Margin = new Padding(3, 2, 3, 2);
            datuakInportatuBotoia.Name = "datuakInportatuBotoia";
            datuakInportatuBotoia.Size = new Size(82, 22);
            datuakInportatuBotoia.TabIndex = 5;
            datuakInportatuBotoia.Text = "Inportatu";
            datuakInportatuBotoia.UseVisualStyleBackColor = true;
            datuakInportatuBotoia.Click += DatuakInportatuBotoia_Click;
            // 
            // esportatuBotoia
            // 
            esportatuBotoia.Location = new Point(402, 219);
            esportatuBotoia.Margin = new Padding(3, 2, 3, 2);
            esportatuBotoia.Name = "esportatuBotoia";
            esportatuBotoia.Size = new Size(82, 22);
            esportatuBotoia.TabIndex = 4;
            esportatuBotoia.Text = "Esportatu";
            esportatuBotoia.UseVisualStyleBackColor = true;
            esportatuBotoia.Click += EsportatuBotoia_Click;
            // 
            // formatuaComboBox
            // 
            formatuaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formatuaComboBox.FormattingEnabled = true;
            formatuaComboBox.Items.AddRange(new object[] { "CSV", "XML" });
            formatuaComboBox.Location = new Point(152, 182);
            formatuaComboBox.Margin = new Padding(3, 2, 3, 2);
            formatuaComboBox.Name = "formatuaComboBox";
            formatuaComboBox.Size = new Size(133, 23);
            formatuaComboBox.TabIndex = 3;
            formatuaComboBox.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
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
            FormClosing += Itxi_Click;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eskaerakDataGridView).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            Bideojokoa.ResumeLayout(false);
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
        private Button lanaldiaBukatuBotoia;
        private Button lanaldiaHasiBotoia;
        private DataGridView eskaerakDataGridView;
        private Label label5;
        private Label label4;
        private RichTextBox mezuEdukiaRichTextBox;
        private ComboBox bezeroMezuHartzaileakComboBox;
        private Label label7;
        private Label label6;
        private Button mezuaBidaliBotoia;
        private TabPage Bideojokoa;
        private TabPage Datuak;
        private Button datuakInportatuBotoia;
        private Button esportatuBotoia;
        private ComboBox formatuaComboBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private Button jokoaIrekiBotoia;
        private ComboBox herriaComboBox;
        private Label label14;
        private DataGridViewTextBoxColumn EskaeraErref;
        private DataGridViewTextBoxColumn BezeroID;
        private DataGridViewTextBoxColumn BezeroIzena;
        private DataGridViewTextBoxColumn EskaeraMota;
        private DataGridViewTextBoxColumn Langilea;
        private DataGridViewTextBoxColumn Egoera;
    }
}