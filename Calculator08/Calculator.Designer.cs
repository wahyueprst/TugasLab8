
namespace Calculator08
{
    partial class Calculator
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
            this.lblOperasi = new System.Windows.Forms.Label();
            this.lblNilaiA = new System.Windows.Forms.Label();
            this.lblNilaiB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbOP = new System.Windows.Forms.ComboBox();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOperasi
            // 
            this.lblOperasi.AutoSize = true;
            this.lblOperasi.Location = new System.Drawing.Point(12, 17);
            this.lblOperasi.Name = "lblOperasi";
            this.lblOperasi.Size = new System.Drawing.Size(58, 17);
            this.lblOperasi.TabIndex = 0;
            this.lblOperasi.Text = "Operasi";
            // 
            // lblNilaiA
            // 
            this.lblNilaiA.AutoSize = true;
            this.lblNilaiA.Location = new System.Drawing.Point(12, 53);
            this.lblNilaiA.Name = "lblNilaiA";
            this.lblNilaiA.Size = new System.Drawing.Size(48, 17);
            this.lblNilaiA.TabIndex = 1;
            this.lblNilaiA.Text = "Nilai A";
            // 
            // lblNilaiB
            // 
            this.lblNilaiB.AutoSize = true;
            this.lblNilaiB.Location = new System.Drawing.Point(12, 84);
            this.lblNilaiB.Name = "lblNilaiB";
            this.lblNilaiB.Size = new System.Drawing.Size(48, 17);
            this.lblNilaiB.TabIndex = 2;
            this.lblNilaiB.Text = "Nilai B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbOP
            // 
            this.cmbOP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOP.FormattingEnabled = true;
            this.cmbOP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbOP.Items.AddRange(new object[] {
            "Pembagian",
            "Pengurangan",
            "Penjumlahan",
            "Perkalian"});
            this.cmbOP.Location = new System.Drawing.Point(100, 17);
            this.cmbOP.Name = "cmbOP";
            this.cmbOP.Size = new System.Drawing.Size(121, 24);
            this.cmbOP.Sorted = true;
            this.cmbOP.TabIndex = 4;
            // 
            // NilaiA
            // 
            this.NilaiA.Location = new System.Drawing.Point(100, 53);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(121, 22);
            this.NilaiA.TabIndex = 5;
            // 
            // NilaiB
            // 
            this.NilaiB.Location = new System.Drawing.Point(100, 84);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(121, 22);
            this.NilaiB.TabIndex = 6;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 168);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.cmbOP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNilaiB);
            this.Controls.Add(this.lblNilaiA);
            this.Controls.Add(this.lblOperasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperasi;
        private System.Windows.Forms.Label lblNilaiA;
        private System.Windows.Forms.Label lblNilaiB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NilaiA;
        private System.Windows.Forms.TextBox NilaiB;
        private System.Windows.Forms.ComboBox cmbOP;
    }
}