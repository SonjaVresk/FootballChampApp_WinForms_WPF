namespace Nogomet03.Forms
{
    partial class RankingPlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingPlayersForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnMenuRanking = new Button();
            btnMenuPlayers = new Button();
            btnMenuTeams = new Button();
            pnlHeader2 = new Panel();
            btnSettings2 = new Button();
            btnMenuRankingPlayers = new Button();
            btnMenuRankingGames = new Button();
            pnlMenuPlayersGames = new Panel();
            dgviewPlayers = new DataGridView();
            cboxRanking = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            btnPrintMatches = new Button();
            lblLoading = new Label();
            pnlHeader2.SuspendLayout();
            pnlMenuPlayersGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgviewPlayers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // pnlHeader2
            // 
            pnlHeader2.BackColor = Color.Black;
            pnlHeader2.Controls.Add(btnSettings2);
            pnlHeader2.Controls.Add(btnMenuRanking);
            pnlHeader2.Controls.Add(btnMenuPlayers);
            pnlHeader2.Controls.Add(btnMenuTeams);
            resources.ApplyResources(pnlHeader2, "pnlHeader2");
            pnlHeader2.Name = "pnlHeader2";
            // 
            // btnSettings2
            // 
            btnSettings2.BackColor = Color.Transparent;
            btnSettings2.Cursor = Cursors.Hand;
            btnSettings2.FlatAppearance.BorderSize = 0;
            btnSettings2.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 5, 5);
            resources.ApplyResources(btnSettings2, "btnSettings2");
            btnSettings2.ForeColor = Color.GreenYellow;
            btnSettings2.Name = "btnSettings2";
            btnSettings2.UseVisualStyleBackColor = false;
            btnSettings2.Click += BtnSettings2_Click;
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
            // dgviewPlayers
            // 
            dataGridViewCellStyle1.BackColor = Color.YellowGreen;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgviewPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgviewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgviewPlayers.BackgroundColor = Color.White;
            dgviewPlayers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(90, 151, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.GreenYellow;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgviewPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(dgviewPlayers, "dgviewPlayers");
            dgviewPlayers.Name = "dgviewPlayers";
            dgviewPlayers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgviewPlayers.RowHeadersVisible = false;
            dgviewPlayers.RowTemplate.Height = 25;
            // 
            // cboxRanking
            // 
            cboxRanking.FormattingEnabled = true;
            resources.ApplyResources(cboxRanking, "cboxRanking");
            cboxRanking.Name = "cboxRanking";
            cboxRanking.SelectedIndexChanged += CboxRanking_SelectedIndexChangedAsync;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.YellowGreen;
            label1.ForeColor = Color.Black;
            label1.Name = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnPrintMatches);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboxRanking);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
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
            // RankingPlayersForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nogomet4;
            Controls.Add(lblLoading);
            Controls.Add(panel1);
            Controls.Add(pnlMenuPlayersGames);
            Controls.Add(dgviewPlayers);
            Controls.Add(pnlHeader2);
            Name = "RankingPlayersForm";
            Load += RankingPlayersForm_Load;
            pnlHeader2.ResumeLayout(false);
            pnlMenuPlayersGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgviewPlayers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenuRanking;
        private Button btnMenuPlayers;
        private Button btnMenuTeams;
        private Panel pnlHeader2;
        private Button btnMenuRankingPlayers;
        private Button btnMenuRankingGames;
        private Panel pnlMenuPlayersGames;
        private Button btnSettings2;
        private DataGridView dgviewPlayers;
        private ComboBox cboxRanking;
        private Label label1;
        private Panel panel1;
        private Button btnPrintMatches;
        private Label lblLoading;
    }
}