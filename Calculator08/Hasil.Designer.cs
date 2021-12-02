
namespace Calculator08
{
    partial class Hasil
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
            this.lvHasil = new System.Windows.Forms.ListView();
            this.gbxHasil = new System.Windows.Forms.GroupBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.gbxHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvHasil
            // 
            this.lvHasil.HideSelection = false;
            this.lvHasil.Location = new System.Drawing.Point(17, 20);
            this.lvHasil.Name = "lvHasil";
            this.lvHasil.Size = new System.Drawing.Size(620, 341);
            this.lvHasil.TabIndex = 0;
            this.lvHasil.UseCompatibleStateImageBehavior = false;
            // 
            // gbxHasil
            // 
            this.gbxHasil.Controls.Add(this.btnHitung);
            this.gbxHasil.Controls.Add(this.lvHasil);
            this.gbxHasil.Location = new System.Drawing.Point(5, 14);
            this.gbxHasil.Name = "gbxHasil";
            this.gbxHasil.Size = new System.Drawing.Size(653, 405);
            this.gbxHasil.TabIndex = 1;
            this.gbxHasil.TabStop = false;
            this.gbxHasil.Text = "Hasil";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(16, 367);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(620, 37);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // Hasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 422);
            this.Controls.Add(this.gbxHasil);
            this.Name = "Hasil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.gbxHasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHasil;
        private System.Windows.Forms.GroupBox gbxHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}

