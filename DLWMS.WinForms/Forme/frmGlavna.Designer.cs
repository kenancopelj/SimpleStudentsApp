
namespace StudentsApp.WinForms.Forme
{
    partial class frmGlavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavna));
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnUrediProfil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbSlikaKorisnika = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblProsjekPrveGodine = new System.Windows.Forms.Label();
            this.lblProsjekDrugeGodine = new System.Windows.Forms.Label();
            this.lblProsjekTreceGodine = new System.Windows.Forms.Label();
            this.lblUkupanProsjek = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.txtPretragaPoNazivu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaKorisnika)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(458, 64);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(273, 29);
            this.lblDobrodosli.TabIndex = 2;
            this.lblDobrodosli.Text = "Dobrodošli, imePrezime";
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(1014, 623);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(210, 36);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnUrediProfil
            // 
            this.btnUrediProfil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUrediProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediProfil.Location = new System.Drawing.Point(1042, 192);
            this.btnUrediProfil.Name = "btnUrediProfil";
            this.btnUrediProfil.Size = new System.Drawing.Size(134, 36);
            this.btnUrediProfil.TabIndex = 5;
            this.btnUrediProfil.Text = "Uredi profil";
            this.btnUrediProfil.UseVisualStyleBackColor = false;
            this.btnUrediProfil.Click += new System.EventHandler(this.btnUrediProfil_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1268, 22);
            this.textBox1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pbSlikaKorisnika
            // 
            this.pbSlikaKorisnika.Enabled = false;
            this.pbSlikaKorisnika.Location = new System.Drawing.Point(1042, 40);
            this.pbSlikaKorisnika.Name = "pbSlikaKorisnika";
            this.pbSlikaKorisnika.Size = new System.Drawing.Size(134, 130);
            this.pbSlikaKorisnika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaKorisnika.TabIndex = 0;
            this.pbSlikaKorisnika.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(437, 96);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(314, 10);
            this.textBox2.TabIndex = 16;
            // 
            // lblProsjekPrveGodine
            // 
            this.lblProsjekPrveGodine.AutoSize = true;
            this.lblProsjekPrveGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProsjekPrveGodine.Location = new System.Drawing.Point(6, 79);
            this.lblProsjekPrveGodine.Name = "lblProsjekPrveGodine";
            this.lblProsjekPrveGodine.Size = new System.Drawing.Size(113, 20);
            this.lblProsjekPrveGodine.TabIndex = 7;
            this.lblProsjekPrveGodine.Text = "1. godina / 0.0";
            // 
            // lblProsjekDrugeGodine
            // 
            this.lblProsjekDrugeGodine.AutoSize = true;
            this.lblProsjekDrugeGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProsjekDrugeGodine.Location = new System.Drawing.Point(6, 121);
            this.lblProsjekDrugeGodine.Name = "lblProsjekDrugeGodine";
            this.lblProsjekDrugeGodine.Size = new System.Drawing.Size(113, 20);
            this.lblProsjekDrugeGodine.TabIndex = 9;
            this.lblProsjekDrugeGodine.Text = "2. godina / 0.0";
            // 
            // lblProsjekTreceGodine
            // 
            this.lblProsjekTreceGodine.AutoSize = true;
            this.lblProsjekTreceGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProsjekTreceGodine.Location = new System.Drawing.Point(6, 164);
            this.lblProsjekTreceGodine.Name = "lblProsjekTreceGodine";
            this.lblProsjekTreceGodine.Size = new System.Drawing.Size(113, 20);
            this.lblProsjekTreceGodine.TabIndex = 11;
            this.lblProsjekTreceGodine.Text = "3. godina / 0.0";
            // 
            // lblUkupanProsjek
            // 
            this.lblUkupanProsjek.AutoSize = true;
            this.lblUkupanProsjek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupanProsjek.Location = new System.Drawing.Point(6, 204);
            this.lblUkupanProsjek.Name = "lblUkupanProsjek";
            this.lblUkupanProsjek.Size = new System.Drawing.Size(156, 20);
            this.lblUkupanProsjek.TabIndex = 13;
            this.lblUkupanProsjek.Text = "Ukupni prosjek / 0.0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbOcjene);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPretragaPoNazivu);
            this.groupBox2.Controls.Add(this.dgvPodaci);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 508);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o položenim ispitima:";
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.DatumPolaganja});
            this.dgvPodaci.GridColor = System.Drawing.Color.DimGray;
            this.dgvPodaci.Location = new System.Drawing.Point(7, 78);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.RowHeadersWidth = 51;
            this.dgvPodaci.RowTemplate.Height = 24;
            this.dgvPodaci.Size = new System.Drawing.Size(955, 443);
            this.dgvPodaci.TabIndex = 0;
            // 
            // txtPretragaPoNazivu
            // 
            this.txtPretragaPoNazivu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaPoNazivu.Location = new System.Drawing.Point(201, 37);
            this.txtPretragaPoNazivu.Name = "txtPretragaPoNazivu";
            this.txtPretragaPoNazivu.Size = new System.Drawing.Size(396, 24);
            this.txtPretragaPoNazivu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pretraži po predmetu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(621, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pretraži po ocjeni:";
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Location = new System.Drawing.Point(787, 36);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(175, 26);
            this.cmbOcjene.TabIndex = 23;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 125;
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPolaganja.DataPropertyName = "DatumPolaganja";
            this.DatumPolaganja.HeaderText = "DatumPolaganja";
            this.DatumPolaganja.MinimumWidth = 6;
            this.DatumPolaganja.Name = "DatumPolaganja";
            this.DatumPolaganja.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProsjekPrveGodine);
            this.groupBox1.Controls.Add(this.lblProsjekDrugeGodine);
            this.groupBox1.Controls.Add(this.lblUkupanProsjek);
            this.groupBox1.Controls.Add(this.lblProsjekTreceGodine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1004, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 355);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uspjeh:";
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUrediProfil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.pbSlikaKorisnika);
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGlavna";
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaKorisnika)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlikaKorisnika;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUrediProfil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblProsjekPrveGodine;
        private System.Windows.Forms.Label lblProsjekDrugeGodine;
        private System.Windows.Forms.Label lblProsjekTreceGodine;
        private System.Windows.Forms.Label lblUkupanProsjek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaPoNazivu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}