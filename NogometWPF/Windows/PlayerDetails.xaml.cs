using Repository.Models;
using System;
using System.Collections.Generic;
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

    public partial class PlayerDetails : Window
    {

        public Label lblPNameInstance;
        public Label lblPNumbersInstance;
        public Label lblPPositionInstance;
        public Label lblPGoalsInstance;
        public Label lblPYellowCardsInstance;
        public Image imgCaptainInstance;
        public Image imgPPicInstance;


        public PlayerDetails()
        {
            InitializeComponent();


            lblPNameInstance = lblPName;
            lblPNumbersInstance = lblPNumber;
            lblPPositionInstance = lblPPosition;
            lblPGoalsInstance = lblPGoals;
            lblPYellowCardsInstance = lblPYellowCards;
            imgCaptainInstance = imgCaptain;
            imgPPicInstance = imgPPic;            

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
