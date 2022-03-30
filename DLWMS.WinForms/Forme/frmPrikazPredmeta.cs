using DLWMS.WinForms;
using DLWMS.WinForms.DB;
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
    public partial class frmPrikazPredmeta : Form
    {
        private Student prijavljeniStudent;
        KonekcijaNaBazu baza = StudentsDB.Baza;

        public frmPrikazPredmeta()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }

        public frmPrikazPredmeta(Student prijavljeniStudent):this()
        {
            this.prijavljeniStudent = prijavljeniStudent;
        }

        private void frmPrikazPredmeta_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajPredmeteDB();
        }

        private void UcitajPredmeteDB()
        {
            cmbGodinaStudija.DataSource = baza.GodineStudija.ToList();
            cmbGodinaStudija.DisplayMember = "Id";
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                int odabranaGodina = int.Parse(cmbGodinaStudija.Text);
                var podaci = baza.Predmeti.ToList().Where(x => x.GodinaStudija.Id == odabranaGodina).ToList();
                UcitajPredmete(podaci);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private void UcitajPredmete(List<Predmet> predmeti = null)
        {
            try
            {
                var rezultat = predmeti ?? baza.Predmeti.ToList();
                dgvPredmeti.DataSource = null;
                dgvPredmeti.DataSource = rezultat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }
    }
}
