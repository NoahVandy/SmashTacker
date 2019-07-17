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
    public partial class NewChallenger : Form
    {

        public ChallengerList challengerList = new ChallengerList();

        public NewChallenger()
        {
            InitializeComponent();

            String[] ChallengerArray = { "No Prefference", "Bayonetta", "Bowser", "Captain Falcon", "Chrom", "Cloud", "Corrin", "Daisy", "Dark Pit",
            "Dark Samus", "Diddy Kong", "Dr.Mario", "Duck Hunt", "Falco", "Fox", "Ganondorf", "Greninja", "Ice Climbers", "Ike", "Incineroar",
            "Inkling", "Isabelle", "Jigglypuff", "Joker", "Ken", "King Dedede", "King K.Rool", "Kirby", "Link", "Little Mac", "Lucario",
            "Lucas", "Lucina", "Luigi", "Mario", "Marth", "Mega Man", "Meta Knight", "Mewtwo", "Mii Brawler", "Mii Swordfighter", "Mii Gunner",
            "Mr.Game & Watch", "Ness", "Olimar", "Pac-Man", "Palutena", "Peach", "Pichu", "Pikachu", "Piranha Plant", "Pit", "Richter", "Ridley",
            "R.O.B.", "Robin", "Pokemon Trainer", "Rosalina", "Roy", "Ryu", "Samus", "Sheik", "Shulk", "Simon", "Snake", "Sonic", "Toon Link", "Villager",
            "Wario", "Wii Fit Trainer", "Wolf", "Yoshi", "Young Link", "Zelda", "Zero Suit Samus"};

            cmbx_main.DataSource = ChallengerArray;


        }

        private void Txtbx_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string name = txtbx_name.Text;
            string main = cmbx_main.Text;
            int BP = 0;
            double KDA = 0.0;

            Challenger challenger = new Challenger(name, main, BP, KDA);
            //adding it to the List
            bool result = challengerList.Add(challenger);



            if (result == true)
            {
                MessageBox.Show("Added successfully");



            }
            else
            {
                MessageBox.Show("Error adding");
            }


            this.Close();
        }
    }
}
