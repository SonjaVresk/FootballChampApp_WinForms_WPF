namespace Nogomet03.Forms
{
    partial class Select3PlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select3PlayersForm));
            btnSelectPlayersNext = new Button();
            lblSelect3Players = new Label();
            btnSelectPlayersBack = new Button();
            pnlHeader = new Panel();
            btnSettings = new Button();
            flPnlAllPlayeres = new FlowLayoutPanel();
            lblLoading = new Label();
            flPnl3Players = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            flPnlAllPlayeres.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectPlayersNext
            // 
            btnSelectPlayersNext.BackColor = Color.Black;
            btnSelectPlayersNext.FlatAppearance.BorderSize = 0;
            btnSelectPlayersNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(btnSelectPlayersNext, "btnSelectPlayersNext");
            btnSelectPlayersNext.ForeColor = Color.GreenYellow;
            btnSelectPlayersNext.Name = "btnSelectPlayersNext";
            btnSelectPlayersNext.UseVisualStyleBackColor = false;
            btnSelectPlayersNext.Click += BtnSelectPlayersNext_Click;
            // 
            // lblSelect3Players
            // 
            lblSelect3Players.BackColor = Color.Black;
            resources.ApplyResources(lblSelect3Players, "lblSelect3Players");
            lblSelect3Players.ForeColor = Color.GreenYellow;
            lblSelect3Players.Name = "lblSelect3Players";
            // 
            // btnSelectPlayersBack
            // 
            btnSelectPlayersBack.BackColor = Color.Black;
            btnSelectPlayersBack.FlatAppearance.BorderSize = 0;
            btnSelectPlayersBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(btnSelectPlayersBack, "btnSelectPlayersBack");
            btnSelectPlayersBack.ForeColor = Color.GreenYellow;
            btnSelectPlayersBack.Name = "btnSelectPlayersBack";
            btnSelectPlayersBack.UseVisualStyleBackColor = false;
            btnSelectPlayersBack.Click += BtnSelectPlayersBack_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(btnSettings);
            resources.ApplyResources(pnlHeader, "pnlHeader");
            pnlHeader.Name = "pnlHeader";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.ForeColor = Color.Black;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += BtnSettings_Click;
            // 
            // flPnlAllPlayeres
            // 
            flPnlAllPlayeres.AllowDrop = true;
            resources.ApplyResources(flPnlAllPlayeres, "flPnlAllPlayeres");
            flPnlAllPlayeres.BackColor = Color.FromArgb(90, 151, 30);
            flPnlAllPlayeres.Controls.Add(lblLoading);
            flPnlAllPlayeres.Name = "flPnlAllPlayeres";
            // 
            // lblLoading
            // 
            lblLoading.BackColor = Color.YellowGreen;
            resources.ApplyResources(lblLoading, "lblLoading");
            lblLoading.Name = "lblLoading";
            // 
            // flPnl3Players
            // 
            flPnl3Players.AllowDrop = true;
            resources.ApplyResources(flPnl3Players, "flPnl3Players");
            flPnl3Players.BackColor = Color.FromArgb(90, 151, 30);
            flPnl3Players.Name = "flPnl3Players";
            // 
            // Select3PlayersForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nogomet4;
            Controls.Add(flPnlAllPlayeres);
            Controls.Add(pnlHeader);
            Controls.Add(btnSelectPlayersBack);
            Controls.Add(lblSelect3Players);
            Controls.Add(btnSelectPlayersNext);
            Controls.Add(flPnl3Players);
            Name = "Select3PlayersForm";
            pnlHeader.ResumeLayout(false);
            flPnlAllPlayeres.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectPlayersNext;
        private Label lblSelect3Players;
        private Button btnSelectPlayersBack;
        private Panel pnlHeader;
        private Button btnSettings;
        private FlowLayoutPanel flPnlAllPlayeres;
        private FlowLayoutPanel flPnl3Players;
        private UserControls.PlayerUC playeruc1;
        private Label lblLoading;
    }
}