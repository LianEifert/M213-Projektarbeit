
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbAnzSpieler = new System.Windows.Forms.TextBox();
            this.lblAnzSpieler = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picBoxArrowLeft = new System.Windows.Forms.PictureBox();
            this.picBoxArrowRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrowRight)).BeginInit();
            this.SuspendLayout();
            // 
            // txbAnzSpieler
            // 
            this.txbAnzSpieler.Location = new System.Drawing.Point(367, 165);
            this.txbAnzSpieler.Margin = new System.Windows.Forms.Padding(1);
            this.txbAnzSpieler.Name = "txbAnzSpieler";
            this.txbAnzSpieler.Size = new System.Drawing.Size(72, 20);
            this.txbAnzSpieler.TabIndex = 0;
            this.txbAnzSpieler.Text = "3-9";
            this.txbAnzSpieler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnzSpieler
            // 
            this.lblAnzSpieler.AutoSize = true;
            this.lblAnzSpieler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblAnzSpieler.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzSpieler.Location = new System.Drawing.Point(269, 109);
            this.lblAnzSpieler.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnzSpieler.Name = "lblAnzSpieler";
            this.lblAnzSpieler.Size = new System.Drawing.Size(271, 25);
            this.lblAnzSpieler.TabIndex = 1;
            this.lblAnzSpieler.Text = "Geben sie die Spieleranzahl an";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(166, 245);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(478, 89);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Spiel starten";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // picBoxArrowLeft
            // 
            this.picBoxArrowLeft.BackColor = System.Drawing.Color.Moccasin;
            this.picBoxArrowLeft.Image = global::TeamArbeitSpiel.Properties.Resources.output_onlinepngtools_50_1_301;
            this.picBoxArrowLeft.Location = new System.Drawing.Point(327, 155);
            this.picBoxArrowLeft.Name = "picBoxArrowLeft";
            this.picBoxArrowLeft.Size = new System.Drawing.Size(36, 40);
            this.picBoxArrowLeft.TabIndex = 4;
            this.picBoxArrowLeft.TabStop = false;
            // 
            // picBoxArrowRight
            // 
            this.picBoxArrowRight.BackColor = System.Drawing.Color.Moccasin;
            this.picBoxArrowRight.Image = global::TeamArbeitSpiel.Properties.Resources.output_onlinepngtools_50_1_40;
            this.picBoxArrowRight.Location = new System.Drawing.Point(443, 155);
            this.picBoxArrowRight.Name = "picBoxArrowRight";
            this.picBoxArrowRight.Size = new System.Drawing.Size(43, 40);
            this.picBoxArrowRight.TabIndex = 5;
            this.picBoxArrowRight.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeamArbeitSpiel.Properties.Resources.Vitskärshällan__1_;
            this.ClientSize = new System.Drawing.Size(813, 506);
            this.Controls.Add(this.picBoxArrowRight);
            this.Controls.Add(this.picBoxArrowLeft);
            this.Controls.Add(this.lblAnzSpieler);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txbAnzSpieler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The close one out";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArrowRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAnzSpieler;
        private System.Windows.Forms.Label lblAnzSpieler;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picBoxArrowLeft;
        private System.Windows.Forms.PictureBox picBoxArrowRight;
    }
}

