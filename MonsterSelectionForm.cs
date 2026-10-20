using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuteMonsterQuest
{
    public partial class MonsterSelectionForm : Form
    {

        private List<Monster> startingMonsters = [];

        private Monster? selectedMonster = null;

        public MonsterSelectionForm()
        {
            InitializeComponent();
            createMonster();
            showMonsters();
        }

        private void createMonster()
        {
            startingMonsters.Add(new Monster("Beige", Properties.Resources.beigeMonster, 120, 20, 40));
        }

        private void showMonsters()
        {
            pictureBox1.Image = startingMonsters[0].MonsterImage;
        }

        private void MonsterSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            using GameWindow gameWindow = new GameWindow();

            gameWindow.ShowDialog();

            this.Close();
        }
    }
}
