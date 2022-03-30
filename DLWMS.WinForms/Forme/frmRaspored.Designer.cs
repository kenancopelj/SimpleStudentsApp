
namespace StudentsApp.WinForms.Forme
{
    partial class frmRaspored
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
            this.pbRaspored = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRaspored
            // 
            this.pbRaspored.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRaspored.Location = new System.Drawing.Point(0, 0);
            this.pbRaspored.Name = "pbRaspored";
            this.pbRaspored.Size = new System.Drawing.Size(1234, 729);
            this.pbRaspored.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaspored.TabIndex = 0;
            this.pbRaspored.TabStop = false;
            // 
            // frmRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 729);
            this.Controls.Add(this.pbRaspored);
            this.Name = "frmRaspored";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raspored";
            this.Load += new System.EventHandler(this.frmRaspored_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRaspored)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRaspored;
    }
}