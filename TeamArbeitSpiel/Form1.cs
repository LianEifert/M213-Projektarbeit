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
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        //Alle globalen Variablen
        int RandomZahl;
        int AnzSpieler;
        int[] spielerVotes;
        int votedPlayers = 0;

        //Alle globalen Listen
        List<int> spielerZahlen = new List<int>();
        List<int> Zahlen = new List<int>();
        List<Label> Vote_Labels = new List<Label>();

        //Alle globalen Form Elemente
        Button Zahlanschauen = new Button();
        Label lblZahl = new Label();
        Label lblRandomZahl = new Label();
        PictureBox p = new PictureBox();

        //Globale RandomNumber
        RandomNumber random = new RandomNumber();

        /// <summary>
        /// Was beim Laden des Form1 passieren soll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            picBoxArrowLeft.BackColor = Color.Transparent;
            picBoxArrowRight.BackColor = Color.Transparent;
            lblAnzSpieler.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Was passieren soll, wenn der btnPlay gedrückt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            RandomZahl = random.RandomZahl(Zahlen);
            try
            {
                AnzSpieler = Convert.ToInt32(txbAnzSpieler.Text);
                if (AnzSpieler > 9 || AnzSpieler < 3)
                {
                    MessageBox.Show("Die Anzahl Spieler ist zu klein oder zu gross");
                }
            }

            catch
            {
                MessageBox.Show("Sie müssen eine Zahl eingeben.\n Der Default von drei Spielern wurde festgelegt");
                AnzSpieler = 3;
            }

            spielerVotes = new int[AnzSpieler];

            Random Rand = new Random();
            RandomZahl = Rand.Next(1, 100);

            picBoxArrowLeft.Visible = false;
            picBoxArrowRight.Visible = false;

            btnPlay.Visible = false;
            txbAnzSpieler.Visible = false;

            lblAnzSpieler.Text = "Jetzt müssen Sie sich gegenseitig vetrauen. Was denken Sie, wie nahe sind Sie an dieser Zahl?\n Geben sie eine Zahl auf einer Skala von 1-10 in ihrem zugehörigen Feld an! ";
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
            lblRandomZahl.Height = 30;
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

            for (int i = 0; i < AnzSpieler; i++)
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

        /// <summary>
        /// Legt fest, welcher Spieler am Zuge ist und gibt die entsprechenden Messageboxen aus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zahlenanschauen_Click(object sender, EventArgs e)
        {
            int Spieler = 1;

            foreach (int zahl in Zahlen)
            {
                string t = zahl.ToString();

                if (Spieler == 1)
                {
                    MessageBox.Show("Der erste Spieler ist am Zug");
                }
                else if (DialogResult.OK == MessageBox.Show("Der nächste Spieler ist dran", "Drücken für die nächste Zahl", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {

                }
                if (DialogResult.OK == MessageBox.Show("Spieler " + Spieler + " hat die Zahl: " + t, "OK drücken wenn die Zahl gemerkt wurde", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {

                }
                Spieler++;
            }

        }

        /// <summary>
        /// Legt fest, welcher Spieler schlussendlich gevotet wird und entscheidet ob man gewinnt oder nicht
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vote_Click(object sender, EventArgs e)
        {

            Button vote_click = (Button)sender;
            votedPlayers++;

            for (int i = 0; i < spielerVotes.Length; i++)
            {
                if (vote_click.Text == (i + 1) + ". Spieler wählen")
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

                else
                {
                    MessageBox.Show("Verloren da sich das Team nicht geeinigt hat");
                    Close();
                }
            }
        }

        /// <summary>
        /// Try and Catch für die Eingaben und ein Countdown, wenn nicht eingegeben wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (temp.Text != "")
                {
                    MessageBox.Show("Keine Zahl eingegeben");
                }
                temp.Text = "";
                temp.ReadOnly = false;
            }

            if (spielerZahlen.Count == AnzSpieler)
            {
                Voting();

                lblAnzSpieler.Text = "Wenn eine Minute vorbei ist, müssen Sie einen finalen Entscheid treffen und einen Spieler auswählen. \nJetzt kann gar nicht mehr kommuniziert werden und Ihr müsst euch gegenseitig vertrauen!";
                lblAnzSpieler.TextAlign = ContentAlignment.MiddleCenter;
                lblAnzSpieler.Left = 60;
            }
        }

        /// <summary>
        /// Funktion für das Voting System
        /// </summary>
        private void Voting()
        {
            int left = 500;
            int counter = 1;
            int top = 250;

            for (int i = 0; i < AnzSpieler; i++)
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
                Votes.BackColor = Color.Transparent;
                Votes.Text = "Votes: 0";
                Votes.Left = left + 220;
                Votes.Top = top + 5;
                Vote_Labels.Add(Votes);
                this.Controls.Add(Votes);

                Button Vote = new Button();
                Vote.Text = (i + 1) + ". Spieler wählen";
                Vote.Width = 100;
                Vote.Left = left + 100;
                Vote.Top = top;
                this.Controls.Add(Vote);
                top = top + 30;
                Vote.Click += Vote_Click;
                counter++;
            }
        }

        /// <summary>
        /// Teilt mit, wer gewonnen hat oder verloren
        /// </summary>
        /// <param name="index"></param>
        private void BeginneAuswertung(int index)
        {
            int unterschied = Math.Abs(Zahlen[index] - RandomZahl);

            for (int i = 0; i < Zahlen.Count; i++)
            {
                if (Math.Abs((Zahlen[i] - RandomZahl)) < unterschied)
                {
                    MessageBox.Show("Sie haben verloren");
                    Close();
                }
                else if (Math.Abs((Zahlen[i] - RandomZahl)) > unterschied)
                {
                    MessageBox.Show("Sie haben gewonnen");
                    Close();
                }
            }
        }

    }
}
