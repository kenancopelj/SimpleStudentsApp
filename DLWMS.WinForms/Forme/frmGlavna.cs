using DLWMS.WinForms;
using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
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

        public frmGlavna()
        {
            InitializeComponent();
        }

        public frmGlavna(Student prijavljeniStudent):this()
        {
            this.prijavljeniStudent = prijavljeniStudent;
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            lblDobrodosli.Text = $"Dobrodošli, {prijavljeniStudent}!";
            pbSlikaKorisnika.Image = ImageHelper.FromByteToImage(prijavljeniStudent.Slika);
            UcitajProsjeke();
        }

        private void UcitajProsjeke()
        {
            //TODO
            progressBar1.Minimum = 6;
            progressBar1.Maximum = 10;
            progressBar1.Value = 7;
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
    }
}
