namespace KlasePartekatuak
{
    partial class BezeroenLeihoa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bezeroIzenaLabel = new Label();
            bezeroIdLabel = new Label();
            ostatuMotaLabel = new Label();
            eskaeraMotaComboBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            mezuakDataGridView = new DataGridView();
            DataZutabea = new DataGridViewTextBoxColumn();
            MezuaZutabea = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)mezuakDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Izena:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(46, 77);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(46, 111);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Ostatu mota:";
            // 
            // bezeroIzenaLabel
            // 
            bezeroIzenaLabel.AutoSize = true;
            bezeroIzenaLabel.Location = new Point(175, 40);
            bezeroIzenaLabel.Name = "bezeroIzenaLabel";
            bezeroIzenaLabel.Size = new Size(0, 20);
            bezeroIzenaLabel.TabIndex = 3;
            // 
            // bezeroIdLabel
            // 
            bezeroIdLabel.AutoSize = true;
            bezeroIdLabel.Location = new Point(175, 77);
            bezeroIdLabel.Name = "bezeroIdLabel";
            bezeroIdLabel.Size = new Size(0, 20);
            bezeroIdLabel.TabIndex = 4;
            // 
            // ostatuMotaLabel
            // 
            ostatuMotaLabel.AutoSize = true;
            ostatuMotaLabel.Location = new Point(175, 111);
            ostatuMotaLabel.Name = "ostatuMotaLabel";
            ostatuMotaLabel.Size = new Size(0, 20);
            ostatuMotaLabel.TabIndex = 5;
            // 
            // eskaeraMotaComboBox
            // 
            eskaeraMotaComboBox.FormattingEnabled = true;
            eskaeraMotaComboBox.Items.AddRange(new object[] { "Eskuoihalak", "Izarak", "Zaborra", "Jatetxea" });
            eskaeraMotaComboBox.Location = new Point(171, 373);
            eskaeraMotaComboBox.Name = "eskaeraMotaComboBox";
            eskaeraMotaComboBox.Size = new Size(151, 28);
            eskaeraMotaComboBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 376);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 7;
            label7.Text = "Eskaera mota:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(42, 312);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 8;
            label8.Text = "ESKAERA BERRIA";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(342, 373);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 9;
            button1.Text = "Eskaera egin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(46, 187);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Check-out";
            button2.UseVisualStyleBackColor = true;
            // 
            // mezuakDataGridView
            // 
            mezuakDataGridView.AllowUserToAddRows = false;
            mezuakDataGridView.AllowUserToDeleteRows = false;
            mezuakDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            mezuakDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            mezuakDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mezuakDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataZutabea, MezuaZutabea });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            mezuakDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            mezuakDataGridView.Location = new Point(342, 40);
            mezuakDataGridView.Name = "mezuakDataGridView";
            mezuakDataGridView.ReadOnly = true;
            mezuakDataGridView.RowHeadersWidth = 51;
            mezuakDataGridView.Size = new Size(446, 260);
            mezuakDataGridView.TabIndex = 11;
            mezuakDataGridView.CellContentClick += mezuakDataGridView_CellContentClick;
            // 
            // DataZutabea
            // 
            DataZutabea.Frozen = true;
            DataZutabea.HeaderText = "Data";
            DataZutabea.MinimumWidth = 6;
            DataZutabea.Name = "DataZutabea";
            DataZutabea.ReadOnly = true;
            DataZutabea.Width = 70;
            // 
            // MezuaZutabea
            // 
            MezuaZutabea.Frozen = true;
            MezuaZutabea.HeaderText = "Mezua";
            MezuaZutabea.MinimumWidth = 6;
            MezuaZutabea.Name = "MezuaZutabea";
            MezuaZutabea.ReadOnly = true;
            MezuaZutabea.Width = 82;
            // 
            // BezeroenLeihoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mezuakDataGridView);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(eskaeraMotaComboBox);
            Controls.Add(ostatuMotaLabel);
            Controls.Add(bezeroIdLabel);
            Controls.Add(bezeroIzenaLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BezeroenLeihoa";
            Text = "BEZEROEN LEIHOA";
            Load += BezeroenLeihoa_Load;
            ((System.ComponentModel.ISupportInitialize)mezuakDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label bezeroIzenaLabel;
        private Label bezeroIdLabel;
        private Label ostatuMotaLabel;
        private ComboBox eskaeraMotaComboBox;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private DataGridView mezuakDataGridView;
        private DataGridViewTextBoxColumn DataZutabea;
        private DataGridViewTextBoxColumn MezuaZutabea;
    }
}