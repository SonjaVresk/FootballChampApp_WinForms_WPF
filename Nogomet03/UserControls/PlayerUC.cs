using Nogomet03.Forms;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogomet03.UserControls
{
    public partial class PlayerUC : UserControl
    {
        private const string path = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Images//";

        private Point _location;
        private bool _isDragging;

        public PlayerUC ucplayerInstance;
        public Label lblPlayerNameInstance;
        public Label lblPlayerNumberInstance;
        public Label lblPlayerPositionInstance;
        public PictureBox pboxCaptainInstance;
        public PictureBox pboxFavoritStarInstance;
        public PictureBox pboxPlayerInstance;
        public Button btnDeletePlayerInstance;

        public bool IsSelected
        {
            get; set;
        } //defaultno je false


        public PlayerUC()
        {
            InitializeComponent();

            //Instanciranje kontrola da se mogu dohvatiti iz forme
            ucplayerInstance = this;
            lblPlayerNameInstance = lblPlayerName;
            lblPlayerNumberInstance = lblPlayerNumber;
            lblPlayerPositionInstance = lblPlayerPosition;
            pboxCaptainInstance = pboxCaptain;
            pboxFavoritStarInstance = pboxFavoritStar;
            pboxPlayerInstance = pboxPlayer;
            btnDeletePlayerInstance = btnDeletePlayer;

        }

        private void PlayerUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _location = e.Location;
                _isDragging = true;
            }
        }

        private void PlayerUC_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                this.DoDragDrop(this, DragDropEffects.Move);
                gboxPlayer.DoDragDrop(gboxPlayer, DragDropEffects.Move);
                pboxPlayer.DoDragDrop(pboxPlayer, DragDropEffects.Move);
                lblPlayerName.DoDragDrop(lblPlayerName, DragDropEffects.Move);
                lblPlayerPosition.DoDragDrop(lblPlayerPosition, DragDropEffects.Move);
                lblPlayerNumber.DoDragDrop(lblPlayerNumber, DragDropEffects.Move);
                lblNumber.DoDragDrop(lblNumber, DragDropEffects.Move);

                _isDragging = false;
            }
        }

        private void PlayerUC_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _location = Point.Empty;
                _isDragging = false;
            }
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            //referenca na panel iz forme
            Form Select3PlayersForm = this.ParentForm;
            FlowLayoutPanel flPnl3Players = (FlowLayoutPanel)Select3PlayersForm.Controls["flPnl3Players"];
            FlowLayoutPanel flPnlAllPlayeres = (FlowLayoutPanel)Select3PlayersForm.Controls["flPnlAllPlayeres"];

            flPnl3Players.Controls.Remove(this);    //brisanje igrača iz panela

            flPnlAllPlayeres.Controls.Add(this);    //dodavanje igrača u panel sa svim igračima
            pboxFavoritStar.Visible = false;
            btnDeletePlayer.Visible = false;
            BackColor = Color.Transparent;
        }

        private void PlayerUC_MouseClick(object sender, MouseEventArgs e)
        {
            IsSelected = !IsSelected;   //stavlja selected na true, na drugi klik mijenja u prijašnju boju
            BackColor = IsSelected ? Color.YellowGreen : Color.Transparent; //mijenja se boja u selektiranu
        }

        private void PlayerUC_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{path}{lblPlayerName.Text}.jpg"))
            {
                pboxPlayer.Image = Image.FromFile($"{path}{lblPlayerName.Text}.jpg"); //Provjera ima li već uploadane slike otprije
            }
        }

    }
}
