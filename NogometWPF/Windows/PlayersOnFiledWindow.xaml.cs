using NogometWPF.UserControls;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NogometWPF.Windows
{   
    public partial class PlayersOnFiledWindow : Window
    {
        private const string pathWindowSize = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//windowSize.txt";
        private string path1 = "https://worldcup-vua.nullbit.hr/";
        private string path2 = "/matches/country?fifa_code=";
        private string _code;
        private string _oppCode;
        private string _gender;

        IRepository repository = RepositoryFactory.GetRepository();

        public PlayersOnFiledWindow(string code, string oppCode, string gender)
        {
            _code = code;
            _oppCode = oppCode;
            _gender = gender;
           
            InitializeComponent();

            SetWindowSize();

            ShowPlayersOnFieldAsync();

            lblCode.Content = _code;
            lblOppCode.Content = _oppCode;            
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

        private async void ShowPlayersOnFieldAsync()
        {
            List<StartingEleven> team = new List<StartingEleven>();
            List<StartingEleven> oppTeam = new List<StartingEleven>();

            var data = await repository.GetDataAPI<Matches>(path1 + _gender + path2 + _code);

            foreach (var d in data)
            {
                if (d.HomeTeam.Code == _code && d.AwayTeam.Code == _oppCode)
                {
                    team = d.HomeTeamStatistics.StartingEleven;
                }
                else if(d.AwayTeam.Code == _code && d.HomeTeam.Code == _oppCode)
                {
                    team = d.AwayTeamStatistics.StartingEleven;
                }
            
                if (d.HomeTeam.Code == _oppCode)
                {
                    oppTeam = d.HomeTeamStatistics.StartingEleven;

                }
                else if (d.AwayTeam.Code == _oppCode)
                {
                    oppTeam = d.AwayTeamStatistics.StartingEleven;
                }
            }

            foreach (var player in team)
            {
                PlayerUC playerUC = new PlayerUC(_code, _oppCode, _gender);

                playerUC.lblPlayerNameInstance.Content = player.Name;
                playerUC.lblPlayerNumbInstance.Content = player.ShirtNumber.ToString();

                //Postavljanje slike: 

                try
                {
                    if (File.Exists($"..\\NogometnoPrvenstvo\\Repository\\Images\\{playerUC.lblPlayerNameInstance.Content}.jpg"))
                    {
                        playerUC.imgPlayerInstance.Source = new BitmapImage(new Uri(@"..\NogometnoPrvenstvo\Repository\Images\" + playerUC.lblPlayerNameInstance.Content + ".jpg", UriKind.RelativeOrAbsolute));
                    }
                }
                catch (Exception)
                {
                    return;
                }

                if (player.Position == "Goalie")
                {
                    pnlGoalie.Children.Add(playerUC);
                }
                if (player.Position == "Defender")
                {
                    pnlDefender.Children.Add(playerUC);
                }
                if (player.Position == "Midfield")
                {
                    pnlMidfield.Children.Add(playerUC);
                }
                if (player.Position == "Forward")
                {
                    pnlForward.Children.Add(playerUC);
                }
            }

            foreach (var p in oppTeam)
            {
                PlayerUC playerUC = new PlayerUC(_code, _oppCode, _gender);

                playerUC.lblPlayerNameInstance.Content = p.Name;
                playerUC.lblPlayerNumbInstance.Content = p.ShirtNumber.ToString();

                if (p.Position == "Goalie")
                {
                    pnlGoalieOp.Children.Add(playerUC);
                }
                if (p.Position == "Defender")
                {
                    pnlDefenderOp.Children.Add(playerUC);
                }
                if (p.Position == "Midfield")
                {
                    pnlMidfieldOp.Children.Add(playerUC);
                }
                if (p.Position == "Forward")
                {
                    pnlForwardOp.Children.Add(playerUC);
                }

                //Postavljanje slike: 

                try
                {
                    if (File.Exists($"\\NogometnoPrvenstvo\\Repository\\Images\\{playerUC.lblPlayerNameInstance.Content}.jpg"))
                    {
                        playerUC.imgPlayerInstance.Source = new BitmapImage(new Uri(@"..\NogometnoPrvenstvo\Repository\Images\" + playerUC.lblPlayerNameInstance.Content + ".jpg", UriKind.RelativeOrAbsolute));
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            SelectOppositTeamWindow selectOppositTeamWindow = new SelectOppositTeamWindow(_code, _gender);
            selectOppositTeamWindow.Show();
            this.Hide();
        }

        private void PlayersOnFielddWin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Jeste li sigurni da želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
