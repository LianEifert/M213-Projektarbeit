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
        List<int> spielerZahlen = new List<int>();
        List<int> Zahlen = new List<int>();


        int RandomZahl;

        public Form1()
        {
            InitializeComponent();
        }

       
        int AnzSpieler;
        int[] spielerVotes;

        RandomNumber random = new RandomNumber();

        private void btnPlay_Click(object sender, EventArgs e)
        {


            RandomZahl = random.RandomZahl(Zahlen);

        try
        {
            AnzSpieler = Convert.ToInt32(txbAnzSpieler.Text);
            if (AnzSpieler > 9 || AnzSpieler < 3)
            {
                    MessageBox.Show("Falsche Anzahl Spieler");
            }
        }
        catch (Exception AnzSPNull)
        {
            MessageBox.Show("Sie Müssen eine Zahl eingeben.\nDefault 3 Spieler Initialisiert");
            AnzSpieler = 3;
        }
           
            spielerVotes = new int[AnzSpieler];

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
                int RandomZahl2 = random.RandomZahl(Zahlen);

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
            temp.ReadOnly = true;

            try
            {
                spielerZahlen.Add(Convert.ToInt32(temp.Text));
            }
            
            catch (FormatException)
            {
                if(temp.Text != "")
                {
                    MessageBox.Show("Not a Number");
                }
                temp.Text = "";
                temp.ReadOnly = false;

            }


            if (spielerZahlen.Count == AnzSpieler)
            {
                Voting();

            }



        }
        int votedPlayers = 0;
        
        private void Vote_CLick(object sender, EventArgs e)
        {
            
            Button Vote_click = (Button)sender;
            votedPlayers++;

           for(int i = 0; i < spielerVotes.Length; i++)
            {
                if (Vote_click.Text == "Wähle Spieler "+(i+1))
                {
                    spielerVotes[i]++;
                }
                if(Convert.ToString(Vote_Labels[i].Tag) == "Spieler"+(i+1))
                {
                    Vote_Labels[i].Text = "Votes: "+Convert.ToString(spielerVotes[i]);
                }
            }

            if (votedPlayers == AnzSpieler)
            {
                Voting vote = new Voting();
                vote.votes = spielerVotes;
                BeginneAuswertung(vote.VoteSystem());
            }
        }
        List<Label> Vote_Labels = new List<Label>();
        private void Voting()
        {
            int left = 400;
           
            for (int i = 0; i < AnzSpieler;i++)
            {

                Label Spieler = new Label();
                Spieler.Text = "Spieler: " + (i + 1);
                Spieler.Left = left;
                Spieler.Top = 300;
                this.Controls.Add(Spieler);

                Label Votes = new Label();
                Votes.Tag = "Spieler" + (i + 1);
                Votes.Text = "Votes: 0";
                Votes.Left = left;
                Votes.Top = 320;
                Vote_Labels.Add(Votes);
                this.Controls.Add(Votes);

                

                Button Vote = new Button();
                Vote.Text = "Wähle Spieler " + (i + 1);
                Vote.Left = left;
                Vote.Top = 350;
                this.Controls.Add(Vote);
                left = left + 110;
                Vote.Click += Vote_CLick;

            }

            

        }
        PictureBox p = new PictureBox();

        private void BeginneAuswertung(int index)
        {

            int unterschied = Zahlen[index] - RandomZahl;

            for(int i = 0; i < Zahlen.Count;i++)
            {
                if ((Zahlen[i] - RandomZahl) < unterschied)
                {
                    MessageBox.Show("Verloren");
                    Close();
                }
                else
                { 
                    MessageBox.Show("Gewonnen");
                    Close();
                }   
            }
        }
        private void Zahlenanschauen_Click(object sender, EventArgs e)
        {
                int Spieler = 1;
            
            foreach (int zahl in Zahlen)
            {
                string t = zahl.ToString();

                if(Spieler == 1)
                {
                    MessageBox.Show("Der erste Spieler ist am Zug");
                }
                else if (DialogResult.OK == MessageBox.Show("Der nächste Spieler ist dran", "Drücken für nächste Zahl", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {

                }
                if (DialogResult.OK == MessageBox.Show("Spieler "+Spieler+" hat die Zahl: "+t,"OK drücken wenn die Zahl gemerkt wurde",MessageBoxButtons.OK,MessageBoxIcon.Information))
                {

                }
                
                Spieler++;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
