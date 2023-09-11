using Newtonsoft.Json;
using Nogomet03.UserControls;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nogomet03.Forms
{

    public partial class SelectTeamForm : Form
    {
        private const string pathFemaleTeams = "https://worldcup-vua.nullbit.hr/women/teams";
        private const string pathMaleTeams = "https://worldcup-vua.nullbit.hr/men/teams";
        private string filePath = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//chooseChampAndLang.txt";
        private string selectedTeam = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//selectedTeam.txt";
        private string pathRead;
        private string _gender;
        IRepository repository = RepositoryFactory.GetRepository();


        public SelectTeamForm()
        {
            InitializeComponent();
        }


        //Dohvaćanje reprezentacija
        private async void SelectTeamForm_LoadAsync(object sender, EventArgs e)
        {
            // Progress bar vidljiv
            progressBar.Visible = true;

            await GetTeamsAsync();
        }

        private async Task GetTeamsAsync()
        {
            //Animacija
            for (int i = 0; i <= 100; i += 10)
            {
                progressBar.Value = i;
                await Task.Delay(150);
            }


            //Provjera koje prvenstvo je odabrano
            try
            {
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

                var data = await repository.GetDataAPI<Teams>(pathRead);

                var countries = data.Select(d => d.ToString());

                cboxTeams.Items.Clear();
                foreach (string country in countries)
                {
                    cboxTeams.Items.Add(country);
                    cboxTeams.SelectedIndex = 0;
                }
                btnReload.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u dohvaćanju reprezentacija.");
                btnSelectTeamNext.Visible = false;
                btnReload.Visible = true;
            }
            progressBar.Visible = false;

        }

        private void BtnSelectTeamNext_Click(object sender, EventArgs e)
        {
            List<string> codes = new List<string>();

            if (cboxTeams.SelectedItem != null)
            {
                //čitanje fifa koda odabrane države: 
                string selectedString = cboxTeams.SelectedItem.ToString();
                string code = selectedString.Split(' ').Last();
                codes.Add(code);
                repository.WriteToFile(selectedTeam, codes);

                Select3PlayersForm select3PlayersForm = new Select3PlayersForm(code, _gender);
                this.Hide();
                btnSelectTeamNext.Visible = false;
                lblSelectTeam.Visible = false;
                cboxTeams.Visible = false;
                select3PlayersForm.Show();
            }
            else
            {
                return;
            }
        }

        //Postavke
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SelectChampLanguageUC selectChampLanguageUC = new SelectChampLanguageUC();
            selectChampLanguageUC.Location = new Point((this.ClientSize.Width - selectChampLanguageUC.Width) / 2, (this.ClientSize.Height - selectChampLanguageUC.Height) / 2);
            this.Controls.Add(selectChampLanguageUC);
            selectChampLanguageUC.BringToFront();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            GetTeamsAsync();
        }
    }
}
