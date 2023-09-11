using NogometWPF.UserControls;
using Repository;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace NogometWPF.Windows
{
    public partial class SelectOppositTeamWindow : Window
    {      
        private const string pathFemaleTeams = "https://worldcup-vua.nullbit.hr/women/teams";
        private const string pathMaleTeams = "https://worldcup-vua.nullbit.hr/men/teams";
        private const string pathWindowSize = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//windowSize.txt";
        private string pathRead;
        private string path1 = "https://worldcup-vua.nullbit.hr/";
        private string path2 = "/matches/country?fifa_code=";
        private string _code;
        private string _oppCode;
        private string _gender;
                
        IRepository repository = RepositoryFactory.GetRepository();

        public SelectOppositTeamWindow(string code, string gender)
        {            
            InitializeComponent();

            SetWindowSize();

            _code = code;
            _gender = gender;

            if (gender == "women")
            {
                pathRead = pathFemaleTeams;
            }
            else if (gender == "men")
            {
                pathRead = pathMaleTeams;
            }

            LoadLabelAsync(_code, _gender);

            LoadCBoxAsync(_code, _gender);
        }

        private void SetWindowSize()
        {
            List<string> size = repository.ReadFromFile(pathWindowSize);

            if (size == null)
            {
                return;
            }
            else
            {
                Width = double.Parse(size[0]);
                Height = double.Parse(size[1]);
            }
        }

        private async void LoadCBoxAsync(string code, string gender)
        {
            List<Team> oppositTeams = new List<Team>();

            var matches = await repository.GetDataAPI<Matches>(path1+gender+path2+code);

            foreach (var match in matches)
            {
                if (match.HomeTeam.Code != code)
                {
                    oppositTeams.Add(match.HomeTeam);
                }
                else if(match.AwayTeam.Code != code)
                {
                    oppositTeams.Add(match.AwayTeam);
                }
            }

            foreach (var team in oppositTeams)
            {
                cboxSecondTeam.Items.Add(team.Country + " " + team.Code);                
            }
        }

        private async void LoadLabelAsync(string code, string gender)
        {
            var data = await repository.GetDataAPI<Teams>(pathRead);

            foreach (var d in data)
            {
                if (d.FifaCode == code)
                {
                    lblFirstTeam.Content = d.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cboxSecondTeam.SelectedItem == null)
            {
                MessageBox.Show("Odaberite protivnika!");
            }
            else
            {                
                PlayersOnFiledWindow playersOnFiledWindow = new PlayersOnFiledWindow(_code, _oppCode, _gender);
                playersOnFiledWindow.Show();
                this.Hide();
            }
        }

        private async void btnDetails1_ClickAsync(object sender, RoutedEventArgs e)
        {            
            progressBar.Visibility = Visibility.Visible;
                        
            await OpenTeamDetailsAsync(_code, _gender);
        }

        private async void btnDetails2_ClickAsync(object sender, RoutedEventArgs e)
        {
            
            string? selectedString = null;

            if (cboxSecondTeam.SelectedItem != null)
            {
                selectedString = cboxSecondTeam.SelectedItem.ToString();
            }

            if (selectedString != null)
            {
                string oppCode = selectedString.Split(' ').Last();

                // Progress bar vidljiv
                progressBar.Visibility = Visibility.Visible;

                // Metoda za učitavanje progess bara
                await OpenTeamDetailsAsync(oppCode, _gender);
            }
            else
            {
                MessageBox.Show("Odaberite protivničku reprezentaciju!");
            }
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWinUC settingsWinUC = new SettingsWinUC();
            gSelectOppositTeam.Children.Add(settingsWinUC);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SelectTeamWindow selectTeamWindow = new SelectTeamWindow();
            selectTeamWindow.Show();
        }

        private async void btnShowResult_ClickAsync(object sender, RoutedEventArgs e)
        {                        
            int? opponentGoals = 0;
            int? goals = 0;

            if (cboxSecondTeam.SelectedItem != null)
            {
                btnShowResult.Visibility = Visibility.Hidden;                

                string selectedString = cboxSecondTeam.SelectedItem.ToString();
                string opponentCode = selectedString.Split(' ').Last();               

                var matches = await repository.GetDataAPI<Matches>(path1 + _gender + path2 + _code);

                foreach (var m in matches)
                {
                    if (m.HomeTeam.Code == opponentCode && m.AwayTeam.Code == _code)
                    {
                        opponentGoals = m.HomeTeam.Goals ?? 0; //int će ostati nula ako nema vrijednosti                        
                    }
                    else if (m.AwayTeam.Code == opponentCode && m.HomeTeam.Code == _code)
                    {
                        opponentGoals = m.AwayTeam.Goals ?? 0;                        
                    }

                    if (m.HomeTeam.Code == _code && m.AwayTeam.Code == opponentCode)
                    {
                        goals = m.HomeTeam.Goals ?? 0;                        
                    }
                    else if (m.AwayTeam.Code == _code && m.HomeTeam.Code == opponentCode)
                    {
                        goals = m.AwayTeam.Goals ?? 0; 
                    }
                }                

                lblResult.Content = $"{goals.Value} : {opponentGoals.Value}";
            }
            else
            {
               MessageBox.Show("Odaberite protivnika!");
            }
        }

        private void cboxSecondTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnShowResult.Visibility = Visibility.Visible;
            lblResult.Content="";
            var selection = cboxSecondTeam.SelectedValue.ToString();
            _oppCode = selection.Split(' ').Last();
        }

        private async Task OpenTeamDetailsAsync(string code, string gender)
        {
            //odgoda otvaranja
            for (int i = 0; i <= 100; i += 10)
            {
                progressBar.Value = i;
                await Task.Delay(200);
            }
                        
            TeamDetails teamDetails = new TeamDetails(code, gender);
            gSelectOppositTeam.Children.Add(teamDetails);
                        
            progressBar.Visibility = Visibility.Collapsed;
        }

        private void SelectOppositTeamWin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Jeste li sigurni da želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
