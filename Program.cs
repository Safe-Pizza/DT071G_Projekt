/**
 * Filnamn: Program.cs
 * Författare: Hanna Lindkvist
 * Datum: 2026-10-23
 * Kurs: DT071G
 * 
 * Beskrivning: Turbaserat monster spel utvecklat i C#.NET med Windows Forms. Spelaren väljer ett monster och möter datastyrd motståndare.
 * Spelet är utvecklat som slutprojekt i kursen DT071G uppbygt med objektorienterad programmering, klasser och interface.
 * 
 * **/

namespace CuteMonsterQuest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Start applikation with Form1
            Application.Run(new Form1());
        }
    }
}