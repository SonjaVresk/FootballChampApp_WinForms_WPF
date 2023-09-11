namespace Nogomet03.Forms
{
    partial class TeamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamsForm));
            pnlHeader2 = new Panel();
            btnMenuRanking = new Button();
            btnMenuPlayers = new Button();
            btnMenuTeams = new Button();
            btnSettings = new Button();
            pnlMenuPlayersGames = new Panel();
            btnMenuRankingPlayers = new Button();
            btnMenuRankingGames = new Button();
            flpPlayers = new FlowLayoutPanel();
            label2 = new Label();
            pnlHeader2.SuspendLayout();
            pnlMenuPlayersGames.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader2
            // 
            pnlHeader2.BackColor = Color.Black;
            pnlHeader2.Controls.Add(btnMenuRanking);
            pnlHeader2.Controls.Add(btnMenuPlayers);
            pnlHeader2.Controls.Add(btnMenuTeams);
            pnlHeader2.Controls.Add(btnSettings);
            resources.ApplyResources(pnlHeader2, "pnlHeader2");
            pnlHeader2.Name = "pnlHeader2";
            // 
            // btnMenuRanking
            // 
            btnMenuRanking.BackColor = Color.Black;
            btnMenuRanking.Cursor = Cursors.Hand;
            btnMenuRanking.FlatAppearance.BorderSize = 0;
            btnMenuRanking.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(btnMenuRanking, "btnMenuRanking");
            btnMenuRanking.ForeColor = Color.GreenYellow;
            btnMenuRanking.Name = "btnMenuRanking";
            btnMenuRanking.UseVisualStyleBackColor = false;
            btnMenuRanking.MouseHover += BtnMenuRanking_MouseHover;
            // 
            // btnMenuPlayers
            // 
            btnMenuPlayers.BackColor = Color.Black;
            btnMenuPlayers.Cursor = Cursors.Hand;
            btnMenuPlayers.FlatAppearance.BorderSize = 0;
            btnMenuPlayers.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(btnMenuPlayers, "btnMenuPlayers");
            btnMenuPlayers.ForeColor = Color.GreenYellow;
            btnMenuPlayers.Name = "btnMenuPlayers";
            btnMenuPlayers.UseVisualStyleBackColor = false;
            // 
            // btnMenuTeams
            // 
            btnMenuTeams.BackColor = Color.Black;
            btnMenuTeams.Cursor = Cursors.Hand;
            btnMenuTeams.FlatAppearance.BorderSize = 0;
            btnMenuTeams.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(btnMenuTeams, "btnMenuTeams");
            btnMenuTeams.ForeColor = Color.GreenYellow;
            btnMenuTeams.Name = "btnMenuTeams";
            btnMenuTeams.UseVisualStyleBackColor = false;
            btnMenuTeams.Click += BtnMenuTeams_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 5, 5);
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.ForeColor = Color.GreenYellow;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += BtnSettings_Click;
            // 
            // pnlMenuPlayersGames
            // 
            pnlMenuPlayersGames.BackColor = Color.Black;
            pnlMenuPlayersGames.Controls.Add(btnMenuRankingPlayers);
            pnlMenuPlayersGames.Controls.Add(btnMenuRankingGames);
            resources.ApplyResources(pnlMenuPlayersGames, "pnlMenuPlayersGames");
            pnlMenuPlayersGames.Name = "pnlMenuPlayersGames";
            pnlMenuPlayersGames.MouseLeave += PnlMenuPlayersGames_MouseLeave;
            // 
            // btnMenuRankingPlayers
            // 
            btnMenuRankingPlayers.BackColor = Color.Green;
            btnMenuRankingPlayers.Cursor = Cursors.Hand;
            btnMenuRankingPlayers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnMenuRankingPlayers, "btnMenuRankingPlayers");
            btnMenuRankingPlayers.ForeColor = Color.GreenYellow;
            btnMenuRankingPlayers.Name = "btnMenuRankingPlayers";
            btnMenuRankingPlayers.UseVisualStyleBackColor = false;
            btnMenuRankingPlayers.Click += BtnMenuRankingPlayers_Click;
            btnMenuRankingPlayers.MouseLeave += PnlMenuPlayersGames_MouseLeave;
            // 
            // btnMenuRankingGames
            // 
            btnMenuRankingGames.BackColor = Color.Green;
            btnMenuRankingGames.Cursor = Cursors.Hand;
            btnMenuRankingGames.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnMenuRankingGames, "btnMenuRankingGames");
            btnMenuRankingGames.ForeColor = Color.GreenYellow;
            btnMenuRankingGames.Name = "btnMenuRankingGames";
            btnMenuRankingGames.UseVisualStyleBackColor = false;
            btnMenuRankingGames.Click += BtnMenuRankingGames_Click;
            btnMenuRankingGames.MouseLeave += PnlMenuPlayersGames_MouseLeave;
            // 
            // flpPlayers
            // 
            resources.ApplyResources(flpPlayers, "flpPlayers");
            flpPlayers.BackColor = Color.FromArgb(90, 151, 30);
            flpPlayers.Name = "flpPlayers";
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.YellowGreen;
            label2.Name = "label2";
            // 
            // TeamsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nogomet4;
            Controls.Add(pnlHeader2);
            Controls.Add(label2);
            Controls.Add(pnlMenuPlayersGames);
            Controls.Add(flpPlayers);
            Name = "TeamsForm";
            pnlHeader2.ResumeLayout(false);
            pnlMenuPlayersGames.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader2;
        private Button btnMenuTeams;
        private Button btnSettings;
        private Button btnMenuRanking;
        private Button btnMenuPlayers;
        private Panel pnlMenuPlayersGames;
        private Button btnMenuRankingPlayers;
        private Button btnMenuRankingGames;
        private FlowLayoutPanel flpPlayers;
        private Label label2;
    }
}