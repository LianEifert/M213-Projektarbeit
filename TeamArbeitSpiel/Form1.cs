using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamArbeitSpiel
{
    public partial class Form1 : Form
    {
        List<int> Spielerzahlen = new List<int>();
        List<int> Zahlen = new List<int>();

        int RandomZahl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
             RandomZahl = Rand.Next(1, 100);

            int AnzSpieler = Convert.ToInt32(txbAnzSpieler.Text);

            btnPlay.Visible = false;
            txbAnzSpieler.Visible = false;
            lblAnzSpieler.Text = "Jeder Spieler gibt die Zahl von 1 bis 10 ein. Die Zahl ist: " + RandomZahl;

            Button Zahlanschauen = new Button();
            Zahlanschauen.Text = "Drücken um die Zahl des ersten Spielers zu sehen";
            Zahlanschauen.Top = 100;
            Zahlanschauen.Left = 100;
            Zahlanschauen.Width = 280;
            Zahlanschauen.Click += Zahlenanschauen_Click;
            this.Controls.Add(Zahlanschauen);

            int zähler = 1;
            int LblTop = 200;

            for(int i = 0;i < AnzSpieler;i++)
            {
                int RandomZahl2 = Rand.Next(1, 100);

                Zahlen.Add(RandomZahl2);

                Label Text = new Label();
                Text.Text = "Spieler " + zähler;
                Text.Left = 100;
                Text.Top = LblTop;
                this.Controls.Add(Text);
                
                TextBox Zahl = new TextBox();
                Zahl.Left = 200;
                Zahl.Top = LblTop;
                this.Controls.Add(Zahl);
                Zahl.TextChanged += Textgeändert;

                LblTop = LblTop + 40;
                zähler++;


            }

            

        }
        private void Textgeändert(object sender, EventArgs e)
        {
            
            TextBox temp = (TextBox)sender;

                Spielerzahlen.Add(Convert.ToInt32(temp.Text));
            
            if (Spielerzahlen.Count == Convert.ToInt32(txbAnzSpieler.Text))
            {
                BeginneAuswertung();
            }

        
        }

        private void Voting()
        {

            for(int i = 0; i < )


        }
        private void BeginneAuswertung()
        {

            Voting();



           int indexdesgrössten = Spielerzahlen.IndexOf(Spielerzahlen.Max());

            int unterschied = Math.Abs(Zahlen[indexdesgrössten] - RandomZahl);
            for(int i = 0; i < Zahlen.Count;i++)
            {
                if (Math.Abs(Zahlen[i] - RandomZahl) < unterschied)
                {
                    MessageBox.Show("Verloren");
                    Close();
                }
                else
                    MessageBox.Show("Gewonnen");
                Close();
            }
        }
        private void Zahlenanschauen_Click(object sender, EventArgs e)
        {
                int Spieler = 1;

            foreach (int zahl in Zahlen)
            {
                string t = zahl.ToString();

                if (DialogResult.OK == MessageBox.Show("Spieler "+Spieler+" hat die Zahl: "+t,"OK drücken wenn die Zahl gemerkt wurde",MessageBoxButtons.OK,MessageBoxIcon.Information))
                {

                }
                if (DialogResult.OK == MessageBox.Show("Der nächste Spieler ist dran","Drücken für nächste Zahl", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {

                }
                Spieler++;

            }


        }

    }
}
