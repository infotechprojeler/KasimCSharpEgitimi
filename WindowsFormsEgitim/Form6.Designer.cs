namespace WindowsFormsEgitim
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.cbFontlar = new System.Windows.Forms.ComboBox();
            this.lblSeciliFont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font Boyutunu Değiştir";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 185);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(83, 250);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 22);
            this.domainUpDown1.TabIndex = 2;
            this.domainUpDown1.Text = "Seçiniz";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // cbFontlar
            // 
            this.cbFontlar.DisplayMember = "Name";
            this.cbFontlar.FormattingEnabled = true;
            this.cbFontlar.Location = new System.Drawing.Point(293, 250);
            this.cbFontlar.Name = "cbFontlar";
            this.cbFontlar.Size = new System.Drawing.Size(121, 24);
            this.cbFontlar.TabIndex = 3;
            this.cbFontlar.Text = "Font Seçiniz";
            this.cbFontlar.SelectedIndexChanged += new System.EventHandler(this.cbFontlar_SelectedIndexChanged);
            // 
            // lblSeciliFont
            // 
            this.lblSeciliFont.AutoSize = true;
            this.lblSeciliFont.Location = new System.Drawing.Point(470, 255);
            this.lblSeciliFont.Name = "lblSeciliFont";
            this.lblSeciliFont.Size = new System.Drawing.Size(44, 16);
            this.lblSeciliFont.TabIndex = 4;
            this.lblSeciliFont.Text = "label2";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeciliFont);
            this.Controls.Add(this.cbFontlar);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.ComboBox cbFontlar;
        private System.Windows.Forms.Label lblSeciliFont;
    }
}