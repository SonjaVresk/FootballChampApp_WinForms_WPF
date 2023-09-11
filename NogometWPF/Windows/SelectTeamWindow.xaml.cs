using NogometWPF.UserControls;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace NogometWPF.Windows
{
    public partial class SelectTeamWindow : Window
    {
        private const string pathFemaleTeams = "https://worldcup-vua.nullbit.hr/women/teams";
        private const string pathMaleTeams = "https://worldcup-vua.nullbit.hr/men/teams";
        private string filePath = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//chooseChampAndLang.txt";
        private string selectedTeamPath = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//selectedTeam.txt";
        private const string pathWindowSize = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//windowSize.txt";
        private string pathRead;
        private string _gender;
        IRepository repository = RepositoryFactory.GetRepository();

        public SelectTeamWindow()
        {
            SetWindowSize();
            InitializeComponent();
            
            Loaded += SelectTeamWin_Loaded; 
        }


        private void SetWindowSize()
        {
            List<string> size = repository.ReadFromFile(pathWindowSize);
            if (size == null )
            {
                return;
            }
            else
            {
                Width = double.Parse(size[0]);
                Height = double.Parse(size[1]);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            List<string> codes = new List<string>();

            if (cboxFirstTeam.SelectedItem == null)
            {
                MessageBox.Show("Odaberite reprezentaciju");
                return;
            }
            else
            {
                //čitanje fifa koda odabrane države: 
                string selectedString = cboxFirstTeam.SelectedItem.ToString();
                string code = selectedString.Split(' ').Last();
                codes.Add(code);
                repository.WriteToFile(selectedTeamPath, codes);

                SelectOppositTeamWindow selectOppositTeamWindow = new SelectOppositTeamWindow(code, _gender);
                selectOppositTeamWindow.Show();
                this.Hide();
            }
        }


        private async void SelectTeamWin_Loaded(object sender, RoutedEventArgs e)
        {
            //Provjera koje prvenstvo je odabrano

            List<string> list = repository.ReadFromFile(filePath);
            _gender = list[0];

            if (_gender == "women")
            {
                pathRead = pathFemaleTeams;
            }
            else if (_gender == "men")
            {
                pathRead = pathMaleTeams;
            }

            try
            {

                //Učitavanje reprezentacija u combobox
                var data = await repository.GetDataAPI<Teams>(pathRead);

                var countries = data.Select(d => d.ToString());

                cboxFirstTeam.Items.Clear();

                foreach (string country in countries)
                {
                    cboxFirstTeam.Items.Add(country);
                    //cboxFirstTeam.SelectedIndex = 0;
                }


            //Čitanje iz file- a već odabrane reprezentacije - ako nema zapisane u fajlu - prazan string, ako ima učita naziv reprezentacije
            var team = repository.ReadFromFile(selectedTeamPath);
            if (team[0] == null)
            {
                cboxFirstTeam.SelectedValue = " ";
            }
            else
            {
                foreach (var d in data)
                {
                    if (team[0] == d.FifaCode)
                    {
                        cboxFirstTeam.SelectedValue = d.ToString();
                    }
                }
            }            
            }
            catch (Exception)
            {

                MessageBox.Show("Greška u dohvaćanju podataka");
            }
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {            
            SettingsWinUC settingsWinUC = new SettingsWinUC();
            gSelectTeam.Children.Add(settingsWinUC);
        }

        private void SelectTeamWin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Jeste li sigurni da želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
