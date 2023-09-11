using Nogomet03.UserControls;
using Repository.Models;
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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Nogomet03.Forms
{
    public partial class RankingPlayersForm : Form
    {

        private string path1 = "https://worldcup-vua.nullbit.hr/";
        private string path2 = "/matches/country?fifa_code=";
        private string _code;
        private string _gender;
        private string rankingGoals = "Golovi";
        private string rankingYellowCards = "Žuti kartoni";
        private string ranking;

        public DataGridView dgviewPlayersInstance;

        public RankingPlayersForm(string code, string gender)
        {
            InitializeComponent();

            _code = code;
            _gender = gender;

            GetPlayersAsync(ranking);

            dgviewPlayersInstance = dgviewPlayers;
        }

        private async Task GetPlayersAsync(string ranking)
        {
            lblLoading.Visible = true;

            List<Player> plist = new List<Player>();
            List<StartingEleven> players = new List<StartingEleven>();
            List<TeamEvent> teamEvents = new List<TeamEvent>();


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


            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].HomeTeam.Code == _code)
                {
                    foreach (var d in data[i].HomeTeamEvents)
                    {
                        teamEvents.Add(d);
                    }
                }

                else
                {
                    foreach (var d in data[i].AwayTeamEvents)
                    {
                        teamEvents.Add(d);
                    }
                }
            }

            foreach (var p in players)
            {
                int goals = 0;
                int yellowcards = 0;

                foreach (var t in teamEvents)
                {
                    if (t.Player == p.Name && (t.TypeOfEvent == "goal" || t.TypeOfEvent == "goal-penalty"))
                    {
                        goals++;
                    }

                    if (t.Player == p.Name && t.TypeOfEvent == "yellow-card")
                    {
                        yellowcards++;
                    }
                }

                Player pl = new Player(p.Name, p.ShirtNumber, p.Position, goals, yellowcards);

                plist.Add(pl);

                if (ranking == rankingGoals)
                {
                    plist.Sort(new PlayersGoalsComparer());
                }
                else if (ranking == rankingYellowCards)
                {
                    plist.Sort(new PlayersYellowCardsComparer());
                }
                else
                {
                    plist.Sort(new PlayersNumberComparer());
                }
            }

            try
            {
                dgviewPlayers.DataSource = plist;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                return;
            }

            //dgviewPlayers.Sort(dgviewPlayers.Columns["Number"], ListSortDirection.Ascending);

            lblLoading.Visible = false;
        }

        private void BtnSettings2_Click(object sender, EventArgs e)
        {
            SelectChampLanguageUC selectChampLanguageUC = new SelectChampLanguageUC();
            selectChampLanguageUC.Location = new Point((this.ClientSize.Width - selectChampLanguageUC.Width) / 2, (this.ClientSize.Height - selectChampLanguageUC.Height) / 2);
            this.Controls.Add(selectChampLanguageUC);
            selectChampLanguageUC.BringToFront();
        }

        private void BtnMenuTeams_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectTeamForm selectTeamForm = new SelectTeamForm();
            selectTeamForm.Show();
        }

        private void BtnMenuPlayers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select3PlayersForm select3PlayersForm = new Select3PlayersForm(_code, _gender);
            select3PlayersForm.Show();
        }

        private void RankingPlayersForm_Load(object sender, EventArgs e)
        {
            cboxRanking.Items.Clear();

            string[] select = { rankingGoals, rankingYellowCards };

            foreach (string s in select)
            {
                cboxRanking.Items.Add(s);
                cboxRanking.SelectedIndex = 0;
            }

            ranking = cboxRanking.SelectedItem.ToString();
        }


        //promjena odabira u combobox-u
        private async void CboxRanking_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            ranking = cboxRanking.SelectedItem.ToString();

            // reload data in DataGridView based on selectedCountry
            await GetPlayersAsync(ranking);
        }

        private void BtnMenuRankingGames_Click(object sender, EventArgs e)
        {
            RankingMatchesForm rankingMatchesForm = new RankingMatchesForm(_code, _gender);
            this.Hide();

            rankingMatchesForm.Show();
        }

        private void BtnMenuRanking_MouseHover(object sender, EventArgs e)
        {
            pnlMenuPlayersGames.Visible = true;
        }

        private void PnlMenuPlayersGames_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlMenuPlayersGames.ClientRectangle.Contains(btnMenuRankingPlayers.PointToClient(Control.MousePosition))
                && !pnlMenuPlayersGames.ClientRectangle.Contains(btnMenuRankingGames.PointToClient(Control.MousePosition)))
            {
                pnlMenuPlayersGames.Hide();
            }
        }

        private void BtnPrintMatches_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm(dgviewPlayers);

            printForm.Show();
            printForm.BringToFront();
        }

    }
}
