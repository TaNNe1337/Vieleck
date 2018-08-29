namespace Vieleck
{
    partial class frm_start
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tb_seitenanzahl = new System.Windows.Forms.TextBox();
            this.tB_seitenlaenge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_berechnen = new System.Windows.Forms.Button();
            this.lbl_ausgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            // 
            // tb_seitenanzahl
            // 
            this.tb_seitenanzahl.Location = new System.Drawing.Point(151, 29);
            this.tb_seitenanzahl.Name = "tb_seitenanzahl";
            this.tb_seitenanzahl.Size = new System.Drawing.Size(100, 20);
            this.tb_seitenanzahl.TabIndex = 1;
            this.tb_seitenanzahl.Text = "Seitenzahl";
            // 
            // tB_seitenlaenge
            // 
            this.tB_seitenlaenge.Location = new System.Drawing.Point(31, 29);
            this.tB_seitenlaenge.Name = "tB_seitenlaenge";
            this.tB_seitenlaenge.Size = new System.Drawing.Size(100, 20);
            this.tB_seitenlaenge.TabIndex = 2;
            this.tB_seitenlaenge.Text = "Seitenlänge";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // cmd_berechnen
            // 
            this.cmd_berechnen.Location = new System.Drawing.Point(31, 115);
            this.cmd_berechnen.Name = "cmd_berechnen";
            this.cmd_berechnen.Size = new System.Drawing.Size(75, 23);
            this.cmd_berechnen.TabIndex = 4;
            this.cmd_berechnen.Text = "Berechnen";
            this.cmd_berechnen.UseVisualStyleBackColor = true;
            this.cmd_berechnen.Click += new System.EventHandler(this.cmd_berechnen_Click);
            // 
            // lbl_ausgabe
            // 
            this.lbl_ausgabe.AutoSize = true;
            this.lbl_ausgabe.Location = new System.Drawing.Point(112, 120);
            this.lbl_ausgabe.Name = "lbl_ausgabe";
            this.lbl_ausgabe.Size = new System.Drawing.Size(22, 13);
            this.lbl_ausgabe.TabIndex = 5;
            this.lbl_ausgabe.Text = "[...]";
            // 
            // frm_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 213);
            this.Controls.Add(this.lbl_ausgabe);
            this.Controls.Add(this.cmd_berechnen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_seitenlaenge);
            this.Controls.Add(this.tb_seitenanzahl);
            this.Controls.Add(this.button1);
            this.Name = "frm_start";
            this.Text = "berechnung Vieleck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_seitenanzahl;
        private System.Windows.Forms.TextBox tB_seitenlaenge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_berechnen;
        private System.Windows.Forms.Label lbl_ausgabe;
    }
}

