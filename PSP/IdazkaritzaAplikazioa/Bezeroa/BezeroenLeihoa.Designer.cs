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
            eskaeraMotaComboBox.Location = new Point(187, 267);
            eskaeraMotaComboBox.Name = "eskaeraMotaComboBox";
            eskaeraMotaComboBox.Size = new Size(151, 28);
            eskaeraMotaComboBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 267);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 7;
            label7.Text = "Eskaera mota:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(46, 203);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 8;
            label8.Text = "ESKAERA BERRIA";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(425, 267);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 9;
            button1.Text = "Eskaera egin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(425, 77);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Check-out";
            button2.UseVisualStyleBackColor = true;
            // 
            // BezeroenLeihoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}