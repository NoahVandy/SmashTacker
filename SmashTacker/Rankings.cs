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
    public partial class Rankings : Form
    {

        public static System.IO.StreamReader sr;
        public static System.IO.StreamWriter sw;

        public Rankings(List<Challenger> rankingsList)
        {
            InitializeComponent();

            dgv_rankings.DataSource = rankingsList;
            
        }


    }
}
