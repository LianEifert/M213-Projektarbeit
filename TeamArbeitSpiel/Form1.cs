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

       
        int AnzSpieler;


        private void btnPlay_Click(object sender, EventArgs e)
        {            
            Random Rand = new Random();
            RandomZahl = Rand.Next(1, 100);
            AnzSpieler = Convert.ToInt32(txbAnzSpieler.Text);

            picBoxArrowLeft.Visible = false;
            picBoxArrowRight.Visible = false;
            btnPlay.Visible = false;
            txbAnzSpieler.Visible = false;

            lblAnzSpieler.Text = "Jetzt müssen sie sich gegenseitig Vetrauen. Was denken sie, wue nahe sind sie an diese Zahl?\n Geben sie eine Zahl von Scala 1-10 in ihrem zugehörigen Feld an! ";
            lblAnzSpieler.Font = new Font("Microsoft Sans Serif", 12);
            lblAnzSpieler.Left = 75;
            lblAnzSpieler.Top = 110;

            Label lblZahl = new Label();
            lblZahl.Text = "Zahl";
            lblZahl.Font = new Font("Microsoft Sans Serif", 24);
            lblZahl.Height = 30;
            lblZahl.Top = 20;
            lblZahl.Left = 375;
            lblZahl.BackColor = Color.Transparent;
            this.Controls.Add(lblZahl);


            Label lblRandomZahl = new Label();
            lblRandomZahl.Text = RandomZahl.ToString();
            lblRandomZahl.Font = new Font("Microsoft Sans Serif", 24);
            lblRandomZahl.Height=30;
            lblRandomZahl.Top = 65;
            lblRandomZahl.Left = 390;
            lblRandomZahl.BackColor = Color.Transparent;
            this.Controls.Add(lblRandomZahl);



            //Button Zahlanschauen = new Button();
            //Zahlanschauen.Text = "Drücken um die Zahl des ersten Spielers zu sehen";
            //Zahlanschauen.Top = 100;
            //Zahlanschauen.Left = 100;
            //Zahlanschauen.Width = 280;
            //Zahlanschauen.Click += Zahlenanschauen_Click;
            //this.Controls.Add(Zahlanschauen);
            
            int zähler = 1;
            int LblTop = 200;

            for(int i = 0;i < AnzSpieler;i++)
            {
                int RandomZahl2 = Rand.Next(1, 100);

                Zahlen.Add(RandomZahl2);

                //Label Text = new Label();
                //Text.Text = "Spieler " + zähler;
                //Text.Left = 100;
                //Text.Top = LblTop;
                //this.Controls.Add(Text);
                
                //TextBox Zahl = new TextBox();
                //Zahl.Left = 200;
                //Zahl.Top = LblTop;
                //this.Controls.Add(Zahl);
                //Zahl.TextChanged += Textgeändert;

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
                Voting();

            }


        }
        List<int> ints = new List<int>();
        int votedPlayers = 0;
        int votep;
        int votep1;
        int votep2;
        int votep3;
        int votep4;
        int votep5;
        int votep6;
        int votep7;
        int votep8;
        int votep9;

        
        private void Vote_CLick(object sender, EventArgs e)
        {
            
            Button Vote_click = (Button)sender;
            votedPlayers++;

           for(int i = 0; i < ints.Count; i++)
            {
                if (Vote_click.Text == "Wähle Spieler "+(i+1))
                {
                    ints[i]++;
                }
            }

            if (votedPlayers == AnzSpieler)
            {
                Voting vote = new Voting();
                vote.votes = ints;
                BeginneAuswertung(vote.VoteSystem());
            }
        }
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

                Button Vote = new Button();
                Vote.Text = "Wähle Spieler " + (i + 1);
                Vote.Left = left;
                Vote.Top = 340;
                this.Controls.Add(Vote);
                left = left + 110;
                Vote.Click += Vote_CLick;

            }

            

        }
        PictureBox p = new PictureBox();

        private void BeginneAuswertung(int index)
        {
            int unterschied = Math.Abs(Zahlen[index] - RandomZahl);

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

        private void Form1_Load(object sender, EventArgs e)
        {
            ints.Add(votep1);
            ints.Add(votep2);
            ints.Add(votep3);
            ints.Add(votep4);
            ints.Add(votep5);
            ints.Add(votep6);
            ints.Add(votep7);
            ints.Add(votep8);
            ints.Add(votep9);
            picBoxArrowLeft.BackColor = Color.Transparent;
            picBoxArrowRight.BackColor = Color.Transparent;
            lblAnzSpieler.BackColor = Color.Transparent;
            

        }
    }
}
