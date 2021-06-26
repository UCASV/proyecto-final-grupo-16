using System.ComponentModel;

namespace Vaccination
{
    partial class FrmProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgress));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(125, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.progressBar1.Location = new System.Drawing.Point(125, 110);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(279, 25);
            this.progressBar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(180, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aplicar Vacuna";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proceso de vacunación Covid-19";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(520, 226);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmtest";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ProgressBar progressBar1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}