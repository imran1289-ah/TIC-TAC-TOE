using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool O_Turn = false;
        int scoreForX;
        int scoreForO;
       
        public Form1()
        {
            InitializeComponent();
        }

        //Start Game Method, Every button is set for a new game
        public void Start_Game()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

        }


        //Close all button so no one could use
        public void End_Game()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        //Winning combinations 
        public void score()
        {

            //All winning combinations for Player X
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {


                MessageBox.Show("Player X has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForX = int.Parse(label4.Text) + 1;
                label4.Text = Convert.ToString(scoreForX);
                End_Game();
                

            }

            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {


                MessageBox.Show("Player X has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForX = int.Parse(label4.Text) + 1;
                label4.Text = Convert.ToString(scoreForX);
               
                End_Game();
                

            }

            if (button1.Text == "X" && button4.Text == "X" && button8.Text == "X")
            {


                MessageBox.Show("Player X has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForX = int.Parse(label4.Text) + 1;
                label4.Text = Convert.ToString(scoreForX);
                
                End_Game();

            }

            if (button3.Text == "X" && button6.Text == "X" && button8.Text == "X")
            {


                MessageBox.Show("Player X has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForX = int.Parse(label4.Text) + 1;
                label4.Text = Convert.ToString(scoreForX);
               
                End_Game();

            }

            if (button7.Text == "X" && button9.Text == "X" && button8.Text == "X")
            {


                MessageBox.Show("Player X has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForX = int.Parse(label4.Text) + 1;
                label4.Text = Convert.ToString(scoreForX);
               
                End_Game();

            }

            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {


                MessageBox.Show("Player X has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForX = int.Parse(label4.Text) + 1;
                label4.Text = Convert.ToString(scoreForX);
                
                End_Game();

            }

            if (button2.Text == "X" && button4.Text == "X" && button9.Text == "X")
            {


                MessageBox.Show("Player X has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForX = int.Parse(label4.Text) + 1;
                label4.Text = Convert.ToString(scoreForX);
                
                End_Game();

            }

            if (button5.Text == "X" && button4.Text == "X" && button6.Text == "X")
            {


                MessageBox.Show("Player X has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForX = int.Parse(label4.Text) + 1;
                label4.Text = Convert.ToString(scoreForX);
               
                End_Game();

            }

            //All winning combinations for Player O
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {


                MessageBox.Show("Player O has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForO = int.Parse(label5.Text) + 1;
                label5.Text = Convert.ToString(scoreForO);
                
                End_Game();

            }

            if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {


                MessageBox.Show("Player O has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForO = int.Parse(label5.Text) + 1;
                label5.Text = Convert.ToString(scoreForO);
                
                End_Game();

            }

            if (button1.Text == "O" && button4.Text == "O" && button8.Text == "O")
            {


                MessageBox.Show("Player O has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForO = int.Parse(label5.Text) + 1;
                label5.Text = Convert.ToString(scoreForO);
                
                End_Game();

            }

            if (button3.Text == "O" && button6.Text == "O" && button8.Text == "O")
            {


                MessageBox.Show("Player O has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForO = int.Parse(label5.Text) + 1;
                label5.Text = Convert.ToString(scoreForO);
                
                End_Game();

            }

            if (button7.Text == "O" && button9.Text == "O" && button8.Text == "O")
            {


                MessageBox.Show("Player O has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForO = int.Parse(label5.Text) + 1;
                label5.Text = Convert.ToString(scoreForO);
                
                End_Game();

            }

            if (button3.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {


                MessageBox.Show("Player O has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForO = int.Parse(label5.Text) + 1;
                label5.Text = Convert.ToString(scoreForO);
                
                End_Game();

            }

            if (button2.Text == "O" && button4.Text == "O" && button9.Text == "O")
            {


                MessageBox.Show("Player O has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForO = int.Parse(label5.Text) + 1;
                label5.Text = Convert.ToString(scoreForO);
                
                End_Game();

            }

            if (button5.Text == "O" && button4.Text == "O" && button6.Text == "O")
            {


                MessageBox.Show("Player O has won this match!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreForO = int.Parse(label5.Text) + 1;
                label5.Text = Convert.ToString(scoreForO);
                
                End_Game();

            }


        }

        //Click Functionality of button3
        private void button3_Click(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button3.BackColor = Color.Red;
                button3.Text = "X";
                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;

            }
            else
            {
                button3.BackColor = Color.Blue;
                button3.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
                
            }
            
            button3.Enabled = false;
            score();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Click Functionality of Button1
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button1.BackColor = Color.Red;
                button1.Text = "X";
                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Blue;
                button1.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
            }
            
            button1.Enabled = false;
            
            
            score();
            
        }

        //Click Functionality of button2
        private void button2_Click(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button2.BackColor = Color.Red;
                button2.Text = "X";
                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                button2.BackColor = Color.Blue;
                button2.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
            }
            
            button2.Enabled = false;
            
            
            score();
            
        }

        //Click functionality of button5
        private void button5_Click(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button5.BackColor = Color.Red;
                button5.Text = "X";
                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                button5.BackColor = Color.Blue;
                button5.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
            }
            
            button5.Enabled = false;
            
            
            score();
           
        }

        //Click functionality button4
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button4.BackColor = Color.Red;
                button4.Text = "X";
                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                button4.BackColor = Color.Blue;
                button4.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
            }
            
            button4.Enabled = false;
            
            
            score();
            
        }


        //Click functionality button6
        private void button6_Click(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button6.BackColor = Color.Red;
                button6.Text = "X";
                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                button6.BackColor = Color.Blue;
                button6.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
            }
             
            button6.Enabled = false;
            
            
            score();
            
        }

        //Click functionality button7
        private void button7_Click(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button7.BackColor = Color.Red;
                button7.Text = "X";
                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                button7.BackColor = Color.Blue;
                button7.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
            }
               
            button7.Enabled = false;
            
            
            score();
            
        }


        //Click functionality of button9
        private void button9_Click(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button9.BackColor = Color.Red;
                button9.Text = "X";



                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                button9.BackColor = Color.Blue;
                button9.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
            }
            
            button9.Enabled = false;
            
            
            score();
            
        }


        //Click functionality of button8
        private void button8_Click(object sender, EventArgs e)
        {
            if (O_Turn == false)
            {
                button8.BackColor = Color.Red;
                button8.Text = "X";

                O_Turn = true;
                label7.Text = "O turn";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                button8.BackColor = Color.Blue;
                button8.Text = "O";
                O_Turn = false;
                label7.Text = "X turn";
                label7.ForeColor = Color.Red;
            }
            
            button8.Enabled = false;
            
            
            score();
           
        }

        //Click functionality of button11
        private void button11_Click(object sender, EventArgs e) 
        {
            DialogResult NewGame = MessageBox.Show("Are you sure you want to start a New game?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (NewGame == DialogResult.Yes)
            {
                try
                {
                    label4.Text = "0";
                    label5.Text = "0";
                    scoreForX = 0;
                    scoreForO = 0;

                    Start_Game();
                    O_Turn = false;
                    label7.Text = "X turn";
                    label7.ForeColor = Color.Red;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        //Click functionality of Reset button
        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult Reset = MessageBox.Show("Are you sure you want to Reset the game?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Reset == DialogResult.Yes)
            {

                try
                {
                    Start_Game();                  
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
            
        }

        //Click functionality of leave button
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Exit = MessageBox.Show("Are you sure you want to exit?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Exit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Back Button to return to menu
        private void button13_Click(object sender, EventArgs e)
        {
            TicTacToe_Menu Menu = new TicTacToe_Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
