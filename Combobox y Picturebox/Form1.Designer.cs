namespace Combobox_y_Picturebox
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
            LbDescribcion = new Label();
            PicLogo = new PictureBox();
            LinkLabel1 = new LinkLabel();
            comboDistro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            SuspendLayout();
            // 
            // LbDescribcion
            // 
            LbDescribcion.AutoSize = true;
            LbDescribcion.Location = new Point(292, 43);
            LbDescribcion.Name = "LbDescribcion";
            LbDescribcion.Size = new Size(38, 15);
            LbDescribcion.TabIndex = 0;
            LbDescribcion.Text = "label1";
            // 
            // PicLogo
            // 
            PicLogo.Location = new Point(12, 43);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(269, 231);
            PicLogo.TabIndex = 1;
            PicLogo.TabStop = false;
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(287, 270);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(60, 15);
            LinkLabel1.TabIndex = 2;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "linkLabel1";
            // 
            // comboDistro
            // 
            comboDistro.FormattingEnabled = true;
            comboDistro.Location = new Point(12, 12);
            comboDistro.Name = "comboDistro";
            comboDistro.Size = new Size(542, 23);
            comboDistro.TabIndex = 4;
            comboDistro.SelectedIndexChanged += comboDistro_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 349);
            Controls.Add(comboDistro);
            Controls.Add(LinkLabel1);
            Controls.Add(PicLogo);
            Controls.Add(LbDescribcion);
            Name = "Form1";
            Text = "Selector de distribuciones";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbDescribcion;
        private PictureBox PicLogo;
        private LinkLabel LinkLabel1;
        private ComboBox comboDistro;
    }
}
