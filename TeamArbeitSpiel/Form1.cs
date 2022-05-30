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


        Button Zahlanschauen = new Button();
        Label lblZahl = new Label();
        Label lblRandomZahl = new Label();

        private void btnPlay_Click(object sender, EventArgs e)
        {            
            Random Rand = new Random();
            RandomZahl = Rand.Next(1, 100);
            AnzSpieler = Convert.ToInt32(txbAnzSpieler.Text);

            picBoxArrowLeft.Visible = false;
            picBoxArrowRight.Visible = false;

            btnPlay.Visible = false;
            txbAnzSpieler.Visible = false;

            lblAnzSpieler.Text = "Jetzt müssen sie sich gegenseitig Vetrauen. Was denken sie, wie nahe sind sie an diese Zahl?\n Geben sie eine Zahl von Scala 1-10 in ihrem zugehörigen Feld an! ";
            lblAnzSpieler.Font = new Font("Microsoft Sans Serif", 12);
            lblAnzSpieler.Left = 75;
            lblAnzSpieler.Top = 120;
            lblAnzSpieler.TextAlign = ContentAlignment.MiddleCenter;

            
            lblZahl.Text = "Zahl";
            lblZahl.Font = new Font("Microsoft Sans Serif", 24);
            lblZahl.Height = 30;
            lblZahl.Top = 20;
            lblZahl.Left = 370;
            lblZahl.BackColor = Color.Transparent;
            this.Controls.Add(lblZahl);


           
            lblRandomZahl.Text = RandomZahl.ToString();
            lblRandomZahl.Font = new Font("Microsoft Sans Serif", 24);
            lblRandomZahl.Height=30;
            lblRandomZahl.Top = 65;
            lblRandomZahl.Left = 385;
            lblRandomZahl.BackColor = Color.Transparent;
            this.Controls.Add(lblRandomZahl);



            
            Zahlanschauen.Font = new Font("Microsoft Sans Serif", 12);
            Zahlanschauen.Text = "Zahlen verteilen";
            Zahlanschauen.Top = 180;
            Zahlanschauen.Left = 275;
            Zahlanschauen.Width = 280;
            Zahlanschauen.Height = 50;
            Zahlanschauen.Click += Zahlenanschauen_Click;
            this.Controls.Add(Zahlanschauen);

            int zähler = 1;
            int LblTop = 250;

            for(int i = 0;i < AnzSpieler;i++)
            {
                int RandomZahl2 = random.RandomZahl(Zahlen);

                Zahlen.Add(RandomZahl2);
                Label Text = new Label();
                Text.Text = "Spieler " + zähler;
                Text.BackColor = Color.Transparent;
                Text.Font = new Font("Microsoft Sans Serif", 11);
                Text.Left = 100;
                Text.Top = LblTop;
                this.Controls.Add(Text);
                
                TextBox Zahl = new TextBox();
                Zahl.Left = 200;
                Zahl.Top = LblTop;
                this.Controls.Add(Zahl);
                Zahl.TextChanged += Textgeändert;

                LblTop = LblTop + 30;
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

                Zahlanschauen.Visible = false;
                lblAnzSpieler.Text = "Nachdem 1 Minute vorbei ist, müssen sie ein finales Entscheid treffen und einen Spieler auswählen. \nJetzt kann gar nicht kommuniziert werden und ihr müsst euch gegenseitig vertrauen!";
                lblAnzSpieler.TextAlign = ContentAlignment.MiddleCenter;
                lblAnzSpieler.Left = 60;
                
                
            }
        }
        int votedPlayers = 0;

        private void Vote_CLick(object sender, EventArgs e)
        {

            Button Vote_click = (Button)sender;
            votedPlayers++;

            for (int i = 0; i < spielerVotes.Length; i++)
            {
                if (Vote_click.Text == "Wähle Spieler " + (i + 1))
                {
                    spielerVotes[i]++;
                }
                if (Convert.ToString(Vote_Labels[i].Tag) == "Spieler" + (i + 1))
                {
                    Vote_Labels[i].Text = "Votes: " + Convert.ToString(spielerVotes[i]);
                }
            }

            if (votedPlayers == AnzSpieler)
            {
                Voting vote = new Voting();
                vote.votes = spielerVotes;

                if (vote.votesure())
                {
                    
                    BeginneAuswertung(vote.VoteSystem());
                }
                else {

                    MessageBox.Show("Verloren da sich das Team nicht einigen konnte");
                    Close();
                }

            }
        }
        List<Label> Vote_Labels = new List<Label>();
        private void Voting()
        {
            int left = 500;
            int counter = 1;
            int top = 250;
            
            for (int i = 0; i < AnzSpieler;i++)
            {

                Label Spieler = new Label();
                Spieler.Text = "Spieler " + (i + 1);
                Spieler.Left = left;
                Spieler.Font = new Font("Microsoft Sans Serif", 11);
                Spieler.BackColor = Color.Transparent;
                Spieler.Top = top;
                this.Controls.Add(Spieler);

                Label Votes = new Label();
                Votes.Tag = "Spieler" + (i + 1);
                Votes.Text = "Votes: 0";
                Votes.Left = left;
                Votes.Top = 320;
                Vote_Labels.Add(Votes);
                this.Controls.Add(Votes);

                

                Button Vote = new Button();
                Vote.Text = (i + 1) + ". Spieler wählen";
                Vote.Width = 100;
                Vote.Left = left + 100;
                Vote.Top = top;
                this.Controls.Add(Vote);
                top = top + 30;
                Vote.Click += Vote_CLick;
                counter++;
            }

            

        }
        PictureBox p = new PictureBox();

        private void BeginneAuswertung(int index)
        {

            int unterschied = Math.Abs(Zahlen[index] - RandomZahl);

            for(int i = 0; i < Zahlen.Count;i++)
            {
                if (Math.Abs((Zahlen[i] - RandomZahl)) < unterschied)
                {
                    MessageBox.Show("Verloren");
                    Close();
                }
                else if(Math.Abs((Zahlen[i] - RandomZahl)) > unterschied)
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
    }
}
