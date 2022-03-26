using DLWMS.WinForms;
using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp.WinForms.Forme
{
    public partial class frmPromjenaLozinke : Form
    {
        private Student prijavljeniStudent;
        KonekcijaNaBazu baza = StudentsDB.Baza;

        public frmPromjenaLozinke()
        {
            InitializeComponent();
        }

        public frmPromjenaLozinke(Student prijavljeniStudent):this()
        {
            this.prijavljeniStudent = prijavljeniStudent;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                prijavljeniStudent.Lozinka = txtNovaLozinka.Text;
                baza.Entry(prijavljeniStudent).State = EntityState.Modified;
                baza.SaveChanges();
                MessageBox.Show("Uspješno spašeno");
                this.Close();
            }
            else
                MessageBox.Show("Greška!","Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtTrenutnaLozinka, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtNovaLozinka, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtNovaLozinkaPotvrda, errorProvider1, Poruke.ObaveznaVrijednost)
                && txtTrenutnaLozinka.Text == prijavljeniStudent.Lozinka
                && txtNovaLozinka.Text == txtNovaLozinkaPotvrda.Text;
        }
    }
}
