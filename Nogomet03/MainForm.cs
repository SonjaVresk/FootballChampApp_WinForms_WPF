using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using Nogomet03.Forms;
using Nogomet03.UserControls;
using Repository;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.IO;

namespace Nogomet03
{
    public partial class MainForm : Form
    {
        private const string pathChooseChamp = "..//..//..//..//..//NogometnoPrvenstvo//Repository//Files//chooseChampAndLang.txt";
        private string cro = "croatian";
        private string eng = "english";
        private string women = "women";
        private string men = "men";
        private const string HR = "hr", EN = "en";
        IRepository repository = RepositoryFactory.GetRepository();

        public MainForm()
        {
            CheckLanguage();

            InitializeComponent();
        }

        private void CheckLanguage()
        {
            //Provjera ima li veæ odabran jezik

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

                else
                {
                    SetCulture(HR);
                }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {

            //Provjera je li veæ odabran jezik i prvenstvo

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

                if (lang == eng)
                {
                    SetCulture(EN);
                }
                else
                {
                    SetCulture(HR);
                }

                btnEnter.Visible = false;
                pnlSelectChampLang.Visible = true;
                btnSaveChampLangFirst.Visible = true;
            }
            else
            {
                btnEnter.Visible = false;
                pnlSelectChampLang.Visible = true;
                btnSaveChampLangFirst.Visible = true;
            }
        }

        private void BtnSaveChampLangFirst_Click(object sender, EventArgs e)
        {

            List<string> champLang = new List<string>();

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


            else
            {
                MessageBox.Show("Odaberite jezik i prvenstvo!");
            }

            if (rbtnCro.Checked)
            {
                SetCulture(HR);
            }
            else if (rbtnEng.Checked)
            {
                SetCulture(EN);
            }

            if ((rbtnFemale.Checked || rbtnMale.Checked) && (rbtnCro.Checked || rbtnEng.Checked))
            {
                try
                {
                    repository.WriteToFile(pathChooseChamp, champLang);
                }
                catch (Exception)
                {
                    return;
                }

                this.Hide();
                SelectTeamForm selectTeamForm = new SelectTeamForm();
                selectTeamForm.Show();
            }
        }

        private void SetCulture(string lang)
        {
            CultureInfo culture = new(lang);
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}