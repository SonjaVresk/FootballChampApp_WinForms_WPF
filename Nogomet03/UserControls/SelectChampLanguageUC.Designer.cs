namespace Nogomet03.UserControls
{
    partial class SelectChampLanguageUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectChampLanguageUC));
            pnlSelectChampLang = new Panel();
            btnClose = new Button();
            btnSaveChampLang = new Button();
            groupBox2 = new GroupBox();
            rbtnEng = new RadioButton();
            rbtnCro = new RadioButton();
            groupBox1 = new GroupBox();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            label2 = new Label();
            lblSelectChamp = new Label();
            pnlSelectChampLang.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSelectChampLang
            // 
            pnlSelectChampLang.BackColor = Color.FromArgb(90, 151, 70);
            pnlSelectChampLang.BorderStyle = BorderStyle.FixedSingle;
            pnlSelectChampLang.Controls.Add(btnClose);
            pnlSelectChampLang.Controls.Add(btnSaveChampLang);
            pnlSelectChampLang.Controls.Add(groupBox2);
            pnlSelectChampLang.Controls.Add(groupBox1);
            pnlSelectChampLang.Controls.Add(label2);
            pnlSelectChampLang.Controls.Add(lblSelectChamp);
            resources.ApplyResources(pnlSelectChampLang, "pnlSelectChampLang");
            pnlSelectChampLang.Name = "pnlSelectChampLang";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(90, 151, 30);
            btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Image = Properties.Resources.close;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // btnSaveChampLang
            // 
            btnSaveChampLang.BackColor = Color.Black;
            btnSaveChampLang.Cursor = Cursors.Hand;
            btnSaveChampLang.FlatAppearance.BorderSize = 0;
            btnSaveChampLang.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(btnSaveChampLang, "btnSaveChampLang");
            btnSaveChampLang.ForeColor = Color.GreenYellow;
            btnSaveChampLang.Name = "btnSaveChampLang";
            btnSaveChampLang.UseVisualStyleBackColor = false;
            btnSaveChampLang.Click += BtnSaveChampLang_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnEng);
            groupBox2.Controls.Add(rbtnCro);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // rbtnEng
            // 
            resources.ApplyResources(rbtnEng, "rbtnEng");
            rbtnEng.ForeColor = Color.PaleGreen;
            rbtnEng.Name = "rbtnEng";
            rbtnEng.TabStop = true;
            rbtnEng.UseVisualStyleBackColor = true;
            // 
            // rbtnCro
            // 
            resources.ApplyResources(rbtnCro, "rbtnCro");
            rbtnCro.ForeColor = Color.PaleGreen;
            rbtnCro.Name = "rbtnCro";
            rbtnCro.TabStop = true;
            rbtnCro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnMale);
            groupBox1.Controls.Add(rbtnFemale);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // rbtnMale
            // 
            resources.ApplyResources(rbtnMale, "rbtnMale");
            rbtnMale.ForeColor = Color.PaleGreen;
            rbtnMale.Name = "rbtnMale";
            rbtnMale.TabStop = true;
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            resources.ApplyResources(rbtnFemale, "rbtnFemale");
            rbtnFemale.ForeColor = Color.PaleGreen;
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.TabStop = true;
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.GreenYellow;
            label2.Name = "label2";
            // 
            // lblSelectChamp
            // 
            resources.ApplyResources(lblSelectChamp, "lblSelectChamp");
            lblSelectChamp.ForeColor = Color.GreenYellow;
            lblSelectChamp.Name = "lblSelectChamp";
            // 
            // SelectChampLanguageUC
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlSelectChampLang);
            Name = "SelectChampLanguageUC";
            Load += SelectChampLanguageUC_Load;
            pnlSelectChampLang.ResumeLayout(false);
            pnlSelectChampLang.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSelectChampLang;
        private GroupBox groupBox2;
        private RadioButton rbtnEng;
        private RadioButton rbtnCro;
        private GroupBox groupBox1;
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private Label label2;
        private Label lblSelectChamp;
        private Button btnSaveChampLang;
        private Button btnClose;
    }
}
