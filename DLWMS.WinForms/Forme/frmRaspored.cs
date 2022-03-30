using DLWMS.WinForms;
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
    public partial class frmRaspored : Form
    {
        private Student prijavljeniStudent;
        public frmRaspored()
        {
            InitializeComponent();
        }

        public frmRaspored(Student prijavljeniStudent):this()
        {
            this.prijavljeniStudent = prijavljeniStudent;
        }

        private void frmRaspored_Load(object sender, EventArgs e)
        {
            this.Text = $"Raspored - {prijavljeniStudent.GodinaStudija} godina.";
            UcitajRaspored();
        }

        private void UcitajRaspored()
        {
            pbRaspored.Image = ImageHelper.FromByteToImage(prijavljeniStudent.GodinaStudija.Raspored);
        }
    }
}
