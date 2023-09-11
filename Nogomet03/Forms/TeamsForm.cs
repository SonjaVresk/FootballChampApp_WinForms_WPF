using Nogomet03.UserControls;
using Repository.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogomet03.Forms
{
    public partial class TeamsForm : Form
    {

        private string pathPlayers = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//players.txt";
        private string path1 = "https://worldcup-vua.nullbit.hr/";
        private string path2 = "/matches/country?fifa_code=";
        private string _code;
        private string _gender;

        public TeamsForm(string code, string gender)
        {
            InitializeComponent();
            _code = code;
            _gender = gender;

            flpPlayers.ResetText();

            ShowPlayersAsync();
        }

        private async Task ShowPlayersAsync()
        {
            try
            {
                List<StartingEleven> players = new List<StartingEleven>();

                IRepository repository = RepositoryFactory.GetRepository();
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
                    AllPlayersUC player = new AllPlayersUC();

                    player.lblPNameInstance.Text = p.Name;
                    player.lblPNumberInstance.Text = p.ShirtNumber.ToString();
                    player.lblPPositionInstance.Text = p.Position;


                    flpPlayers.Controls.Add(player);

                    if (p.Captain == true)
                    {
                        player.pboxPCaptainInstance.Show();
                    }
                    else
                    {
                        player.pboxPCaptainInstance.Hide();
                    }
                    List<string> favoritPlayers = repository.ReadFromFile(pathPlayers);

                    if (favoritPlayers.Contains(p.Name))
                    {
                        player.pboxPFavoritStarInstance.Visible = true;
                    }
                    else
                    {
                        player.pboxPFavoritStarInstance.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška kod dohvaćanja podataka.");
                return;
            }

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SelectChampLanguageUC selectChampLanguageUC = new SelectChampLanguageUC();
            selectChampLanguageUC.Location = new Point((this.ClientSize.Width - selectChampLanguageUC.Width) / 2, (this.ClientSize.Height - selectChampLanguageUC.Height) / 2);
            this.Controls.Add(selectChampLanguageUC);
            selectChampLanguageUC.BringToFront();

        }


        //meni Rang liste - otvara se Igrači i Utakmice
        private void BtnMenuRanking_MouseHover(object sender, EventArgs e)
        {
            pnlMenuPlayersGames.Visible = true;
        }


        //uklanjanje ranking menija kad se makne miš
        private void PnlMenuPlayersGames_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlMenuPlayersGames.ClientRectangle.Contains(btnMenuRankingPlayers.PointToClient(Control.MousePosition))
                && !pnlMenuPlayersGames.ClientRectangle.Contains(btnMenuRankingGames.PointToClient(Control.MousePosition)))
            {
                pnlMenuPlayersGames.Hide();
            }
        }

        private void BtnMenuTeams_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectTeamForm selectTeamForm = new SelectTeamForm();
            selectTeamForm.Show();
        }

        private void BtnMenuRankingPlayers_Click(object sender, EventArgs e)
        {
            RankingPlayersForm rankingPlayersForm = new RankingPlayersForm(_code, _gender);
            this.Hide();

            rankingPlayersForm.Show();
        }

        private void BtnMenuRankingGames_Click(object sender, EventArgs e)
        {
            RankingMatchesForm rankingMatchesForm = new RankingMatchesForm(_code, _gender);
            this.Hide();

            rankingMatchesForm.Show();
        }

        //private void TeamsForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Jeste li sigurni?");

        //    if (result == DialogResult.Cancel)
        //    {
        //        e.Cancel = true;
        //    }
        //    else if (result == DialogResult.OK)
        //    {
        //        Application.Exit();
        //    }
        //}
    }
}
