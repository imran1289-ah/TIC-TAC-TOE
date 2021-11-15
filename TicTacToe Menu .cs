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
    public partial class TicTacToe_Menu : Form
    {
        public TicTacToe_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //StartGame button
        private void StartGame(object sender, EventArgs e)
        {
            Form1 gameScreen = new Form1();
            gameScreen.Show();
            this.Hide();
            
        }

        //Leave Button
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Rules button
        private void button10_Click(object sender, EventArgs e)
        {
            RulesPage RulePage = new RulesPage();
            RulePage.Show();
            this.Hide();
        }
    }
}
