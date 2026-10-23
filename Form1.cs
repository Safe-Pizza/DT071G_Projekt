/**
 * Filnamn: Form1.cs
 * Författare: Hanna Lindkvist
 * Datum: 2026-10-23
 * Kurs: DT071G
 * 
 * Beskrivning: Spelets startsida med beskrvning och startknapp för att starta spelet
 * 
 * **/

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

        //Klick-event för spelets startknapp
        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game(); //Starta nytt spel

            this.Hide();

            //Öppna spelets sida för att välja spelar monster
            MonsterSelectionForm monsterSelectionForm = new MonsterSelectionForm(game);

            monsterSelectionForm.StartPosition = FormStartPosition.CenterScreen;

            monsterSelectionForm.ShowDialog();

            this.Show();
        }
    }
}
