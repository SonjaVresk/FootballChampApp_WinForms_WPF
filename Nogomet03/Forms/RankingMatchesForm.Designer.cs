namespace Nogomet03.Forms
{
    partial class RankingMatchesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingMatchesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader2 = new Panel();
            btnSettings3 = new Button();
            btnMenuRanking = new Button();
            btnMenuPlayers = new Button();
            btnMenuTeams = new Button();
            btnMenuRankingPlayers = new Button();
            btnMenuRankingGames = new Button();
            pnlMenuPlayersGames = new Panel();
            dgviewMatches = new DataGridView();
            lblMatches = new Label();
            btnPrintMatches = new Button();
            lblLoading = new Label();
            pnlHeader2.SuspendLayout();
            pnlMenuPlayersGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgviewMatches).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader2
            // 
            pnlHeader2.BackColor = Color.Black;
            pnlHeader2.Controls.Add(btnSettings3);
            pnlHeader2.Controls.Add(btnMenuRanking);
            pnlHeader2.Controls.Add(btnMenuPlayers);
            pnlHeader2.Controls.Add(btnMenuTeams);
            resources.ApplyResources(pnlHeader2, "pnlHeader2");
            pnlHeader2.Name = "pnlHeader2";
            // 
            // btnSettings3
            // 
            btnSettings3.BackColor = Color.Transparent;
            btnSettings3.Cursor = Cursors.Hand;
            btnSettings3.FlatAppearance.BorderSize = 0;
            btnSettings3.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 5, 5);
            resources.ApplyResources(btnSettings3, "btnSettings3");
            btnSettings3.ForeColor = Color.GreenYellow;
            btnSettings3.Image = Properties.Resources.settings;
            btnSettings3.Name = "btnSettings3";
            btnSettings3.UseVisualStyleBackColor = false;
            btnSettings3.Click += BtnSettings3_Click;
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
            btnMenuPlayers.Click += BtnMenuPlayers_Click;
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
            // 
            // pnlMenuPlayersGames
            // 
            pnlMenuPlayersGames.BackColor = Color.Black;
            pnlMenuPlayersGames.Controls.Add(btnMenuRankingGames);
            pnlMenuPlayersGames.Controls.Add(btnMenuRankingPlayers);
            resources.ApplyResources(pnlMenuPlayersGames, "pnlMenuPlayersGames");
            pnlMenuPlayersGames.Name = "pnlMenuPlayersGames";
            pnlMenuPlayersGames.MouseLeave += PnlMenuPlayersGames_MouseLeave;
            // 
            // dgviewMatches
            // 
            dataGridViewCellStyle1.BackColor = Color.YellowGreen;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgviewMatches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgviewMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgviewMatches.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(90, 151, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgviewMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(dgviewMatches, "dgviewMatches");
            dgviewMatches.Name = "dgviewMatches";
            dgviewMatches.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgviewMatches.RowHeadersVisible = false;
            dgviewMatches.RowTemplate.Height = 25;
            // 
            // lblMatches
            // 
            lblMatches.BackColor = Color.Chartreuse;
            resources.ApplyResources(lblMatches, "lblMatches");
            lblMatches.Name = "lblMatches";
            // 
            // btnPrintMatches
            // 
            btnPrintMatches.BackColor = Color.GreenYellow;
            resources.ApplyResources(btnPrintMatches, "btnPrintMatches");
            btnPrintMatches.Cursor = Cursors.Hand;
            btnPrintMatches.FlatAppearance.BorderSize = 0;
            btnPrintMatches.ForeColor = Color.Black;
            btnPrintMatches.Image = Properties.Resources.printer__2_;
            btnPrintMatches.Name = "btnPrintMatches";
            btnPrintMatches.UseVisualStyleBackColor = false;
            btnPrintMatches.Click += BtnPrintMatches_Click;
            // 
            // lblLoading
            // 
            lblLoading.BackColor = Color.YellowGreen;
            resources.ApplyResources(lblLoading, "lblLoading");
            lblLoading.Name = "lblLoading";
            // 
            // RankingMatchesForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.nogomet4;
            Controls.Add(lblLoading);
            Controls.Add(btnPrintMatches);
            Controls.Add(pnlMenuPlayersGames);
            Controls.Add(lblMatches);
            Controls.Add(dgviewMatches);
            Controls.Add(pnlHeader2);
            Name = "RankingMatchesForm";
            pnlHeader2.ResumeLayout(false);
            pnlMenuPlayersGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgviewMatches).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader2;
        private Button btnSettings3;
        private Button btnMenuRanking;
        private Button btnMenuPlayers;
        private Button btnMenuTeams;
        private Button btnMenuRankingPlayers;
        private Button btnMenuRankingGames;
        private Panel pnlMenuPlayersGames;
        private DataGridView dgviewMatches;
        private Label lblMatches;
        private Button btnPrintMatches;
        private Label lblLoading;
    }
}