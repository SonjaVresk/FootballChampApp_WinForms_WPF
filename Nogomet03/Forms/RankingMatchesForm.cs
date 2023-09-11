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
    public partial class RankingMatchesForm : Form
    {
        private string path1 = "https://worldcup-vua.nullbit.hr/";
        private string path2 = "/matches/country?fifa_code=";
        private string _code;
        private string _gender;

        public RankingMatchesForm(string code, string gender)
        {
            InitializeComponent();

            _code = code;
            _gender = gender;

            GetMatchAsync();

        }

        private async Task GetMatchAsync()
        {
            lblLoading.Visible = true;

            List<Match> matchList = new List<Match>();

            IRepository repository = RepositoryFactory.GetRepository();

            var matches = await repository.GetDataAPI<Matches>(path1 + _gender + path2 + _code);

            foreach (var m in matches)
            {
                Match match = new Match(m.Location, m.Attendance, m.HomeTeam.Country, m.AwayTeam.Country);

                matchList.Add(match);

                matchList.Sort(new MatchesComparer());
            }

            dgviewMatches.DataSource = matchList;

            lblLoading.Visible = false;
        }

        private void BtnSettings3_Click(object sender, EventArgs e)
        {
            SelectChampLanguageUC selectChampLanguageUC = new SelectChampLanguageUC();
            selectChampLanguageUC.Location = new Point((this.ClientSize.Width - selectChampLanguageUC.Width) / 2, (this.ClientSize.Height - selectChampLanguageUC.Height) / 2);
            this.Controls.Add(selectChampLanguageUC);
            selectChampLanguageUC.BringToFront();
        }

        private void BtnMenuPlayers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select3PlayersForm select3PlayersForm = new Select3PlayersForm(_code, _gender);
            select3PlayersForm.Show();
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
            PrintForm printForm = new PrintForm(dgviewMatches);

            printForm.Show();
            printForm.BringToFront();
        }
    }
}
