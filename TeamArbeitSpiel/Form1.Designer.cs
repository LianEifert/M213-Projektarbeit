
namespace TeamArbeitSpiel
{
    partial class Form1
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
            this.txbAnzSpieler = new System.Windows.Forms.TextBox();
            this.lblAnzSpieler = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbAnzSpieler
            // 
            this.txbAnzSpieler.Location = new System.Drawing.Point(304, 111);
            this.txbAnzSpieler.Name = "txbAnzSpieler";
            this.txbAnzSpieler.Size = new System.Drawing.Size(186, 38);
            this.txbAnzSpieler.TabIndex = 0;
            // 
            // lblAnzSpieler
            // 
            this.lblAnzSpieler.AutoSize = true;
            this.lblAnzSpieler.Location = new System.Drawing.Point(90, 111);
            this.lblAnzSpieler.Name = "lblAnzSpieler";
            this.lblAnzSpieler.Size = new System.Drawing.Size(208, 32);
            this.lblAnzSpieler.TabIndex = 1;
            this.lblAnzSpieler.Text = "Anzahl Spieler:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(96, 215);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(578, 284);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Spielen";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 747);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblAnzSpieler);
            this.Controls.Add(this.txbAnzSpieler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAnzSpieler;
        private System.Windows.Forms.Label lblAnzSpieler;
        private System.Windows.Forms.Button btnPlay;
    }
}

