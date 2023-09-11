using Nogomet03.Forms;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nogomet03.UserControls
{
    public partial class SelectChampLanguageUC : UserControl
    {
        private const string pathChooseChamp = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//chooseChampAndLang.txt";
        private string cro = "croatian";
        private string eng = "english";
        private string women = "women";
        private string men = "men";
        private const string HR = "hr", EN = "en";
        IRepository repository = RepositoryFactory.GetRepository();

        public SelectChampLanguageUC()
        {
            InitializeComponent();
        }

        private void SelectChampLanguageUC_Load(object sender, EventArgs e)
        {            
            //očitavanje već odabranih postavki:

            if (File.Exists(pathChooseChamp))
            {
                string champ = repository.ReadFromFile(pathChooseChamp)[0];
                string lang = repository.ReadFromFile(pathChooseChamp)[1];

                if (champ == women && lang == cro)
                {
                    rbtnFemale.Checked = true;
                    rbtnCro.Checked = true;
                }
                else if (champ == women && lang == eng)
                {
                    rbtnFemale.Checked = true;
                    rbtnEng.Checked = true;
                }
                else if (champ == men && lang == cro)
                {
                    rbtnMale.Checked = true;
                    rbtnCro.Checked = true;
                }
                else if (champ == men && lang == eng)
                {
                    rbtnMale.Checked = true;
                    rbtnEng.Checked = true;
                }
            }
            else
            {                
                return;
            }
        }

        private void BtnSaveChampLang_Click(object sender, EventArgs e)
        {            
            List<string> champLang = new List<string>();

            try
            {
                //Odabir novih postavki:

                if (rbtnFemale.Checked && rbtnCro.Checked)
                {
                    champLang.Add(women);
                    champLang.Add(cro);
                }

                else if (rbtnMale.Checked && rbtnCro.Checked)
                {
                    champLang.Add(men);
                    champLang.Add(cro);
                }

                else if (rbtnFemale.Checked && rbtnEng.Checked)
                {
                    champLang.Add(women);
                    champLang.Add(eng);
                }

                else if (rbtnMale.Checked && rbtnEng.Checked)
                {
                    champLang.Add(men);
                    champLang.Add(eng);
                }
                repository.WriteToFile(pathChooseChamp, champLang);
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u spremanju postavki.");
                return;
            }

            if (rbtnCro.Checked)
            {
                SetCulture(HR);
            }
            else if (rbtnEng.Checked)
            {
                SetCulture(EN);
            }
                        
            this.Hide();
            this.Parent.Hide();
            SelectTeamForm selectTeamForm = new SelectTeamForm();
            selectTeamForm.Show();
        }

        private void SetCulture(string lang)
        {
            CultureInfo culture = new(lang);
            Thread.CurrentThread.CurrentUICulture = culture;
            this.Controls.Clear();
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

