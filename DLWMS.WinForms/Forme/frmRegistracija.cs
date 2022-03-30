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
    public partial class frmRegistracija : Form
    {
        KonekcijaNaBazu baza = StudentsDB.Baza;
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if(Validiraj())
            {
                if(ProvjeriLozinke())
                {
                    var noviStudent = new Student()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Indeks = txtIndeks.Text,
                        Email = txtEmail.Text,
                        GodinaStudija = cmbGodineStudija.SelectedItem as GodineStudija,
                        Slika = ImageHelper.FromImageToByte(pbSlika.Image),
                        DatumRodjenja = dtpDatumRodjenja.Value,
                        Lozinka = txtLozinka.Text,
                        Aktivan = cbAktivnost.Checked,
                        Spol = cmbSpol.SelectedItem as Spolovi,
                        Smjer = cmbSmjerovi.SelectedItem as Smjerovi,
                    };
                    baza.Studenti.Add(noviStudent);
                    baza.SaveChanges();
                    MessageBox.Show("Uspješno registrovan novi student!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Lozinke nisu iste!");
            }
        }

        private void GenerisiEmail()
        {
            txtEmail.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}@edu.fit.ba";
        }

        private string GenerisiIndeks()
        {
            return $"IB{((DateTime.Now.Year - 2000) * 10000) + baza.Studenti.Count() + 1}";
        }

        private bool ProvjeriLozinke()
        {
            return txtLozinka.Text == txtLozinkaPotvrda.Text;
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtIme, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbGodineStudija, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbSmjerovi, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinka, errorProvider1, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinkaPotvrda, errorProvider1, Poruke.ObaveznaVrijednost);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            txtIndeks.Text = GenerisiIndeks();
            UcitajGodineStudija();
            UcitajSmjerove();
            UcitajSpolove();
        }

        private void UcitajSpolove()
        {
            cmbSpol.DataSource = baza.Spolovi.ToList();
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }

        private void UcitajSmjerove()
        {
            cmbSmjerovi.DataSource = baza.Smjerovi.ToList();
            cmbSmjerovi.DisplayMember = "Naziv";
            cmbSmjerovi.ValueMember = "Id";
        }

        private void UcitajGodineStudija()
        {
            cmbGodineStudija.DataSource = baza.GodineStudija.ToList();
            cmbGodineStudija.DisplayMember = "Opis";
            cmbGodineStudija.ValueMember = "Id";
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
