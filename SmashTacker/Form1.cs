using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashTacker
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void Btn_battle_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Btn_newChallenger_Click(object sender, EventArgs e)
        {
            NewChallenger newChallenger = new NewChallenger();
            newChallenger.ShowDialog();
        }

        private void Btn_rankings_Click(object sender, EventArgs e)
        {

        }
    }
}
