using DLWMS.WinForms;
using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;
using StudentsApp.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp.WinForms.Forme
{
    public partial class frmGlavna : Form
    {
        private Student prijavljeniStudent;
        KonekcijaNaBazu baza = StudentsDB.Baza;
        private List<string> Ocjene = new List<string>() {"", "6", "7", "8", "9", "10" };

        public frmGlavna()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        public frmGlavna(Student prijavljeniStudent):this()
        {
            this.prijavljeniStudent = prijavljeniStudent;
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            lblDobrodosli.Text = $"Dobrodošli, {prijavljeniStudent}!";
            pbSlikaKorisnika.Image = ImageHelper.FromByteToImage(prijavljeniStudent.Slika);
        }

        private void UcitajPodatke(List<StudentiPredmeti> podaci = null)
        {
            try
            {
                var rezultat = podaci ?? prijavljeniStudent.Uspjeh;
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = rezultat;
                RacunajProsjeke(rezultat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void RacunajProsjeke(List<StudentiPredmeti> rezultat)
        {
            var ukupanProsjek = Math.Round(rezultat.Average(x => (double?)x.Ocjena).GetValueOrDefault(), 2);
            lblUkupanProsjek.Text = $"Ukupan prosjek / {ukupanProsjek}";

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?","Odjava",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUrediProfil_Click(object sender, EventArgs e)
        {
            new frmUrediProfil(prijavljeniStudent).ShowDialog();
        }

        private void txtPretragaPoNazivu_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPretragaPoNazivu.Text))
            {
                var podaci = prijavljeniStudent.Uspjeh.Where(x => x.Predmet.Naziv.ToLower().Contains(txtPretragaPoNazivu.Text)).ToList();
                UcitajPodatke(podaci);
            }
            else
                UcitajPodatke();
        }
        private void btnPrikaziPredmete_Click(object sender, EventArgs e)
        {
            new frmPrikazPredmeta(prijavljeniStudent).ShowDialog();
        }

        private void btnRaspored_Click(object sender, EventArgs e)
        {
            new frmRaspored(prijavljeniStudent).ShowDialog();
        }
    }
}
