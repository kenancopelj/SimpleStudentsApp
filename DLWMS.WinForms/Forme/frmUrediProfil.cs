using DLWMS.WinForms;
using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;
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
    public partial class frmUrediProfil : Form
    {
        private Student prijavljeniStudent;
        KonekcijaNaBazu baza = StudentsDB.Baza;

        public frmUrediProfil()
        {
            InitializeComponent();
        }

        public frmUrediProfil(Student prijavljeniStudent):this()
        {
            this.prijavljeniStudent = prijavljeniStudent;
        }

        private void frmUrediProfil_Load(object sender, EventArgs e)
        {
            UcitajPodatke(prijavljeniStudent);
        }

        private void UcitajPodatke(Student prijavljeniStudent)
        {
            txtImePrezime.Text = $"{prijavljeniStudent.Ime} {prijavljeniStudent.Prezime}";
            txtIndeks.Text = $"{prijavljeniStudent.Indeks}";
            txtEmail.Text = $"{prijavljeniStudent.Email}";
            txtDatumRodjenja.Text = $"{prijavljeniStudent.DatumRodjenja}";
            txtLozinka.Text = $"{prijavljeniStudent.Lozinka}";
            pbSlika.Image = ImageHelper.FromByteToImage(prijavljeniStudent.Slika);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?","Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                baza.SaveChanges();
                UcitajPodatke(prijavljeniStudent);
                MessageBox.Show("Podaci uspješno spašeni!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtEmail, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinka, errorProvider1, Poruke.ObaveznaVrijednost);
        }

        private void btnPromijeniSliku_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmPromjenaLozinke(prijavljeniStudent).ShowDialog();
        }
    }
}
