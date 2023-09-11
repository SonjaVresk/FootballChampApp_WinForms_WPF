using NogometWPF.Windows;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NogometWPF.UserControls
{
    
    public partial class PlayerUC : UserControl
    {

        private string pathImage = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Images//";
        private string pathRead;
        private string path1 = "https://worldcup-vua.nullbit.hr/";
        private string path2 = "/matches/country?fifa_code=";
        private string _code;
        private string _oppCode;
        private string _gender;

        IRepository repository = RepositoryFactory.GetRepository();

        public System.Windows.Controls.Label lblPlayerNameInstance;
        public System.Windows.Controls.Label lblPlayerNumbInstance;
        public Image imgPlayerInstance;


        public PlayerUC(string code, string oppCode, string gender)
        {
            InitializeComponent();

            

            _code = code;
            _oppCode = oppCode;
            _gender = gender;

            lblPlayerNameInstance = lblPlayerName;
            lblPlayerNumbInstance = lblPlayerNumber;
            imgPlayerInstance = imgPlayer;           

        }

        private async void AllPlayersUC_MouseDownAsync(object sender, MouseButtonEventArgs e)
        {
            //Animacija: 

            SetAnimation();


            //Detalji o igraču:

            var matches = await repository.GetDataAPI<Matches>(path1 + _gender + path2 + _code);
            List<StartingEleven> players = new List<StartingEleven>();
            List<TeamEvent> events = new List<TeamEvent>();
            List<StartingEleven> playersList = new List<StartingEleven>();

            foreach (var match in matches)
            {
                if (match.HomeTeam.Code == _code && match.AwayTeam.Code == _oppCode)
                {
                    playersList.AddRange(match.HomeTeamStatistics.StartingEleven);
                    events.AddRange(match.HomeTeamEvents);
                }
                else if (match.AwayTeam.Code == _code && match.HomeTeam.Code == _oppCode)
                {
                    playersList.AddRange(match.AwayTeamStatistics.StartingEleven);
                    events.AddRange(match.AwayTeamEvents);
                }

                if (match.HomeTeam.Code == _oppCode && match.AwayTeam.Code == _code)
                {
                    playersList.AddRange(match.HomeTeamStatistics.StartingEleven);
                    events.AddRange(match.HomeTeamEvents);

                }
                else if (match.AwayTeam.Code == _oppCode && match.HomeTeam.Code == _code)
                {
                    playersList.AddRange(match.AwayTeamStatistics.StartingEleven);
                    events.AddRange(match.AwayTeamEvents);
                }
            }

            //Golovi i žuti kartoni

            foreach (var p in playersList)
            {
                int goals = 0;
                int yellowcards = 0;

                foreach (var t in events)
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


                //Podataci o igraču

                PlayerDetails playerDetails = new PlayerDetails();

                if (p.Name == lblPlayerName.Content.ToString())
                {
                    playerDetails.lblPNameInstance.Content = p.Name;
                    playerDetails.lblPNumbersInstance.Content = p.ShirtNumber;
                    playerDetails.lblPPositionInstance.Content = p.Position;
                    playerDetails.lblPGoalsInstance.Content = goals.ToString();
                    playerDetails.lblPYellowCards.Content = yellowcards.ToString();

                    if (p.Captain == true)
                    {
                        playerDetails.imgCaptain.Visibility = Visibility.Visible;
                    }


                    try
                    {
                        PlayerUC playerUC = new PlayerUC(_code, _oppCode, _gender);

                        if (File.Exists($"..\\NogometnoPrvenstvo\\Repository\\Images\\{playerDetails.lblPNameInstance.Content}.jpg"))
                        {
                            playerDetails.imgPPicInstance.Source = new BitmapImage(new Uri(@"..\\NogometnoPrvenstvo\Repository\Images\" + playerDetails.lblPNameInstance.Content + ".jpg", UriKind.RelativeOrAbsolute));

                        }
                    }
                    catch (Exception)
                    {

                        return;
                    }

                    playerDetails.Show();
                }
            }
        }

        private void SetAnimation()
        {
            var storyboard = new Storyboard();
            storyboard.Duration = TimeSpan.FromSeconds(0.3);
            var opacityAnimation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.3));
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath("Opacity"));
            Storyboard.SetTarget(opacityAnimation, this);

            storyboard.Children.Add(opacityAnimation);
            storyboard.Begin();
        }
    }
}
