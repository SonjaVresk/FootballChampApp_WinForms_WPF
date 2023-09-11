using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogomet03.UserControls
{
    public partial class AllPlayersUC : UserControl
    {
        private const string path = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Images//";
        public AllPlayersUC allplayersInstance;
        public Label lblPNameInstance;
        public Label lblPNumberInstance;
        public Label lblPPositionInstance;
        public PictureBox pboxPCaptainInstance;
        public PictureBox pboxPFavoritStarInstance;
        public PictureBox pboxPlayerPicInstance;

        public AllPlayersUC()
        {
            InitializeComponent();

            //Instanciranje kontrola da se mogu dohvatiti iz forme
            allplayersInstance = this;
            lblPNameInstance = lblPName;
            lblPNumberInstance = lblPNumber;
            lblPPositionInstance = lblPPosition;
            pboxPCaptainInstance = pboxPCaptain;
            pboxPFavoritStarInstance = pboxPFavoritStar;
            pboxPlayerPicInstance = pboxPlayerPic;
        }

        private void PboxPlayerPic_Click(object sender, EventArgs e)
        {
            // stvara se prozor dijalog za izbor slike
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // odabir slike
            openFileDialog.Filter = "Slike (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            try
            {
                // ako klikne ok
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // postavlja se slika
                    pboxPlayerPic.Image = new Bitmap(openFileDialog.FileName);

                    pboxPlayerPic.Image.Save($"{path}{lblPName.Text}.jpg");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Greška u postavljanju slike");
            }
        }

        private void AllPlayersUC_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{path}{lblPName.Text}.jpg"))
            {
                pboxPlayerPic.Image = Image.FromFile($"{path}{lblPName.Text}.jpg"); //Provjera ima li već uploadane slike otprije
            }
        }
    }
}
