namespace Nogomet03.Forms
{
    partial class SelectTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTeamForm));
            lblSelectTeam = new Label();
            cboxTeams = new ComboBox();
            btnSelectTeamNext = new Button();
            pnlHeader = new Panel();
            btnSettings = new Button();
            progressBar = new ProgressBar();
            btnReload = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelectTeam
            // 
            lblSelectTeam.BackColor = Color.Black;
            resources.ApplyResources(lblSelectTeam, "lblSelectTeam");
            lblSelectTeam.ForeColor = Color.GreenYellow;
            lblSelectTeam.Name = "lblSelectTeam";
            // 
            // cboxTeams
            // 
            cboxTeams.BackColor = SystemColors.Control;
            cboxTeams.ForeColor = Color.Black;
            cboxTeams.FormattingEnabled = true;
            resources.ApplyResources(cboxTeams, "cboxTeams");
            cboxTeams.Name = "cboxTeams";
            cboxTeams.TabStop = false;
            // 
            // btnSelectTeamNext
            // 
            btnSelectTeamNext.BackColor = Color.Black;
            btnSelectTeamNext.Cursor = Cursors.Hand;
            btnSelectTeamNext.FlatAppearance.BorderSize = 0;
            btnSelectTeamNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(btnSelectTeamNext, "btnSelectTeamNext");
            btnSelectTeamNext.ForeColor = Color.GreenYellow;
            btnSelectTeamNext.Name = "btnSelectTeamNext";
            btnSelectTeamNext.UseVisualStyleBackColor = false;
            btnSelectTeamNext.Click += BtnSelectTeamNext_Click;
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
            // progressBar
            // 
            resources.ApplyResources(progressBar, "progressBar");
            progressBar.Name = "progressBar";
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.GreenYellow;
            btnReload.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnReload, "btnReload");
            btnReload.ForeColor = Color.Black;
            btnReload.Name = "btnReload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += BtnReload_Click;
            // 
            // SelectTeamForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nogomet4;
            Controls.Add(btnReload);
            Controls.Add(progressBar);
            Controls.Add(pnlHeader);
            Controls.Add(btnSelectTeamNext);
            Controls.Add(cboxTeams);
            Controls.Add(lblSelectTeam);
            Name = "SelectTeamForm";
            Load += SelectTeamForm_LoadAsync;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSelectTeam;
        private ComboBox cboxTeams;
        private Button btnSelectTeamNext;
        private Panel pnlHeader;
        private Button btnSettings;
        private ProgressBar progressBar;
        private Button btnReload;
    }
}