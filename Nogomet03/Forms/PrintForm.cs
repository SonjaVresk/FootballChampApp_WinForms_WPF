using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogomet03.Forms
{
    public partial class PrintForm : Form
    {
        private DataGridView dgview;
        private int printedPages = 0;

        public PrintForm(DataGridView dgv)
        {
            InitializeComponent();

            dgview = dgv;

        }

        private void BtnClosePrintForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bitmap = new Bitmap(dgview.Width, dgview.Height);

            dgview.DrawToBitmap(bitmap, new Rectangle(0, 0, dgview.Width, dgview.Height));

            e.Graphics?.DrawImage(bitmap, e.MarginBounds.X, e.MarginBounds.Y); //postavlja zadane margine na ispisu

            // counter za broj stranica
            if (++printedPages < nudCopies.Value)
            {
                e.HasMorePages = true;
            }
            else
            {
                printedPages = 0;
            }
        }

        private void PrintDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //if (e.PrintAction == System.Drawing.Printing.PrintAction.PrintToPreview)
            //{
            //    MessageBox.Show("Ispis završen!");
            //}
        }

        private void BtnPrintNow_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void BtnMargins_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }
    }
}
