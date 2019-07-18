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

        public static System.IO.StreamReader sr;
        public static System.IO.StreamWriter sw;
        public ChallengerList challengerList = new ChallengerList();

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
            sr = new System.IO.StreamReader("SmashTracker.txt");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] fileLine = line.Split(',');

                Challenger fileItem = new Challenger(fileLine[0], fileLine[1], int.Parse(fileLine[2]), double.Parse(fileLine[3]));

                challengerList.Add(fileItem);
            }
            sr.Close();

            List<Challenger> rankingsList = challengerList.getItemList();

            Rankings rankings = new Rankings(rankingsList);

            rankings.ShowDialog();
        }
    }
}
