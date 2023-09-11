namespace Nogomet03.UserControls
{
    partial class AllPlayersUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllPlayersUC));
            pboxPlayerPic = new PictureBox();
            pboxPFavoritStar = new PictureBox();
            pboxPCaptain = new PictureBox();
            lblPName = new Label();
            lblNo = new Label();
            lblPNumber = new Label();
            lblPPosition = new Label();
            lblPoz = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxPlayerPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxPFavoritStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxPCaptain).BeginInit();
            SuspendLayout();
            // 
            // pboxPlayerPic
            // 
            resources.ApplyResources(pboxPlayerPic, "pboxPlayerPic");
            pboxPlayerPic.Cursor = Cursors.Hand;
            pboxPlayerPic.Image = Properties.Resources.user__3_;
            pboxPlayerPic.Name = "pboxPlayerPic";
            pboxPlayerPic.TabStop = false;
            pboxPlayerPic.Click += PboxPlayerPic_Click;
            // 
            // pboxPFavoritStar
            // 
            pboxPFavoritStar.Image = Properties.Resources.star;
            resources.ApplyResources(pboxPFavoritStar, "pboxPFavoritStar");
            pboxPFavoritStar.Name = "pboxPFavoritStar";
            pboxPFavoritStar.TabStop = false;
            // 
            // pboxPCaptain
            // 
            pboxPCaptain.Image = Properties.Resources.captain__1_;
            resources.ApplyResources(pboxPCaptain, "pboxPCaptain");
            pboxPCaptain.Name = "pboxPCaptain";
            pboxPCaptain.TabStop = false;
            // 
            // lblPName
            // 
            resources.ApplyResources(lblPName, "lblPName");
            lblPName.Name = "lblPName";
            // 
            // lblNo
            // 
            resources.ApplyResources(lblNo, "lblNo");
            lblNo.Name = "lblNo";
            // 
            // lblPNumber
            // 
            resources.ApplyResources(lblPNumber, "lblPNumber");
            lblPNumber.Name = "lblPNumber";
            // 
            // lblPPosition
            // 
            resources.ApplyResources(lblPPosition, "lblPPosition");
            lblPPosition.Name = "lblPPosition";
            // 
            // lblPoz
            // 
            resources.ApplyResources(lblPoz, "lblPoz");
            lblPoz.Name = "lblPoz";
            // 
            // AllPlayersUC
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 151, 30);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPoz);
            Controls.Add(lblPPosition);
            Controls.Add(lblPNumber);
            Controls.Add(lblNo);
            Controls.Add(lblPName);
            Controls.Add(pboxPCaptain);
            Controls.Add(pboxPFavoritStar);
            Controls.Add(pboxPlayerPic);
            Name = "AllPlayersUC";
            Load += AllPlayersUC_Load;
            ((System.ComponentModel.ISupportInitialize)pboxPlayerPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxPFavoritStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxPCaptain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pboxPlayerPic;
        private PictureBox pboxPFavoritStar;
        private PictureBox pboxPCaptain;
        private Label lblPName;
        private Label lblNo;
        private Label lblPNumber;
        private Label lblPPosition;
        private Label lblPoz;
    }
}
