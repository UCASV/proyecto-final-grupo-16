using System.ComponentModel;

namespace Vaccination
{
    partial class Frmappointment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmappointment2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuir2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbEffects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatecite2 = new System.Windows.Forms.Button();
            this.dtpHour2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDuir2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmbEffects);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreatecite2);
            this.groupBox1.Controls.Add(this.dtpHour2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDate2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cita";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(223, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dui:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDuir2
            // 
            this.txtDuir2.Enabled = false;
            this.txtDuir2.Location = new System.Drawing.Point(385, 11);
            this.txtDuir2.Name = "txtDuir2";
            this.txtDuir2.Size = new System.Drawing.Size(101, 21);
            this.txtDuir2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmbEffects
            // 
            this.cmbEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEffects.FormattingEnabled = true;
            this.cmbEffects.Location = new System.Drawing.Point(192, 133);
            this.cmbEffects.Name = "cmbEffects";
            this.cmbEffects.Size = new System.Drawing.Size(204, 23);
            this.cmbEffects.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Efectos Secundarios:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreatecite2
            // 
            this.btnCreatecite2.BackColor = System.Drawing.Color.LightBlue;
            this.btnCreatecite2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatecite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCreatecite2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCreatecite2.Location = new System.Drawing.Point(282, 196);
            this.btnCreatecite2.Name = "btnCreatecite2";
            this.btnCreatecite2.Size = new System.Drawing.Size(146, 35);
            this.btnCreatecite2.TabIndex = 6;
            this.btnCreatecite2.Text = "Crear cita";
            this.btnCreatecite2.UseVisualStyleBackColor = false;
            this.btnCreatecite2.Click += new System.EventHandler(this.btnCreatecite2_Click);
            // 
            // dtpHour2
            // 
            this.dtpHour2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHour2.Location = new System.Drawing.Point(194, 106);
            this.dtpHour2.Name = "dtpHour2";
            this.dtpHour2.ShowUpDown = true;
            this.dtpHour2.Size = new System.Drawing.Size(202, 21);
            this.dtpHour2.TabIndex = 5;
            this.dtpHour2.Value = new System.DateTime(2021, 6, 22, 21, 54, 0, 0);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora de segunda cita:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate2
            // 
            this.dtpDate2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtpDate2.Enabled = false;
            this.dtpDate2.Location = new System.Drawing.Point(194, 79);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(202, 21);
            this.dtpDate2.TabIndex = 3;
            this.dtpDate2.Value = new System.DateTime(2021, 6, 22, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha segunda cita:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frmappointment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(535, 318);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmappointment2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de citas -Segunda dosis";
            this.Load += new System.EventHandler(this.Frmappointment2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtDuir2;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.DateTimePicker dtpHour2;
        private System.Windows.Forms.ComboBox cmbEffects;
        private System.Windows.Forms.Button btnCreatecite2;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxCabin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}