using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monoploy_Project
{
    public partial class Form1 : Form

    {
        // Turn Counter 
        int TurnCounter = 1;


        // list of players postions grid locaions
        List<int> square_namesX = new List<int>();
        List<int> square_namesY = new List<int>();
        // player postion
        int Player1_Postion = 24;
        int Player2_Postion = 0;
        int Player3_Postion = 0;
        int Player4_Postion = 0;
        // player money 
        int player1Money = 150;
        int player2Money = 150;
        int player3Money = 150;
        int player4Money = 150;
        // player own 
        const int go_place_player_Own = 0;
        int old_kent_player_Own = 0;
        const int community_chest_player_Own = 0;
        int white_chapel_player_Own = 0;
        const int income_tax_pay_player_Own = 0;
        int kings_cross_station_player_Own = 0;
        int the_angel_lslington_player_Own = 0;
        const int chance_player_Own = 0;
        int euston_road_player_Own = 0;
        int penton_vile_road_player_Own = 0;
        const int jail_player_Own = 0;
        int pall_mall_player_Own = 0;
        int electric_company_player_Own = 0;
        int whitehall_player_Own = 0;
        int northunrld_avenue_player_Own = 0;
        int marylebone_station_player_Own = 0;
        int bow_street_player_Own = 0;
        const int community_chest_2_player_Own = 0;
        int marlborough_street_player_Own = 0;
        int vine_street_player_Own = 0;
        const int free_parking_player_Own = 0;
        int strand_player_Own = 0;
        const int chance_2_player_Own = 0;
        int fleet_street_player_Own = 0;
        int trafalgar_square_player_Own = 0;
        int fenchurch_st_station_player_Own = 0;
        int leicester_square_player_Own = 0;
        int coventry_street_player_Own = 0;
        int water_works_player_Own = 0;
        int piccadilly_player_Own = 0;
        const int go_to_jail_player_Own = 0;
        int regent_street_player_Own = 0;
        int oxford_street_player_Own = 0;
        const int community_chest_3_player_Own = 0;
        int bond_street_player_Own = 0;
        int liverpool_st_station_player_Own = 0;
        const int chance_3_player_Own = 0;
        int park_lane_player_Own = 0;
        const int super_tax_pay_player_Own = 0;
        int mayfair_player_Own = 0;
        // places costs 
        const int Go_Money = 200;
        const int Old_Kent_Road_cost = 60;
        const int White_Chapel_cost = 60;
        const int Income_Tax_Pay_cost = 200;
        const int Kings_Cross_Station_cost = 200;
        const int The_Angel_Lsington_cost = 100;
        const int Euston_Road_cost = 100;
        const int Penton_Vile_cost = 120;
        const int Pall_Mall_cost = 140;
        const int Electric_Company_cost = 150;
        const int Whitehall_cost = 140;
        const int Northunrld_Avenue_cost = 160;
        const int Marylebone_Station_cost = 200;
        const int Bow_Street_cost = 180;
        const int Marlborough_Street_cost = 180;
        const int Vine_Street_cost = 200;
        const int Strand_Cost = 220;
        const int Fleet_Street_cost = 220;
        const int Trafalgar_Square_cost = 240;
        const int Fenchurch_St_Station_cost = 200;
        const int Leicester_Square_cost = 260;
        const int Coventry_Street_cost = 260;
        const int Water_Works_cost = 150;
        const int Piccadilly_cost = 280;
        const int Regent_Street_cost = 300;
        const int Oxford_Street_cost = 300;
        const int Bond_Street_cost = 320;
        const int Liverpool_St_Station_cost = 200;
        const int Park_Lane_cost = 350;
        const int Super_Tax_cost = 100;
        const int Mayfair_cost = 400;


        public Form1() // contents list and form
        {
            InitializeComponent();



            square_namesX.Add(670);
            square_namesX.Add(611);
            square_namesX.Add(552);
            square_namesX.Add(493);
            square_namesX.Add(434);
            square_namesX.Add(375);
            square_namesX.Add(316);
            square_namesX.Add(257);
            square_namesX.Add(198);
            square_namesX.Add(134);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(34);
            square_namesX.Add(134);
            square_namesX.Add(193);
            square_namesX.Add(252);
            square_namesX.Add(311);
            square_namesX.Add(370);
            square_namesX.Add(429);
            square_namesX.Add(488);
            square_namesX.Add(552);
            square_namesX.Add(611);
            square_namesX.Add(670);
            square_namesX.Add(671);
            square_namesX.Add(671);
            square_namesX.Add(671);
            square_namesX.Add(671);
            square_namesX.Add(671);
            square_namesX.Add(671);
            square_namesX.Add(671);
            square_namesX.Add(671);
            square_namesX.Add(671);



            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(534);
            square_namesY.Add(484);
            square_namesY.Add(435);
            square_namesY.Add(386);
            square_namesY.Add(337);
            square_namesY.Add(288);
            square_namesY.Add(239);
            square_namesY.Add(190);
            square_namesY.Add(141);
            square_namesY.Add(92);
            square_namesY.Add(12);
            square_namesY.Add(13);
            square_namesY.Add(13);
            square_namesY.Add(13);
            square_namesY.Add(13);
            square_namesY.Add(13);
            square_namesY.Add(13);
            square_namesY.Add(13);
            square_namesY.Add(13);
            square_namesY.Add(13);
            square_namesY.Add(12);
            square_namesY.Add(92);
            square_namesY.Add(141);
            square_namesY.Add(190);
            square_namesY.Add(239);
            square_namesY.Add(288);
            square_namesY.Add(337);
            square_namesY.Add(386);
            square_namesY.Add(435);
            square_namesY.Add(484);




            Player_1_Icon.Top = square_namesY[Player1_Postion] + 5;
            Player_1_Icon.Left = square_namesX[Player1_Postion] + 30;

            Player_2_Icon.Top = square_namesY[Player2_Postion] + 30;
            Player_2_Icon.Left = square_namesX[Player2_Postion] + 30;

            Player_3_Icon.Top = square_namesY[Player3_Postion] + 5;
            Player_3_Icon.Left = square_namesX[Player3_Postion] + 5;

            Player_4_Icon.Top = square_namesY[Player4_Postion] + 30;
            Player_4_Icon.Left = square_namesX[Player4_Postion] + 5;


        }

        private void ThrowBTN_Click(object sender, EventArgs e) // dice roll button 
        {
            int dice_throw = ThrowDice();


            if (dice_throw == 1) pictureBox1.Image = Image.FromFile("d1.png");
            if (dice_throw == 2) pictureBox1.Image = Image.FromFile("d2.png");
            if (dice_throw == 3) pictureBox1.Image = Image.FromFile("d3.png");
            if (dice_throw == 4) pictureBox1.Image = Image.FromFile("d4.png");
            if (dice_throw == 5) pictureBox1.Image = Image.FromFile("d5.png");
            if (dice_throw == 6) pictureBox1.Image = Image.FromFile("d6.png");

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            button1.Visible = false;

            if (TurnCounter == 1)
            {
                Player1_Postion += dice_throw;
                // this changes player1_postion number with dice roll
                if (Player1_Postion > (square_namesX.Count - 1))
                {
                    Player1_Postion = (Player1_Postion % square_namesX.Count);

                }
                if (Player1_Postion > (square_namesY.Count - 1))
                {
                    Player1_Postion = (Player1_Postion % square_namesY.Count);

                }
                if (Player1_Postion == 30)
                {
                    int getOut = dice_throw;
                    MessageBox.Show("Player one has been jailed");

                    while (TurnCounter == 1 || getOut <= 6)
                    {

                        Player1_Postion = 12;


                    }
                    MessageBox.Show("you are free");
                    Player1_Postion = 13;
                }
                // this stop player from going out of the range 
                Player_1_Icon.Left = square_namesX[Player1_Postion] + 25;
                Player_1_Icon.Top = square_namesY[Player1_Postion] + 20;
                // this moves player1 on grid based of dice roll and +num moves player icon round main grid number 

                //payRent(ref player1Money, Player1_Postion);

            }
            if (TurnCounter == 2)
            {
                Player2_Postion += dice_throw;
                if (Player2_Postion > (square_namesX.Count - 1))
                {
                    Player2_Postion = (Player2_Postion % square_namesX.Count);

                }
                if (Player2_Postion > (square_namesY.Count - 1))
                {
                    Player2_Postion = (Player2_Postion % square_namesY.Count);

                }
                if (Player2_Postion == 1 && old_kent_player_Own == 1)
                {
                    player2Money = player2Money - Old_Kent_Road_cost;

                }

                Player_2_Icon.Left = square_namesX[Player2_Postion] + 26;
                Player_2_Icon.Top = square_namesY[Player2_Postion] + 1;

            }
            if (TurnCounter == 3)
            {
                Player3_Postion += dice_throw;
                if (Player3_Postion > (square_namesX.Count - 1))
                {
                    Player3_Postion = (Player3_Postion % square_namesX.Count);

                }
                if (Player3_Postion > (square_namesY.Count - 1))
                {
                    Player3_Postion = (Player3_Postion % square_namesY.Count);

                }


                Player_3_Icon.Left = square_namesX[Player3_Postion] + 15;
                Player_3_Icon.Top = square_namesY[Player3_Postion] + 5;

            }
            if (TurnCounter == 0)
            {
                Player4_Postion += dice_throw;
                if (Player4_Postion > (square_namesX.Count - 1))
                {
                    Player4_Postion = (Player4_Postion % square_namesX.Count);

                }
                if (Player4_Postion > (square_namesY.Count - 1))
                {
                    Player4_Postion = (Player4_Postion % square_namesY.Count);

                }
                Player_4_Icon.Left = square_namesX[Player4_Postion];
                Player_4_Icon.Top = square_namesY[Player4_Postion];




            }
        }

        private int ThrowDice() // this returns random int for dice roll 
        {
            return new Random((int)DateTime.Now.Ticks).Next(6, 7);

        }

        private void payRant(ref int money, int postion){
            //pass by refernece mean I don't have know who money or postion i am changing 
            int owner = 0;

            //do stuff to find owner

            //check if owner if 0 or Turncounter, then no rent
            //else, pay rent

            }
        private int Chance_roll() // this returns random int for
        {
            return new Random((int)DateTime.Now.Ticks).Next(1, 3);

        }
        private int Community_chest_roll()
        {

            return new Random((int)DateTime.Now.Ticks).Next(1, 3);
        }
        //private void Jailmode()
        //{
        //    int getOut = ThrowDice();
        //    if( Player1_Postion == 30){
                
                

                
        //    }
        //}

        private void button2_Click(object sender, EventArgs e) // player turn buttion               
        {
            TurnCounter++;
            // Player 1 Turn
            if (TurnCounter == 1)
            {
                Player_4.Text = "Player 4";
                Player_1.Text = "*Player 1*";

                button1.Visible = true;
                Button3.Visible = true;
            }
            // Player 2 Turn
            if (TurnCounter == 2)
            {
                Player_1.Text = "Player 1";
                Player_2.Text = "*Player 2*";
                button1.Visible = true;
                Button3.Visible = true;

            }
            // Player 3 Turn 
            if (TurnCounter == 3)
            {
                Player_2.Text = "Player 2";
                Player_3.Text = "*Player 3*";
                button1.Visible = true;
                Button3.Visible = true;

            }
            // Player 4 Turn
            if (TurnCounter == 4)
            {
                Player_3.Text = "Player 3";
                Player_4.Text = "*Player 4*";
                button1.Visible = true;
                Button3.Visible = true;
                TurnCounter = 0;

            }


        }

        private void Button3_Click(object sender, EventArgs e)
            //Buy house button


        
        {
            //player 1 
            if (Player1_Postion == 0 && TurnCounter == 1) // Go  // work this *player postion / turncounter in order to stop other players from buying at same time i think
            {
                
                
                player1Money = player1Money + Go_Money;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //MessageBox.Show("Player two turn now");
               

            }


            if (Player1_Postion == 1 && TurnCounter == 1 && old_kent_player_Own == 0) // old kent road 
            {

                
                
                player1Money = player1Money - Old_Kent_Road_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                old_kent_player_Own = 1;

                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 2 && TurnCounter == 1) // Community chest
            {


                // int Old_Kent_Road_cost = 60;
                // player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 3 && TurnCounter == 1 && white_chapel_player_Own == 0) // white chapel 
            {


                
                player1Money = player1Money - White_Chapel_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                white_chapel_player_Own = 1; 
                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 4 && TurnCounter == 1) // income tax pay
            {


                
                player1Money = player1Money - Income_Tax_Pay_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 5 && TurnCounter == 1) // king's cross
            {


                
                player1Money = player1Money - Kings_Cross_Station_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                kings_cross_station_player_Own = 1; 
                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 6 && TurnCounter == 1) // the angel islington
            {


                
                player1Money = player1Money - The_Angel_Lsington_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                the_angel_lslington_player_Own = 1;
                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 7 && TurnCounter == 1) // chance 
            {


                //int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 8 && TurnCounter == 1) // euston road
            {


                
                player1Money = player1Money - Euston_Road_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                euston_road_player_Own = 1;
                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 9 && TurnCounter == 1) // penton vile road
            {


                
                player1Money = player1Money - Penton_Vile_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                penton_vile_road_player_Own = 1;

                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 10 && TurnCounter == 1) // jail / just passing 
            {


                //int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 11 && TurnCounter == 1) // pall mall
            {


                
                player1Money = player1Money - Pall_Mall_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                pall_mall_player_Own = 1;
                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 12 && TurnCounter == 1) // electric company
            {


                
                player1Money = player1Money - Electric_Company_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                electric_company_player_Own = 1;
                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 13 && TurnCounter == 1) // whitehall 
            {


                
                player1Money = player1Money - Whitehall_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                whitehall_player_Own = 1;

                //MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 14 && TurnCounter == 1) // northunrl'd avenue
            {


                
                player1Money = player1Money - Northunrld_Avenue_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                northunrld_avenue_player_Own = 1;
                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 15 && TurnCounter == 1) // marylebone station
            {


                
                player1Money = player1Money - Marylebone_Station_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                marlborough_street_player_Own = 1;
                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 16 && TurnCounter == 1) // bow street
            {


                
                player1Money = player1Money - Bow_Street_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                bow_street_player_Own = 1; 
                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 17 && TurnCounter == 1) // community chest 2
            {


                // int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 18 && TurnCounter == 1) // marlborough street 
            {


                
                player1Money = player1Money - Marlborough_Street_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                marlborough_street_player_Own = 1; 
                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 19 && TurnCounter == 1) // vine street 
            {


                
                player1Money = player1Money - Vine_Street_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                vine_street_player_Own = 1;
                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 20 && TurnCounter == 1) // free parking
            {


                // int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 21 && TurnCounter == 1)  // Strand
            {

                
                player1Money = player1Money - Strand_Cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                strand_player_Own = 1;
                // MessageBox.Show("Player two turn now");

            }


            if (Player1_Postion == 22 && TurnCounter == 1) // chance 2 
            {


                // int Old_Kent_Road_cost = 60;
                // player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 23 && TurnCounter == 1) // fleet street
            {


                
                player1Money = player1Money - Fleet_Street_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                fleet_street_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 24 && TurnCounter == 1) // trafalgar square
            {


                
                player1Money = player1Money - Trafalgar_Square_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                trafalgar_square_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 25 && TurnCounter == 1) // fenchurch St Station 
            {


                
                player1Money = player1Money - Fenchurch_St_Station_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                fenchurch_st_station_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 26 && TurnCounter == 1) // leicester square 
            {


                
                player1Money = player1Money - Leicester_Square_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                leicester_square_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 27 && TurnCounter == 1) // coventry street 
            {


                
                player1Money = player1Money - Coventry_Street_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                coventry_street_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 28 && TurnCounter == 1) // water works
            {


                
                player1Money = player1Money - Water_Works_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                water_works_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 29 && TurnCounter == 1) // piccadilly
            {


                
                player1Money = player1Money - Piccadilly_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                piccadilly_player_Own = 1;
                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 30 && TurnCounter == 1) // go to jail
            {

               
                // int Old_Kent_Road_cost = 60;
                //  player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 31 && TurnCounter == 1) // regent street 
            {


                
                player1Money = player1Money - Regent_Street_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                regent_street_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 32 && TurnCounter == 1) // oxford street
            {


                
                player1Money = player1Money - Oxford_Street_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                oxford_street_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 33 && TurnCounter == 1) // community chest 3
            {


                //  int Old_Kent_Road_cost = 60;
                //  player1Money = player1Money - Old_Kent_Road_cost;
                //  Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //   MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 34 && TurnCounter == 1) // bond street 
            {


                
                player1Money = player1Money - Bond_Street_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                bond_street_player_Own = 1;
                // MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 35 && TurnCounter == 1) // liverpool st station
            {


                
                player1Money = player1Money - Liverpool_St_Station_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                liverpool_st_station_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 36 && TurnCounter == 1) // chance 3
            {


                //  int Old_Kent_Road_cost = 60;
                //   player1Money = player1Money - Old_Kent_Road_cost;
                //  Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 37 && TurnCounter == 1) // park lane
            {


                
                player1Money = player1Money - Park_Lane_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                park_lane_player_Own = 1;
                //  MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 38 && TurnCounter == 1) // super tax
            {


                
                player1Money = player1Money - Super_Tax_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //   MessageBox.Show("Player two turn now");


            }
            if (Player1_Postion == 39 && TurnCounter == 1) // mayfair
            {


                
                player1Money = player1Money - Mayfair_cost;
                Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                mayfair_player_Own = 1;
                //  MessageBox.Show("Player two turn now");



            }
           
            
            
            // player 2



            if (Player2_Postion == 0 && TurnCounter == 2) // Go  // work this *player postion / turncounter in order to stop other players from buying at same time i think
            {
 
                
                player2Money = player2Money + Go_Money;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //  MessageBox.Show("Player two turn now");

            }


            if (Player2_Postion == 1 && TurnCounter == 2) // old kent road 
            {


                
                player2Money = player2Money - Old_Kent_Road_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 2 && TurnCounter == 2) // Community chest
            {


                // int Old_Kent_Road_cost = 60;
                // player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 3 && TurnCounter == 2) // white chapel 
            {


                
                player2Money = player2Money - White_Chapel_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 4 && TurnCounter == 2) // income tax pay
            {


                
                player2Money = player2Money - Income_Tax_Pay_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 5 && TurnCounter == 2) // king's cross
            {


                
                player2Money = player2Money - Kings_Cross_Station_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 6 && TurnCounter == 2) // the angel islington
            {


                
                player2Money = player2Money - The_Angel_Lsington_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 7 && TurnCounter == 2) // chance 
            {


                //int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 8 && TurnCounter == 2) // euston road
            {


                
                player2Money = player2Money - Euston_Road_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 9 && TurnCounter == 2) // penton vile road
            {


                
                player2Money = player2Money - Penton_Vile_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 10 && TurnCounter == 2) // jail / just passing 
            {


                //int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player2_Postion == 11 && TurnCounter == 2) // pall mall
            {


                
                player2Money = player2Money - Pall_Mall_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 3;
                //MessageBox.Show("Player three turn now");


            }
            if (Player2_Postion == 12 && TurnCounter == 2) // electric company
            {


                
                player2Money = player2Money - Electric_Company_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 3;
                //MessageBox.Show("Player three turn now");


            }
            if (Player2_Postion == 13 && TurnCounter == 2) // whitehall 
            {


                
                player2Money = player2Money - Whitehall_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 14 && TurnCounter == 2) // northunrl'd avenue
            {


                
                player2Money = player2Money - Northunrld_Avenue_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 15 && TurnCounter == 2) // marylebone station
            {


                
                player2Money = player2Money - Marylebone_Station_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 16 && TurnCounter == 2) // bow street
            {


                
                player2Money = player2Money - Bow_Street_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 17 && TurnCounter == 2) // community chest 2
            {


                // int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

            }
            if (Player2_Postion == 18 && TurnCounter == 2) // marlborough street 
            {


               
                player2Money = player2Money - Marlborough_Street_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 19 && TurnCounter == 2) // vine street 
            {


                
                player2Money = player2Money - Vine_Street_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 20 && TurnCounter == 2) // free parking
            {


                // int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 21 && TurnCounter == 2)  // Strand
            {

                
                player2Money = player2Money - Strand_Cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

            }


            if (Player2_Postion == 22 && TurnCounter == 2) // chance 2 
            {


                // int Old_Kent_Road_cost = 60;
                // player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 23 && TurnCounter == 2) // fleet street
            {

                
                player2Money = player2Money - Fleet_Street_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player2_Postion == 24 && TurnCounter == 2) // trafalgar square
            {


               
                player2Money = player2Money - Trafalgar_Square_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player2_Postion == 25 && TurnCounter == 2) // fenchurch St Station 
            {


               
                player2Money = player2Money - Fenchurch_St_Station_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player2_Postion == 26 && TurnCounter == 2) // leicester square 
            {


                
                player2Money = player2Money - Leicester_Square_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player2_Postion == 27 && TurnCounter == 2) // coventry street 
            {


            
                player2Money = player2Money - Coventry_Street_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player2_Postion == 28 && TurnCounter == 2) // water works
            {


               
                player2Money = player2Money - Water_Works_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 29 && TurnCounter == 2) // piccadilly
            {


                
                player2Money = player2Money - Piccadilly_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player2_Postion == 30 && TurnCounter == 2) // go to jail
            {


                // int Old_Kent_Road_cost = 60;
                //  player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player2_Postion == 31 && TurnCounter == 2) // regent street 
            {


                
                player2Money = player2Money - Regent_Street_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player2_Postion == 32 && TurnCounter == 2) // oxford street
            {


            
                player2Money = player2Money - Oxford_Street_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 33 && TurnCounter == 2) // community chest 3
            {


                //  int Old_Kent_Road_cost = 60;
                //  player1Money = player1Money - Old_Kent_Road_cost;
                //  Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 34 && TurnCounter == 2) // bond street 
            {


                
                player2Money = player2Money - Bond_Street_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 35 && TurnCounter == 2) // liverpool st station
            {


                
                player2Money = player2Money - Liverpool_St_Station_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 36 && TurnCounter == 2) // chance 3
            {


                //  int Old_Kent_Road_cost = 60;
                //   player1Money = player1Money - Old_Kent_Road_cost;
                //  Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 37 && TurnCounter == 2) // park lane
            {


                
                player2Money = player2Money - Park_Lane_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 38 && TurnCounter == 2) // super tax
            {


               
                player2Money = player2Money - Super_Tax_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player2_Postion == 39 && TurnCounter == 2) // mayfair
            {


               
                player2Money = player2Money - Mayfair_cost;
                Player_2_Money.Text = player2Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }

            // player 3
            if (Player3_Postion == 0 && TurnCounter == 3) // Go  // work this *player postion / turncounter in order to stop other players from buying at same time i think
            {

              
                player3Money = player3Money + Go_Money;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //  MessageBox.Show("Player two turn now");

            }


            if (Player3_Postion == 1 && TurnCounter == 3) // old kent road 
            {


                
                player3Money = player3Money - Old_Kent_Road_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 2 && TurnCounter == 3) // Community chest
            {


                // int Old_Kent_Road_cost = 60;
                // player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 3 && TurnCounter == 3) // white chapel 
            {


              
                player3Money = player3Money - White_Chapel_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 4 && TurnCounter == 3) // income tax pay
            {


            
                player3Money = player3Money - Income_Tax_Pay_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 5 && TurnCounter == 3) // king's cross
            {


               
                player3Money = player3Money - Kings_Cross_Station_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 6 && TurnCounter == 3) // the angel islington
            {


               
                player3Money = player3Money - The_Angel_Lsington_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 7 && TurnCounter == 3) // chance 
            {


                //int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 8 && TurnCounter == 3) // euston road
            {


              
                player3Money = player3Money - Euston_Road_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 9 && TurnCounter == 3) // penton vile road
            {


             
                player3Money = player3Money - Penton_Vile_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 10 && TurnCounter == 3) // jail / just passing 
            {


                //int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player3_Postion == 11 && TurnCounter == 3) // pall mall
            {


              
                player3Money = player3Money - Pall_Mall_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 3;
                //MessageBox.Show("Player three turn now");


            }
            if (Player3_Postion == 12 && TurnCounter == 3) // electric company
            {


              
                player3Money = player3Money - Electric_Company_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 3;
                //MessageBox.Show("Player three turn now");


            }
            if (Player3_Postion == 13 && TurnCounter == 3) // whitehall 
            {


             
                player3Money = player3Money - Whitehall_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 14 && TurnCounter == 3) // northunrl'd avenue
            {


             
                player3Money = player3Money - Northunrld_Avenue_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 15 && TurnCounter == 3) // marylebone station
            {


            
                player3Money = player3Money - Marylebone_Station_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 16 && TurnCounter == 3) // bow street
            {


              
                player3Money = player3Money - Bow_Street_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 17 && TurnCounter == 3) // community chest 2
            {


                // int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

            }
            if (Player3_Postion == 18 && TurnCounter == 3) // marlborough street 
            {


                player3Money = player3Money - Marlborough_Street_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 19 && TurnCounter == 3) // vine street 
            {


              
                player3Money = player3Money - Vine_Street_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 20 && TurnCounter == 3) // free parking
            {


                // int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 21 && TurnCounter == 3)  // Strand
            {

           
                player3Money = player3Money - Strand_Cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

            }


            if (Player3_Postion == 22 && TurnCounter == 3) // chance 2 
            {


                // int Old_Kent_Road_cost = 60;
                // player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 23 && TurnCounter == 3) // fleet street
            {


        
                player3Money = player3Money - Fleet_Street_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player3_Postion == 24 && TurnCounter == 3) // trafalgar square
            {


        
                player3Money = player3Money - Trafalgar_Square_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player3_Postion == 25 && TurnCounter == 3) // fenchurch St Station 
            {


               
                player3Money = player3Money - Fenchurch_St_Station_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player3_Postion == 26 && TurnCounter == 3) // leicester square 
            {


            
                player3Money = player3Money - Leicester_Square_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player3_Postion == 27 && TurnCounter == 3) // coventry street 
            {


             
                player3Money = player3Money - Coventry_Street_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player3_Postion == 28 && TurnCounter == 3) // water works
            {


   
                player3Money = player3Money - Water_Works_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 29 && TurnCounter == 3) // piccadilly
            {


        
                player3Money = player3Money - Piccadilly_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player3_Postion == 30 && TurnCounter == 3) // go to jail
            {


                // int Old_Kent_Road_cost = 60;
                //  player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player3_Postion == 31 && TurnCounter == 3) // regent street 
            {


        
                player3Money = player3Money - Regent_Street_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player3_Postion == 32 && TurnCounter == 3) // oxford street
            {


       
                player3Money = player3Money - Oxford_Street_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 33 && TurnCounter == 3) // community chest 3
            {


                //  int Old_Kent_Road_cost = 60;
                //  player1Money = player1Money - Old_Kent_Road_cost;
                //  Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 34 && TurnCounter == 3) // bond street 
            {


         
                player3Money = player3Money - Bond_Street_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 35 && TurnCounter == 3) // liverpool st station
            {


      
                player3Money = player3Money - Liverpool_St_Station_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 36 && TurnCounter == 3) // chance 3
            {


                //  int Old_Kent_Road_cost = 60;
                //   player1Money = player1Money - Old_Kent_Road_cost;
                //  Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 37 && TurnCounter == 3) // park lane
            {


       
                player3Money = player3Money - Park_Lane_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 38 && TurnCounter == 3) // super tax
            {


        
                player3Money = player3Money - Super_Tax_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player3_Postion == 39 && TurnCounter == 3) // mayfair
            {


   
                player3Money = player3Money - Mayfair_cost;
                Player_3_Money.Text = player3Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            // Player 4
            if (Player4_Postion == 0 && TurnCounter == 0) // Go  // work this *player postion / turncounter in order to stop other players from buying at same time i think
            {

          
                player4Money = player4Money + Go_Money;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //  MessageBox.Show("Player two turn now");

            }


            if (Player4_Postion == 1 && TurnCounter == 0) // old kent road 
            {


      
                player4Money = player4Money - Old_Kent_Road_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 2 && TurnCounter == 0) // Community chest
            {


                // int Old_Kent_Road_cost = 60;
                // player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 3 && TurnCounter == 0) // white chapel 
            {


 
                player4Money = player4Money - White_Chapel_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 4 && TurnCounter == 0) // income tax pay
            {


     
                player4Money = player4Money - Income_Tax_Pay_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 5 && TurnCounter == 0) // king's cross
            {


         
                player4Money = player4Money - Kings_Cross_Station_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 6 && TurnCounter == 0) // the angel islington
            {


        
                player4Money = player4Money - The_Angel_Lsington_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 7 && TurnCounter == 0) // chance 
            {


                //int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 8 && TurnCounter == 0) // euston road
            {


         
                player4Money = player4Money - Euston_Road_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 9 && TurnCounter == 0) // penton vile road
            {


      
                player4Money = player4Money - Penton_Vile_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 10 && TurnCounter == 0) // jail / just passing 
            {


                //int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 2;
                //MessageBox.Show("Player two turn now");


            }
            if (Player4_Postion == 11 && TurnCounter == 0) // pall mall
            {


     
                player4Money = player4Money - Pall_Mall_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 3;
                //MessageBox.Show("Player three turn now");


            }
            if (Player4_Postion == 12 && TurnCounter == 0) // electric company
            {


  
                player4Money = player4Money - Electric_Company_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;
                //TurnCounter = 3;
                //MessageBox.Show("Player three turn now");


            }
            if (Player4_Postion == 13 && TurnCounter == 0) // whitehall 
            {


          
                player4Money = player4Money - Whitehall_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 14 && TurnCounter == 0) // northunrl'd avenue
            {


          
                player4Money = player4Money - Northunrld_Avenue_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 15 && TurnCounter == 0) // marylebone station
            {


           
                player4Money = player4Money - Marylebone_Station_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 16 && TurnCounter == 0) // bow street
            {


                int Bow_Street_cost = 180;
                player4Money = player4Money - Bow_Street_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 17 && TurnCounter == 0) // community chest 2
            {


                // int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

            }
            if (Player4_Postion == 18 && TurnCounter == 0) // marlborough street 
            {


          
                player4Money = player4Money - Marlborough_Street_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 19 && TurnCounter == 0) // vine street 
            {


          
                player4Money = player4Money - Vine_Street_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 20 && TurnCounter == 0) // free parking
            {


                // int Old_Kent_Road_cost = 60;
                //player1Money = player1Money - Old_Kent_Road_cost;
                //Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 21 && TurnCounter == 0)  // Strand
            {

          
                player4Money = player4Money - Strand_Cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;

            }


            if (Player4_Postion == 22 && TurnCounter == 0) // chance 2 
            {


                // int Old_Kent_Road_cost = 60;
                // player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 23 && TurnCounter == 0) // fleet street
            {


      
                player4Money = player4Money - Fleet_Street_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player4_Postion == 24 && TurnCounter == 0) // trafalgar square
            {


      
                player4Money = player4Money - Trafalgar_Square_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player4_Postion == 25 && TurnCounter == 0) // fenchurch St Station 
            {


          
                player4Money = player4Money - Fenchurch_St_Station_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player4_Postion == 26 && TurnCounter == 0) // leicester square 
            {


            
                player4Money = player4Money - Leicester_Square_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player4_Postion == 27 && TurnCounter == 0) // coventry street 
            {


   
                player4Money = player4Money - Coventry_Street_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player4_Postion == 28 && TurnCounter == 0) // water works
            {


   
                player4Money = player4Money - Water_Works_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 29 && TurnCounter == 0) // piccadilly
            {


           
                player4Money = player4Money - Piccadilly_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player4_Postion == 30 && TurnCounter == 0) // go to jail
            {


                // int Old_Kent_Road_cost = 60;
                //  player1Money = player1Money - Old_Kent_Road_cost;
                // Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player4_Postion == 31 && TurnCounter == 0) // regent street 
            {


          
                player4Money = player4Money - Regent_Street_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;



            }
            if (Player4_Postion == 32 && TurnCounter == 0) // oxford street
            {


          
                player4Money = player4Money - Oxford_Street_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 33 && TurnCounter == 0) // community chest 3
            {


                //  int Old_Kent_Road_cost = 60;
                //  player1Money = player1Money - Old_Kent_Road_cost;
                //  Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 34 && TurnCounter == 0) // bond street 
            {


            
                player4Money = player4Money - Bond_Street_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 35 && TurnCounter == 0) // liverpool st station
            {


  
                player4Money = player4Money - Liverpool_St_Station_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 36 && TurnCounter == 0) // chance 3
            {


                //  int Old_Kent_Road_cost = 60;
                //   player1Money = player1Money - Old_Kent_Road_cost;
                //  Player_1_Money.Text = player1Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 37 && TurnCounter == 0) // park lane
            {


           
                player4Money = player4Money - Park_Lane_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 38 && TurnCounter == 0) // super tax
            {


            
                player4Money = player4Money - Super_Tax_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }
            if (Player4_Postion == 39 && TurnCounter == 0) // mayfair
            {


          
                player4Money = player4Money - Mayfair_cost;
                Player_4_Money.Text = player4Money.ToString();
                button1.Visible = false;
                Button3.Visible = false;


            }

        }
    }
}

