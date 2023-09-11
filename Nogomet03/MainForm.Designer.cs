namespace Nogomet03
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnEnter = new Button();
            pnlSelectChampLang = new Panel();
            groupBox2 = new GroupBox();
            rbtnEng = new RadioButton();
            rbtnCro = new RadioButton();
            groupBox1 = new GroupBox();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            label2 = new Label();
            lblSelectChamp = new Label();
            btnSaveChampLangFirst = new Button();
            pnlSelectChampLang.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            resources.ApplyResources(btnEnter, "btnEnter");
            btnEnter.ForeColor = Color.GreenYellow;
            btnEnter.Name = "btnEnter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += BtnEnter_Click;
            // 
            // pnlSelectChampLang
            // 
            pnlSelectChampLang.BackColor = Color.FromArgb(90, 151, 30);
            pnlSelectChampLang.Controls.Add(groupBox2);
            pnlSelectChampLang.Controls.Add(groupBox1);
            pnlSelectChampLang.Controls.Add(label2);
            pnlSelectChampLang.Controls.Add(lblSelectChamp);
            resources.ApplyResources(pnlSelectChampLang, "pnlSelectChampLang");
            pnlSelectChampLang.Name = "pnlSelectChampLang";
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
            // btnSaveChampLangFirst
            // 
            btnSaveChampLangFirst.BackColor = Color.Black;
            btnSaveChampLangFirst.Cursor = Cursors.Hand;
            btnSaveChampLangFirst.FlatAppearance.BorderSize = 0;
            btnSaveChampLangFirst.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(btnSaveChampLangFirst, "btnSaveChampLangFirst");
            btnSaveChampLangFirst.ForeColor = Color.GreenYellow;
            btnSaveChampLangFirst.Name = "btnSaveChampLangFirst";
            btnSaveChampLangFirst.UseVisualStyleBackColor = false;
            btnSaveChampLangFirst.Click += BtnSaveChampLangFirst_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nogomet4;
            Controls.Add(btnSaveChampLangFirst);
            Controls.Add(pnlSelectChampLang);
            Controls.Add(btnEnter);
            Name = "MainForm";
            pnlSelectChampLang.ResumeLayout(false);
            pnlSelectChampLang.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnter;
        private Button btnChampLangNext;
        private Panel pnlSelectChampLang;
        private GroupBox groupBox2;
        private RadioButton rbtnEng;
        private RadioButton rbtnCro;
        private GroupBox groupBox1;
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private Label label2;
        private Label lblSelectChamp;
        private Button btnSaveChampLangFirst;
    }
}