﻿using System;
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
                Voting();

            }


        }
        List<int> votes = new List<int>();
        int votedPlayers = 0;
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
           
            if(Vote_click.Text == "Wähle Spieler 1")
            {
                votep1++;
            }
            if (Vote_click.Text == "Wähle Spieler 2")
            {
                votep2++;
            }
            if (Vote_click.Text == "Wähle Spieler 3")
            {
                votep3++;
            }
            if (Vote_click.Text == "Wähle Spieler 4")
            {
                votep4++;
            }
            if (Vote_click.Text == "Wähle Spieler 5")
            {
                votep5++;
            }
            if (Vote_click.Text == "Wähle Spieler 6")
            {
                votep6++;
            }
            if (Vote_click.Text == "Wähle Spieler 7")
            {
                votep7++;
            }
            if (Vote_click.Text == "Wähle Spieler 8")
            {
                votep8++;
            }
            if (Vote_click.Text == "Wähle Spieler 9")
            {
                votep9++;
            }

            if (votedPlayers == AnzSpieler)
            {
                votes.Add(votep1);
                votes.Add(votep2);
                votes.Add(votep3);
                votes.Add(votep4);
                votes.Add(votep5);
                votes.Add(votep6);
                votes.Add(votep7);
                votes.Add(votep8);
                votes.Add(votep9);
                int gevotetindex =  votes.IndexOf(votes.Max());

                BeginneAuswertung(gevotetindex);
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

    }
}
