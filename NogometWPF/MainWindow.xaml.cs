using NogometWPF.UserControls;
using NogometWPF.Windows;
using Repository;
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


namespace NogometWPF
{
    public partial class MainWindow : Window
    {
        private const string pathChooseChamp = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//chooseChampAndLang.txt";
        private const string pathWindowSize = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//windowSize.txt";
        private string cro = "croatian";
        private string eng = "english";
        private string women = "women";
        private string men = "men";
        private const string HR = "hr", EN = "en";
        private double width;
        private double height;
        IRepository repository = RepositoryFactory.GetRepository();

        public MainWindow()
        {
            //Provjera ima li već odabran jezik

            GetLanguage();

            InitializeComponent();

            WindowState = WindowState.Maximized;
        }        

        private void MainWin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Jeste li sigurni da želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MainWin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                e.Handled = true;
                MessageBoxResult result = MessageBox.Show("Jeste li sigurni da želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {
                    return;
                }
            }
        }
        private void GetLanguage()
        {
            try
            {
                string language;

                if (File.Exists(pathChooseChamp))
                {
                    language = repository.ReadFromFile(pathChooseChamp)[1];

                    if (language == null)
                    {
                        return;
                    }
                    else if (language == cro)
                    {
                        SetCulture(HR);
                    }
                    else
                    {
                        SetCulture(EN);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void SetCulture(string lang)
        {
            CultureInfo culture = new(lang);
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
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

            SetWindowSize();

            if ((rbtnFemale.IsChecked.HasValue && rbtnFemale.IsChecked.Value || rbtnMale.IsChecked.HasValue && rbtnMale.IsChecked.Value) && (rbtnCro.IsChecked.HasValue && rbtnCro.IsChecked.Value || rbtnEng.IsChecked.HasValue && rbtnEng.IsChecked.Value))
            {
                try
                { repository.WriteToFile(pathChooseChamp, champLang); }

                catch (Exception) 
                { MessageBox.Show("Greška kod zapisivanja u datoteku!"); }


                SelectTeamWindow selectTeamWindow = new SelectTeamWindow();
                selectTeamWindow.Show();
                this.Hide();
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
                this.WindowState = WindowState.Maximized;

                //očitavanje stvarne veličine ekrana:
                width = this.ActualWidth;
                height = this.ActualHeight;
            }

            // Set the window size
            this.Width = width;
            this.Height = height;


            List<string> size = new List<string>()
            {
                this.Width.ToString(),
                this.Height.ToString()
            };

            try
            { repository.WriteToFile(pathWindowSize, size); }

            catch (Exception)
            { MessageBox.Show("Greška kod zapisivanja u datoteku!"); }            
        }

        private void MainWin_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
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

                    if (lang == eng)
                    {
                        SetCulture(EN);
                    }
                    else
                    {
                        SetCulture(HR);
                    }

                }

                btEnter.Visibility = Visibility.Collapsed;
                gSelectChampLang.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    
    }
}
