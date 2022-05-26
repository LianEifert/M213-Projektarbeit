
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
            this.txbAnzSpieler.Location = new System.Drawing.Point(350, 313);
            this.txbAnzSpieler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txbAnzSpieler.Name = "txbAnzSpieler";
            this.txbAnzSpieler.Size = new System.Drawing.Size(72, 20);
            this.txbAnzSpieler.TabIndex = 0;
            this.txbAnzSpieler.Text = "3-9";
            // 
            // lblAnzSpieler
            // 
            this.lblAnzSpieler.AutoSize = true;
            this.lblAnzSpieler.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzSpieler.Location = new System.Drawing.Point(250, 276);
            this.lblAnzSpieler.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnzSpieler.Name = "lblAnzSpieler";
            this.lblAnzSpieler.Size = new System.Drawing.Size(277, 25);
            this.lblAnzSpieler.TabIndex = 1;
            this.lblAnzSpieler.Text = "Geben sie den Spieleranzahl an";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(141, 173);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(478, 89);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Spiel starten";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 506);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblAnzSpieler);
            this.Controls.Add(this.txbAnzSpieler);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "The close one out";
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

