
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
      this.txbAnzSpieler.Location = new System.Drawing.Point(152, 57);
      this.txbAnzSpieler.Margin = new System.Windows.Forms.Padding(2);
      this.txbAnzSpieler.Name = "txbAnzSpieler";
      this.txbAnzSpieler.Size = new System.Drawing.Size(95, 22);
      this.txbAnzSpieler.TabIndex = 0;
      // 
      // lblAnzSpieler
      // 
      this.lblAnzSpieler.AutoSize = true;
      this.lblAnzSpieler.Location = new System.Drawing.Point(45, 57);
      this.lblAnzSpieler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblAnzSpieler.Name = "lblAnzSpieler";
      this.lblAnzSpieler.Size = new System.Drawing.Size(96, 16);
      this.lblAnzSpieler.TabIndex = 1;
      this.lblAnzSpieler.Text = "Anzahl Spieler:";
      // 
      // btnPlay
      // 
      this.btnPlay.Location = new System.Drawing.Point(48, 111);
      this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new System.Drawing.Size(289, 147);
      this.btnPlay.TabIndex = 2;
      this.btnPlay.Text = "Spielen";
      this.btnPlay.UseVisualStyleBackColor = true;
      this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(560, 386);
      this.Controls.Add(this.btnPlay);
      this.Controls.Add(this.lblAnzSpieler);
      this.Controls.Add(this.txbAnzSpieler);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAnzSpieler;
        private System.Windows.Forms.Label lblAnzSpieler;
        private System.Windows.Forms.Button btnPlay;
    }
}

