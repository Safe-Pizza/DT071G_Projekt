namespace CuteMonsterQuest
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundGame1500;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1476, 936);
            Name = "GameWindow";
            Text = "GameWindow - Cute Monster Quest";
            Load += GameWindow_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}