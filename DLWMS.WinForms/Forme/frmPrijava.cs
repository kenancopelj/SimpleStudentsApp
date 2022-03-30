using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;
using StudentsApp.WinForms.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmPrijava : Form
    {
        KonekcijaNaBazu baza = StudentsDB.Baza;
        private Student PrijavljeniStudent;
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if(Validiraj())
            {
                if (Potrazi(txtBrojIndeksa.Text, txtLozinka.Text))
                {
                    new frmGlavna(PrijavljeniStudent).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Pogrešan/na broj indeksa/lozinka!");
                    txtBrojIndeksa.Clear();
                    txtLozinka.Clear();
                }
            }
        }

        private bool Potrazi(string indeks, string lozinka)
        {
            foreach (var student in baza.Studenti.ToList())
            {
                if (student.Indeks.ToLower().Contains(txtBrojIndeksa.Text) && student.Lozinka == lozinka)
                {
                    PrijavljeniStudent = student;
                    return true;
                }
            }
            return false;
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBrojIndeksa, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinka, err, Poruke.ObaveznaVrijednost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmRegistracija().ShowDialog();
        }
    }
}
