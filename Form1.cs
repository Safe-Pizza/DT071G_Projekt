using CuteMonsterQuest.GameLogic;

namespace CuteMonsterQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();

            this.Hide();

            MonsterSelectionForm monsterSelectionForm = new MonsterSelectionForm(game);

            monsterSelectionForm.StartPosition = FormStartPosition.CenterScreen;

            monsterSelectionForm.ShowDialog();

            this.Show();
        }
    }
}
