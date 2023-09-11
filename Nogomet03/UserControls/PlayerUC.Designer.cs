namespace Nogomet03.UserControls
{
    partial class PlayerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerUC));
            gboxPlayer = new GroupBox();
            lblPlayerNumber = new Label();
            lblPlayerPosition = new Label();
            pboxFavoritStar = new PictureBox();
            pboxCaptain = new PictureBox();
            lblNumber = new Label();
            pboxPlayer = new PictureBox();
            lblPlayerName = new Label();
            btnDeletePlayer = new Button();
            gboxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFavoritStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxCaptain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxPlayer).BeginInit();
            SuspendLayout();
            // 
            // gboxPlayer
            // 
            gboxPlayer.Controls.Add(lblPlayerNumber);
            gboxPlayer.Controls.Add(lblPlayerPosition);
            gboxPlayer.Controls.Add(pboxFavoritStar);
            gboxPlayer.Controls.Add(pboxCaptain);
            gboxPlayer.Controls.Add(lblNumber);
            gboxPlayer.Controls.Add(pboxPlayer);
            gboxPlayer.Controls.Add(lblPlayerName);
            resources.ApplyResources(gboxPlayer, "gboxPlayer");
            gboxPlayer.Name = "gboxPlayer";
            gboxPlayer.TabStop = false;
            // 
            // lblPlayerNumber
            // 
            lblPlayerNumber.AllowDrop = true;
            lblPlayerNumber.BackColor = SystemColors.Window;
            lblPlayerNumber.Cursor = Cursors.Hand;
            resources.ApplyResources(lblPlayerNumber, "lblPlayerNumber");
            lblPlayerNumber.Name = "lblPlayerNumber";
            lblPlayerNumber.MouseClick += PlayerUC_MouseClick;
            lblPlayerNumber.MouseDown += PlayerUC_MouseDown;
            lblPlayerNumber.MouseMove += PlayerUC_MouseMove;
            lblPlayerNumber.MouseUp += PlayerUC_MouseUp;
            // 
            // lblPlayerPosition
            // 
            lblPlayerPosition.AllowDrop = true;
            lblPlayerPosition.BackColor = SystemColors.Window;
            lblPlayerPosition.Cursor = Cursors.Hand;
            resources.ApplyResources(lblPlayerPosition, "lblPlayerPosition");
            lblPlayerPosition.Name = "lblPlayerPosition";
            lblPlayerPosition.MouseClick += PlayerUC_MouseClick;
            lblPlayerPosition.MouseDown += PlayerUC_MouseDown;
            lblPlayerPosition.MouseMove += PlayerUC_MouseMove;
            lblPlayerPosition.MouseUp += PlayerUC_MouseUp;
            // 
            // pboxFavoritStar
            // 
            pboxFavoritStar.Cursor = Cursors.Hand;
            pboxFavoritStar.Image = Properties.Resources.star;
            resources.ApplyResources(pboxFavoritStar, "pboxFavoritStar");
            pboxFavoritStar.Name = "pboxFavoritStar";
            pboxFavoritStar.TabStop = false;
            pboxFavoritStar.MouseClick += PlayerUC_MouseClick;
            pboxFavoritStar.MouseDown += PlayerUC_MouseDown;
            pboxFavoritStar.MouseMove += PlayerUC_MouseMove;
            pboxFavoritStar.MouseUp += PlayerUC_MouseUp;
            // 
            // pboxCaptain
            // 
            pboxCaptain.Cursor = Cursors.Hand;
            pboxCaptain.Image = Properties.Resources.captain__1_;
            resources.ApplyResources(pboxCaptain, "pboxCaptain");
            pboxCaptain.Name = "pboxCaptain";
            pboxCaptain.TabStop = false;
            pboxCaptain.MouseClick += PlayerUC_MouseClick;
            pboxCaptain.MouseDown += PlayerUC_MouseDown;
            pboxCaptain.MouseMove += PlayerUC_MouseMove;
            pboxCaptain.MouseUp += PlayerUC_MouseUp;
            // 
            // lblNumber
            // 
            resources.ApplyResources(lblNumber, "lblNumber");
            lblNumber.Cursor = Cursors.Hand;
            lblNumber.Name = "lblNumber";
            lblNumber.MouseClick += PlayerUC_MouseClick;
            lblNumber.MouseDown += PlayerUC_MouseDown;
            lblNumber.MouseMove += PlayerUC_MouseMove;
            lblNumber.MouseUp += PlayerUC_MouseUp;
            // 
            // pboxPlayer
            // 
            pboxPlayer.Cursor = Cursors.Hand;
            pboxPlayer.Image = Properties.Resources.user;
            resources.ApplyResources(pboxPlayer, "pboxPlayer");
            pboxPlayer.Name = "pboxPlayer";
            pboxPlayer.TabStop = false;
            pboxPlayer.MouseClick += PlayerUC_MouseClick;
            pboxPlayer.MouseDown += PlayerUC_MouseDown;
            pboxPlayer.MouseMove += PlayerUC_MouseMove;
            pboxPlayer.MouseUp += PlayerUC_MouseUp;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AllowDrop = true;
            lblPlayerName.BackColor = SystemColors.Window;
            lblPlayerName.Cursor = Cursors.Hand;
            resources.ApplyResources(lblPlayerName, "lblPlayerName");
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.MouseClick += PlayerUC_MouseClick;
            lblPlayerName.MouseDown += PlayerUC_MouseDown;
            lblPlayerName.MouseMove += PlayerUC_MouseMove;
            lblPlayerName.MouseUp += PlayerUC_MouseUp;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.BackColor = Color.FromArgb(90, 151, 30);
            btnDeletePlayer.BackgroundImage = Properties.Resources.bin;
            resources.ApplyResources(btnDeletePlayer, "btnDeletePlayer");
            btnDeletePlayer.Cursor = Cursors.Hand;
            btnDeletePlayer.FlatAppearance.BorderSize = 0;
            btnDeletePlayer.FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 151, 30);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.UseVisualStyleBackColor = false;
            btnDeletePlayer.Click += BtnDeletePlayer_Click;
            // 
            // PlayerUC
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeletePlayer);
            Controls.Add(gboxPlayer);
            Name = "PlayerUC";
            Load += PlayerUC_Load;
            MouseClick += PlayerUC_MouseClick;
            MouseDown += PlayerUC_MouseDown;
            MouseMove += PlayerUC_MouseMove;
            MouseUp += PlayerUC_MouseUp;
            gboxPlayer.ResumeLayout(false);
            gboxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxFavoritStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxCaptain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxPlayer;
        private Label lblNumber;
        private PictureBox pboxFavoritStar;
        private PictureBox pboxCaptain;
        private PictureBox pboxPlayer;
        private Label lblPlayerName;
        private Label lblPlayerPosition;
        private Label lblPlayerNumber;
        private Button btnDeletePlayer;
    }
}
