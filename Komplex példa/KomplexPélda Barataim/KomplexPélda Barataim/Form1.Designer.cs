namespace KomplexPélda_Barataim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUj = new Button();
            btnMent = new Button();
            btnBetolt = new Button();
            btnList = new Button();
            btnKeres = new Button();
            panel1 = new Panel();
            btnMegse = new Button();
            btnOk = new Button();
            numericUpDown1 = new NumericUpDown();
            tbCim = new TextBox();
            tbNev = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnUj
            // 
            btnUj.Location = new Point(13, 14);
            btnUj.Name = "btnUj";
            btnUj.Size = new Size(75, 23);
            btnUj.TabIndex = 0;
            btnUj.Text = "Új barát";
            btnUj.UseVisualStyleBackColor = true;
            btnUj.Click += btnUj_Click;
            // 
            // btnMent
            // 
            btnMent.Location = new Point(13, 43);
            btnMent.Name = "btnMent";
            btnMent.Size = new Size(75, 23);
            btnMent.TabIndex = 1;
            btnMent.Text = "Ment";
            btnMent.UseVisualStyleBackColor = true;
            btnMent.Click += btnMent_Click;
            // 
            // btnBetolt
            // 
            btnBetolt.Location = new Point(12, 72);
            btnBetolt.Name = "btnBetolt";
            btnBetolt.Size = new Size(75, 23);
            btnBetolt.TabIndex = 2;
            btnBetolt.Text = "Betolt";
            btnBetolt.UseVisualStyleBackColor = true;
            btnBetolt.Click += btnBetolt_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(12, 101);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 3;
            btnList.Text = "Lista";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnKeres
            // 
            btnKeres.Location = new Point(12, 130);
            btnKeres.Name = "btnKeres";
            btnKeres.Size = new Size(75, 23);
            btnKeres.TabIndex = 4;
            btnKeres.Text = "Keresés";
            btnKeres.UseVisualStyleBackColor = true;
            btnKeres.Click += btnKeres_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMegse);
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(tbCim);
            panel1.Controls.Add(tbNev);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(113, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 217);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // btnMegse
            // 
            btnMegse.Location = new Point(414, 179);
            btnMegse.Name = "btnMegse";
            btnMegse.Size = new Size(75, 23);
            btnMegse.TabIndex = 7;
            btnMegse.Text = "Mégse";
            btnMegse.UseVisualStyleBackColor = true;
            btnMegse.Click += btnMegse_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(13, 179);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(74, 95);
            numericUpDown1.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(162, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // tbCim
            // 
            tbCim.Location = new Point(74, 55);
            tbCim.Name = "tbCim";
            tbCim.Size = new Size(415, 23);
            tbCim.TabIndex = 4;
            // 
            // tbNev
            // 
            tbNev.Location = new Point(74, 19);
            tbNev.Name = "tbNev";
            tbNev.Size = new Size(415, 23);
            tbNev.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 97);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 58);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Cím";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 22);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Nev";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 253);
            Controls.Add(panel1);
            Controls.Add(btnKeres);
            Controls.Add(btnList);
            Controls.Add(btnBetolt);
            Controls.Add(btnMent);
            Controls.Add(btnUj);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUj;
        private Button btnMent;
        private Button btnBetolt;
        private Button btnList;
        private Button btnKeres;
        private Panel panel1;
        private TextBox tbCim;
        private TextBox tbNev;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnMegse;
        private Button btnOk;
        private NumericUpDown numericUpDown1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
