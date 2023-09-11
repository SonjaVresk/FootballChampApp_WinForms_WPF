using NogometWPF.Windows;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NogometWPF.UserControls
{
    /// <summary>
    /// Interaction logic for TeamDetails.xaml
    /// </summary>
    public partial class TeamDetails : UserControl
    {
        private const string pathFemaleTeams = "https://worldcup-vua.nullbit.hr/women/teams/results";
        private const string pathMaleTeams = "https://worldcup-vua.nullbit.hr/men/teams/results";
        private string filePath = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//chooseChampAndLang.txt";
        private string selectedTeamPath = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//selectedTeam.txt";
        private string pathRead;
        private string _code;
        private string _gender;

        public TeamDetails(string code, string gender)
        {
            InitializeComponent();

            _code = code;
            _gender = gender;

            GetDataAsync(_code, _gender);

        }

        private async void GetDataAsync(string code, string gender)
        {
            IRepository repository = RepositoryFactory.GetRepository();
            

            if (gender == "women")
            {
                pathRead = pathFemaleTeams;
            }
            else if (gender == "men")
            {
                pathRead = pathMaleTeams;
            }

            var results = await repository.GetDataAPI<Results>(pathRead);

            foreach (var result in results)
            {
                if (result.FifaCode == code)
                {
                    lblTeamName.Content = result.Country;
                    lblTeamFifaCode.Content = result.FifaCode;
                    lblPlayedMatches.Content = result.GamesPlayed;
                    lblMatchesWon.Content = result.Wins;
                    lblMatchesLost.Content = result.Losses;
                    lblMatchesEq.Content = result.Draws;
                    lblGoalsP.Content = result.GoalsFor;
                    lblGoalsG.Content = result.GoalsAgainst;
                    lblGoalsD.Content = result.GoalDifferential;
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
