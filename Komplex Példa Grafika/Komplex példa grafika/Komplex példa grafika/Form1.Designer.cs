namespace Komplex_példa_grafika
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
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureModeToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            strechToolStripMenuItem = new ToolStripMenuItem();
            automaticToolStripMenuItem = new ToolStripMenuItem();
            centerToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            btnBetolt = new Button();
            btnMent = new Button();
            btnSzinezo = new Button();
            btnKonturKeres = new Button();
            btnVizjel = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 600);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { pictureModeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 26);
            // 
            // pictureModeToolStripMenuItem
            // 
            pictureModeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, strechToolStripMenuItem, automaticToolStripMenuItem, centerToolStripMenuItem, zoomToolStripMenuItem });
            pictureModeToolStripMenuItem.Name = "pictureModeToolStripMenuItem";
            pictureModeToolStripMenuItem.Size = new Size(145, 22);
            pictureModeToolStripMenuItem.Text = "Picture Mode";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(130, 22);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // strechToolStripMenuItem
            // 
            strechToolStripMenuItem.Name = "strechToolStripMenuItem";
            strechToolStripMenuItem.Size = new Size(130, 22);
            strechToolStripMenuItem.Text = "Stretch";
            strechToolStripMenuItem.TextAlign = ContentAlignment.BottomRight;
            strechToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // automaticToolStripMenuItem
            // 
            automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            automaticToolStripMenuItem.Size = new Size(130, 22);
            automaticToolStripMenuItem.Text = "Automatic";
            automaticToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // centerToolStripMenuItem
            // 
            centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            centerToolStripMenuItem.Size = new Size(130, 22);
            centerToolStripMenuItem.Text = "Center";
            centerToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(130, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // btnBetolt
            // 
            btnBetolt.Location = new Point(829, 15);
            btnBetolt.Name = "btnBetolt";
            btnBetolt.Size = new Size(111, 23);
            btnBetolt.TabIndex = 1;
            btnBetolt.Text = "Betöltés";
            btnBetolt.UseVisualStyleBackColor = true;
            btnBetolt.Click += btnBetolt_Click;
            // 
            // btnMent
            // 
            btnMent.Location = new Point(829, 44);
            btnMent.Name = "btnMent";
            btnMent.Size = new Size(111, 23);
            btnMent.TabIndex = 2;
            btnMent.Text = "Mentés";
            btnMent.UseVisualStyleBackColor = true;
            btnMent.Click += btnMent_Click;
            // 
            // btnSzinezo
            // 
            btnSzinezo.Location = new Point(829, 99);
            btnSzinezo.Name = "btnSzinezo";
            btnSzinezo.Size = new Size(111, 23);
            btnSzinezo.TabIndex = 3;
            btnSzinezo.Text = "Színező";
            btnSzinezo.UseVisualStyleBackColor = true;
            btnSzinezo.Click += btnSzinezo_Click;
            // 
            // btnKonturKeres
            // 
            btnKonturKeres.Location = new Point(829, 128);
            btnKonturKeres.Name = "btnKonturKeres";
            btnKonturKeres.Size = new Size(111, 23);
            btnKonturKeres.TabIndex = 4;
            btnKonturKeres.Text = "Kontúr kereső";
            btnKonturKeres.UseVisualStyleBackColor = true;
            btnKonturKeres.Click += btnKonturKeres_Click;
            // 
            // btnVizjel
            // 
            btnVizjel.Location = new Point(30, 55);
            btnVizjel.Name = "btnVizjel";
            btnVizjel.Size = new Size(79, 23);
            btnVizjel.TabIndex = 5;
            btnVizjel.Text = "Vízjel";
            btnVizjel.UseVisualStyleBackColor = true;
            btnVizjel.Click += btnVizjel_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Fileok|*.jpg";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "JPEG Fileok|*.jpg";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnVizjel);
            groupBox1.Location = new Point(818, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 89);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vízjel";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 630);
            Controls.Add(groupBox1);
            Controls.Add(btnKonturKeres);
            Controls.Add(btnSzinezo);
            Controls.Add(btnMent);
            Controls.Add(btnBetolt);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBetolt;
        private Button btnMent;
        private Button btnSzinezo;
        private Button btnKonturKeres;
        private Button btnVizjel;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pictureModeToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem strechToolStripMenuItem;
        private ToolStripMenuItem automaticToolStripMenuItem;
        private ToolStripMenuItem centerToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}
