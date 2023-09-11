using NogometWPF.Windows;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
  
    public partial class SettingsWinUC : UserControl
    {

        private const string pathChooseChamp = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//chooseChampAndLang.txt";
        private const string pathWindowSize = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//windowSize.txt";
        private string cro = "croatian";
        private string eng = "english";
        private string women = "women";
        private string men = "men";
        private const string HR = "hr", EN = "en";
        private static double width;
        private static double height;
        IRepository repository = RepositoryFactory.GetRepository();



        public SettingsWinUC()
        {
            InitializeComponent();           


            //Provjera je li već odabran jezik i prvenstvo

            if (File.Exists(pathChooseChamp))
            {
                string champ = repository.ReadFromFile(pathChooseChamp)[0];
                string lang = repository.ReadFromFile(pathChooseChamp)[1];


                if (champ == women && lang == cro)
                {
                    rbtnFemale.IsChecked = true;
                    rbtnCro.IsChecked = true;
                }
                else if (champ == women && lang == eng)
                {
                    rbtnFemale.IsChecked = true;
                    rbtnEng.IsChecked = true;
                }
                else if (champ == men && lang == cro)
                {
                    rbtnMale.IsChecked = true;
                    rbtnCro.IsChecked = true;
                }
                else if (champ == men && lang == eng)
                {
                    rbtnMale.IsChecked = true;
                    rbtnEng.IsChecked = true;
                }
            }
        }
       
        private void btSave_Click(object sender, RoutedEventArgs e)
        {
  
            MessageBoxResult result = MessageBox.Show("Jeste li sigurni da želite spremiti promjene?");

            if (result == MessageBoxResult.OK)
            {
                List<string> champLang = new List<string>();

                //provjera ima li radio button vrijednosti i je li označen
                if (rbtnFemale.IsChecked.HasValue && rbtnFemale.IsChecked.Value && rbtnCro.IsChecked.HasValue && rbtnCro.IsChecked.Value)
                {
                    champLang.Add(women);
                    champLang.Add(cro);
                }
                else if (rbtnMale.IsChecked.HasValue && rbtnMale.IsChecked.Value && rbtnCro.IsChecked.HasValue && rbtnCro.IsChecked.Value)
                {
                    champLang.Add(men);
                    champLang.Add(cro);
                }
                else if (rbtnFemale.IsChecked.HasValue && rbtnFemale.IsChecked.Value && rbtnEng.IsChecked.HasValue && rbtnEng.IsChecked.Value)
                {
                    champLang.Add(women);
                    champLang.Add(eng);
                }
                else if (rbtnMale.IsChecked.HasValue && rbtnMale.IsChecked.Value && rbtnEng.IsChecked.HasValue && rbtnEng.IsChecked.Value)
                {
                    champLang.Add(men);
                    champLang.Add(eng);
                }

                else
                {
                    MessageBox.Show("Odaberite jezik i prvenstvo!");
                }

                if (rbtnCro.IsChecked.HasValue && rbtnCro.IsChecked.Value)
                {
                    SetCulture(HR);
                }
                else if (rbtnEng.IsChecked.HasValue && rbtnEng.IsChecked.Value)
                {
                    SetCulture(EN);
                }

                repository.WriteToFile(pathChooseChamp, champLang);

                SetWindowSize();

                this.Visibility = Visibility.Collapsed;


                Window parentWindow = Window.GetWindow(this);

                if (parentWindow != null)
                {
                    parentWindow.Hide();
                }

                SelectTeamWindow selectTeamWindow = new SelectTeamWindow();
                selectTeamWindow.Show();

            }
            else
            {
                this.Visibility= Visibility.Collapsed;
            }
        }

        private void SetWindowSize()
        {            

            if (rbSize1.IsChecked == true)
            {
                width = 700;
                height = 700;
            }
            else if (rbSize2.IsChecked == true)
            {
                width = 1000;
                height = 750;
            }
            else if (rbSize3.IsChecked == true)
            {
                width = 1450;
                height = 800;
            }
            else
            {
                return;
            }

            this.Width = width;
            this.Height = height;

            List<string> size = new List<string>()
            {
                this.Width.ToString(),
                this.Height.ToString()
            };

            repository.WriteToFile(pathWindowSize, size);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility=Visibility.Collapsed;
        }

        private void SetCulture(string lang)
        {
            CultureInfo culture = new(lang);
            Thread.CurrentThread.CurrentUICulture = culture;
        }
        
    }
}
