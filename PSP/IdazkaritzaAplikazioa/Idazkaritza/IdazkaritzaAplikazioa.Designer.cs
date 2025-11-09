namespace KlasePartekatuak
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
            button2 = new Button();
            tabPage3 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            button4 = new Button();
            comboBox2 = new ComboBox();
            richTextBox1 = new RichTextBox();
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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 445);
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
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bezero berria";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bezeroaErregistratuBotoia
            // 
            bezeroaErregistratuBotoia.AccessibleName = "BezeroBerria";
            bezeroaErregistratuBotoia.Location = new Point(309, 315);
            bezeroaErregistratuBotoia.Name = "bezeroaErregistratuBotoia";
            bezeroaErregistratuBotoia.Size = new Size(211, 29);
            bezeroaErregistratuBotoia.TabIndex = 11;
            bezeroaErregistratuBotoia.Text = "Bezeroa erregistratu";
            bezeroaErregistratuBotoia.UseVisualStyleBackColor = true;
            bezeroaErregistratuBotoia.Click += BezeroaErregistratuClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 188);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 10;
            label3.Text = "Osatu mota:";
            // 
            // ostatuMotaComboBox
            // 
            ostatuMotaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ostatuMotaComboBox.FormattingEnabled = true;
            ostatuMotaComboBox.Items.AddRange(new object[] { "Denda", "Autokarabana", "Bungalow" });
            ostatuMotaComboBox.Location = new Point(309, 188);
            ostatuMotaComboBox.Name = "ostatuMotaComboBox";
            ostatuMotaComboBox.Size = new Size(151, 28);
            ostatuMotaComboBox.TabIndex = 9;
            ostatuMotaComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // bezeroIzenaTextField
            // 
            bezeroIzenaTextField.Location = new Point(309, 99);
            bezeroIzenaTextField.Name = "bezeroIzenaTextField";
            bezeroIzenaTextField.Size = new Size(125, 27);
            bezeroIzenaTextField.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 105);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 7;
            label2.Text = "Bezeroaren izena:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(317, 31);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 6;
            label1.Text = "BEZERO BERRIA";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Eskaerak";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(69, 125);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 7;
            label5.Text = "ESKAEREN ZERRENDA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(69, 29);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "LANALDIA";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BezeroID, BezeroIzena, EskaeraMota, Langilea, Egoera });
            dataGridView1.Location = new Point(30, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(675, 188);
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
            button3.Location = new Point(379, 64);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "Bukatu";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(178, 64);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "Hasi";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(richTextBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(795, 412);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Mezua";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(27, 17);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 4;
            label7.Text = "MEZU BERRIA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 68);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 3;
            label6.Text = "Bezeroa";
            // 
            // button4
            // 
            button4.Location = new Point(581, 229);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "Bidali";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(134, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(238, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(27, 176);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(492, 159);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Bideojokoa
            // 
            Bideojokoa.Controls.Add(label13);
            Bideojokoa.Controls.Add(label12);
            Bideojokoa.Controls.Add(button8);
            Bideojokoa.Controls.Add(button7);
            Bideojokoa.Location = new Point(4, 29);
            Bideojokoa.Name = "Bideojokoa";
            Bideojokoa.Size = new Size(795, 412);
            Bideojokoa.TabIndex = 3;
            Bideojokoa.Text = "Bideojokoa";
            Bideojokoa.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(229, 44);
            label13.Name = "label13";
            label13.Size = new Size(133, 20);
            label13.TabIndex = 3;
            label13.Text = "Exekutatzeko prest";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(46, 44);
            label12.Name = "label12";
            label12.Size = new Size(166, 20);
            label12.TabIndex = 2;
            label12.Text = "Bideojokoaren egoera:";
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(339, 184);
            button8.Name = "button8";
            button8.Size = new Size(171, 29);
            button8.TabIndex = 1;
            button8.Text = "Bideojokoa itxi";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(46, 184);
            button7.Name = "button7";
            button7.Size = new Size(171, 29);
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
            Datuak.Location = new Point(4, 29);
            Datuak.Name = "Datuak";
            Datuak.Size = new Size(795, 412);
            Datuak.TabIndex = 4;
            Datuak.Text = "Datuak";
            Datuak.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(174, 291);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(151, 28);
            comboBox5.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(43, 291);
            label15.Name = "label15";
            label15.Size = new Size(79, 20);
            label15.TabIndex = 9;
            label15.Text = "Probintzia:";
            label15.Click += label15_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(174, 339);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(43, 339);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 7;
            label14.Text = "Herria:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(174, 109);
            label11.Name = "label11";
            label11.Size = new Size(457, 20);
            label11.TabIndex = 6;
            label11.Text = "(Euskal autonomi erkidegoko kanpin guztien informazioa inportatu)";
            label11.Click += label11_Click;
            // 
            // button6
            // 
            button6.Location = new Point(43, 107);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "Inportatu";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(459, 292);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Esportatu";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(174, 243);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 3;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 243);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 2;
            label10.Text = "Formatua:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(43, 199);
            label9.Name = "label9";
            label9.Size = new Size(159, 20);
            label9.TabIndex = 1;
            label9.Text = "DATUAK ESPORTATU";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(43, 49);
            label8.Name = "label8";
            label8.Size = new Size(160, 20);
            label8.TabIndex = 0;
            label8.Text = "DATUAK INPORTATU";
            // 
            // IdazkaritzaAplikazioa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(tabControl1);
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
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BezeroID;
        private DataGridViewTextBoxColumn BezeroIzena;
        private DataGridViewTextBoxColumn EskaeraMota;
        private DataGridViewTextBoxColumn Langilea;
        private DataGridViewTextBoxColumn Egoera;
        private Label label5;
        private Label label4;
        private RichTextBox richTextBox1;
        private ComboBox comboBox2;
        private Label label7;
        private Label label6;
        private Button button4;
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