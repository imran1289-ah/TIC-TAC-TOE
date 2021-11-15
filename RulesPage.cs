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
    public partial class RulesPage : Form
    {
        public RulesPage()
        {
            InitializeComponent();
        }


        //Back Button
        private void button10_Click(object sender, EventArgs e)
        {
            TicTacToe_Menu gameMenu = new TicTacToe_Menu();
            gameMenu.Show();
            this.Hide();
        }
    }
}
