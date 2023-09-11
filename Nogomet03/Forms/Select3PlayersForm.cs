using Nogomet03.UserControls;
using Repository;
using Repository.Models;
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
    public partial class Select3PlayersForm : Form
    {

        private string pathPlayers = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//players.txt";
        private string path1 = "https://worldcup-vua.nullbit.hr/";
        private string path2 = "/matches/country?fifa_code=";
        private string _code;
        private string _gender;
        public List<string> playersName = new List<string>();

        public static FlowLayoutPanel flPnlAllPlayeresInstance;
        public static FlowLayoutPanel flPnl3PlayersInstance;

        IRepository repository = RepositoryFactory.GetRepository();


        public Select3PlayersForm(string code, string gender)
        {
            InitializeComponent();

            _code = code;
            _gender = gender;

            flPnlAllPlayeres.ResetText();

            ShowPlayersAsync();
            //ShowPlayersFile();

            //DnD
            this.flPnlAllPlayeres.AllowDrop = true;
            this.flPnlAllPlayeres.DragEnter += FlPnlPlayers_DragEnter;
            this.flPnlAllPlayeres.DragDrop += FlPnlPlayers_DragDrop;

            this.flPnl3Players.AllowDrop = true;
            this.flPnl3Players.DragEnter += FlPnlPlayers_DragEnter;
            this.flPnl3Players.DragDrop += FlPnlPlayers_DragDrop;


            flPnlAllPlayeresInstance = flPnlAllPlayeres;
            flPnl3PlayersInstance = flPnl3Players;

        }


        private async void ShowPlayersAsync()
        {
            try
            {
                lblLoading.Visible = true;

                List<StartingEleven> players = new List<StartingEleven>();

                var data = await repository.GetDataAPI<Matches>(path1 + _gender + path2 + _code);

                if (data[0].HomeTeam.Code == _code)
                {
                    players.AddRange(data[0].HomeTeamStatistics.StartingEleven);
                    players.AddRange(data[0].HomeTeamStatistics.Substitutes);
                }
                else
                {
                    players.AddRange(data[0].AwayTeamStatistics.StartingEleven);
                    players.AddRange(data[0].AwayTeamStatistics.Substitutes);
                }

                foreach (var p in players)
                {
                    PlayerUC playerUC = new PlayerUC();

                    playerUC.lblPlayerNameInstance.Text = p.Name;
                    playerUC.lblPlayerNumberInstance.Text = p.ShirtNumber.ToString();
                    playerUC.lblPlayerPositionInstance.Text = p.Position;


                    flPnlAllPlayeres.Controls.Add(playerUC);

                    if (p.Captain == true)
                    {
                        playerUC.pboxCaptainInstance.Show();
                    }
                    else
                    {
                        playerUC.pboxCaptainInstance.Hide();
                    }


                    //provjera postoje li već omiljeni igrači
                    var favoritplayer = repository.ReadFromFile(pathPlayers);

                    if (favoritplayer == null)
                    {
                        return;
                    }
                    else
                    {
                        foreach (var name in favoritplayer)
                        {
                            if (p.Name == name)
                            {
                                playerUC.pboxFavoritStarInstance.Show();
                            }
                        }
                    }
                }
                lblLoading.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška.");
                return;
            }
        }


        private void BtnSelectPlayersBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectTeamForm selectTeamForm = new SelectTeamForm();
            selectTeamForm.Show();
        }

        private void BtnSelectPlayersNext_Click(object sender, EventArgs e)
        {

            if (flPnl3Players.Controls.Count < 3)
            {
                MessageBox.Show("Odaberite tri igrača!");
            }
            else
            {
                foreach (PlayerUC player in flPnl3Players.Controls) //upis tri omiljena igrača u listu playersName i ispis u file
                {
                    if (player is UserControl)
                    {
                        playersName.Add(player.lblPlayerNameInstance.Text);
                    }
                }

                repository.WriteToFile(pathPlayers, playersName);

                this.Hide();
                TeamsForm teamsForm = new TeamsForm(_code, _gender);
                teamsForm.Show();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SelectChampLanguageUC selectChampLanguageUC = new SelectChampLanguageUC();
            selectChampLanguageUC.Location = new Point((this.ClientSize.Width - selectChampLanguageUC.Width) / 2, (this.ClientSize.Height - selectChampLanguageUC.Height) / 2);
            this.Controls.Add(selectChampLanguageUC);
            selectChampLanguageUC.BringToFront();
        }

        private void FlPnlPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void FlPnlPlayers_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PlayerUC)))
            {
                PlayerUC playerUC = e.Data.GetData(typeof(PlayerUC)) as PlayerUC;
                FlowLayoutPanel flp = sender as FlowLayoutPanel;

                if (flp == flPnl3Players && !flp.Controls.Contains(playerUC))
                {
                    if (flPnl3Players.Controls.Count >= 3)
                    {
                        //ako sadrži već 3 igrača
                        MessageBox.Show("Možete odabrati samo tri igrača!");
                        return;
                    }
                    else
                    {
                        playerUC.Location = flp.PointToClient(new Point(e.X, e.Y));
                        flp.Controls.Add(playerUC);
                        // selectedControls.Add(playerUC);

                        playerUC.pboxFavoritStarInstance.Visible = true;
                        playerUC.btnDeletePlayerInstance.Visible = true;
                    }
                }
            }
        }
    }
}
