namespace Vaccination
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpManager = new System.Windows.Forms.DateTimePicker();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.BtnShowRegister = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Location = new System.Drawing.Point(221, 211);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(195, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Constraseña:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(327, 255);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(221, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sistema Vacunación  COVID-19\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartSesion
            // 
            this.btnStartSesion.BackColor = System.Drawing.Color.LightBlue;
            this.btnStartSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnStartSesion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStartSesion.Location = new System.Drawing.Point(425, 314);
            this.btnStartSesion.Name = "btnStartSesion";
            this.btnStartSesion.Size = new System.Drawing.Size(172, 27);
            this.btnStartSesion.TabIndex = 5;
            this.btnStartSesion.Text = "Iniciar sesion";
            this.btnStartSesion.UseVisualStyleBackColor = false;
            this.btnStartSesion.Click += new System.EventHandler(this.btnStartSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dtpManager
            // 
            this.dtpManager.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpManager.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.dtpManager.Enabled = false;
            this.dtpManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtpManager.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManager.Location = new System.Drawing.Point(-1, 430);
            this.dtpManager.Name = "dtpManager";
            this.dtpManager.Size = new System.Drawing.Size(99, 20);
            this.dtpManager.TabIndex = 7;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(327, 213);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(166, 21);
            this.cmbUser.TabIndex = 8;
            // 
            // BtnShowRegister
            // 
            this.BtnShowRegister.BackColor = System.Drawing.Color.LightBlue;
            this.BtnShowRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnShowRegister.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnShowRegister.Location = new System.Drawing.Point(195, 314);
            this.BtnShowRegister.Name = "BtnShowRegister";
            this.BtnShowRegister.Size = new System.Drawing.Size(172, 30);
            this.BtnShowRegister.TabIndex = 9;
            this.BtnShowRegister.Text = "Registros";
            this.BtnShowRegister.UseVisualStyleBackColor = false;
            this.BtnShowRegister.Click += new System.EventHandler(this.BtnShowRegister_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.LightBlue;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOut.Location = new System.Drawing.Point(702, 419);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(97, 31);
            this.btnOut.TabIndex = 10;
            this.btnOut.Text = "salir";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.BtnShowRegister);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.dtpManager);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStartSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Manager";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnOut;

        private System.Windows.Forms.Button btn;

        private System.Windows.Forms.Button BtnShowRegister;

        private System.Windows.Forms.ComboBox cmbUser;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.DateTimePicker dtpManager;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btnStartSesion;

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label lblUser;

        #endregion
    }
}