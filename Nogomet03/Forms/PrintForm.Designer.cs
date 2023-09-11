namespace Nogomet03.Forms
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            nudCopies = new NumericUpDown();
            lblNumberCopies = new Label();
            btnMargins = new Button();
            btnPrintNow = new Button();
            btnPreview = new Button();
            btnClosePrintForm = new Button();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printDialog = new PrintDialog();
            pageSetupDialog = new PageSetupDialog();
            printPreviewDialog = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)nudCopies).BeginInit();
            SuspendLayout();
            // 
            // nudCopies
            // 
            resources.ApplyResources(nudCopies, "nudCopies");
            nudCopies.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCopies.Name = "nudCopies";
            nudCopies.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNumberCopies
            // 
            resources.ApplyResources(lblNumberCopies, "lblNumberCopies");
            lblNumberCopies.Name = "lblNumberCopies";
            // 
            // btnMargins
            // 
            btnMargins.Image = Properties.Resources.margin;
            resources.ApplyResources(btnMargins, "btnMargins");
            btnMargins.Name = "btnMargins";
            btnMargins.UseVisualStyleBackColor = true;
            btnMargins.Click += BtnMargins_Click;
            // 
            // btnPrintNow
            // 
            resources.ApplyResources(btnPrintNow, "btnPrintNow");
            btnPrintNow.Name = "btnPrintNow";
            btnPrintNow.UseVisualStyleBackColor = true;
            btnPrintNow.Click += BtnPrintNow_Click;
            // 
            // btnPreview
            // 
            btnPreview.Image = Properties.Resources.preview;
            resources.ApplyResources(btnPreview, "btnPreview");
            btnPreview.Name = "btnPreview";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += BtnPreview_Click;
            // 
            // btnClosePrintForm
            // 
            btnClosePrintForm.Image = Properties.Resources.close;
            resources.ApplyResources(btnClosePrintForm, "btnClosePrintForm");
            btnClosePrintForm.Name = "btnClosePrintForm";
            btnClosePrintForm.UseVisualStyleBackColor = true;
            btnClosePrintForm.Click += BtnClosePrintForm_Click;
            // 
            // printDocument
            // 
            printDocument.EndPrint += PrintDocument_EndPrint;
            printDocument.PrintPage += PrintDocument_PrintPage;
            // 
            // printDialog
            // 
            printDialog.Document = printDocument;
            printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            pageSetupDialog.Document = printDocument;
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(printPreviewDialog, "printPreviewDialog");
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Name = "printPreviewDialog1";
            // 
            // PrintForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(btnClosePrintForm);
            Controls.Add(btnPreview);
            Controls.Add(btnPrintNow);
            Controls.Add(btnMargins);
            Controls.Add(lblNumberCopies);
            Controls.Add(nudCopies);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrintForm";
            ((System.ComponentModel.ISupportInitialize)nudCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudCopies;
        private Label lblNumberCopies;
        private Button btnMargins;
        private Button btnPrintNow;
        private Button btnPreview;
        private Button btnClosePrintForm;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintDialog printDialog;
        private PageSetupDialog pageSetupDialog;
        private PrintPreviewDialog printPreviewDialog;
    }
}