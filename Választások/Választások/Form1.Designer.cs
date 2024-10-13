namespace Választások
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            btnÚj = new Button();
            btnMentés = new Button();
            btnetöltés = new Button();
            tbNév = new TextBox();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            tbVáros = new TextBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(221, 409);
            listBox1.TabIndex = 0;
            listBox1.Click += listBox1_Click;
            // 
            // btnÚj
            // 
            btnÚj.Location = new Point(272, 21);
            btnÚj.Name = "btnÚj";
            btnÚj.Size = new Size(75, 23);
            btnÚj.TabIndex = 1;
            btnÚj.Text = "Új";
            btnÚj.UseVisualStyleBackColor = true;
            btnÚj.Click += btnÚj_Click;
            // 
            // btnMentés
            // 
            btnMentés.Location = new Point(272, 50);
            btnMentés.Name = "btnMentés";
            btnMentés.Size = new Size(75, 23);
            btnMentés.TabIndex = 2;
            btnMentés.Text = "Mentés";
            btnMentés.UseVisualStyleBackColor = true;
            btnMentés.Click += btnMentés_Click;
            // 
            // btnetöltés
            // 
            btnetöltés.Location = new Point(272, 79);
            btnetöltés.Name = "btnetöltés";
            btnetöltés.Size = new Size(75, 23);
            btnetöltés.TabIndex = 3;
            btnetöltés.Text = "Betöltés";
            btnetöltés.UseVisualStyleBackColor = true;
            btnetöltés.Click += btnetöltés_Click;
            // 
            // tbNév
            // 
            tbNév.Location = new Point(390, 21);
            tbNév.Name = "tbNév";
            tbNév.Size = new Size(288, 23);
            tbNév.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(390, 50);
            numericUpDown1.Maximum = new decimal(new int[] { 2022, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(390, 79);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(42, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Nő";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbVáros
            // 
            tbVáros.Location = new Point(390, 104);
            tbVáros.Name = "tbVáros";
            tbVáros.Size = new Size(288, 23);
            tbVáros.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 450);
            Controls.Add(tbVáros);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(tbNév);
            Controls.Add(btnetöltés);
            Controls.Add(btnMentés);
            Controls.Add(btnÚj);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnÚj;
        private Button btnMentés;
        private Button btnetöltés;
        private TextBox tbNév;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private TextBox tbVáros;
        private BindingSource bindingSource1;
    }
}
