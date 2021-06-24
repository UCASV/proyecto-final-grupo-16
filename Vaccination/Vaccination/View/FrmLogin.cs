using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Vaccination.SqlServerContext;
using Vaccination.SqlServerContext;

namespace Vaccination
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnStartSesion_Click(object sender, EventArgs e)
        {
           
            string Password = txtPassword.Text;

            var db = new Proyecto_DB_POOContext();
            var ListUsers = db.Managers
                .OrderBy(ma => ma.Id)
                .ToList();

            var result = ListUsers.Where(
                    m => m.Username.Equals(((Manager)cmbUser.SelectedItem).Username) &&
                         m.PasswordManager.Equals(txtPassword.Text))
                .ToList();

            if (result.Count == 0)
                MessageBox.Show("No se encontro ningun Manager con estos datos", "Inicio de sesion-ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                MessageBox.Show("Bienvenido " + (((Manager)cmbUser.SelectedItem).Username),  "Inicio de sesion - Bienvenido/a", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
             
                this.Hide();
                
               
                List<Register> registers = db.Registers.ToList();
                
                Register register = new Register()
                {
                    DateCabine = dtpManager.Value = DateTime.Now,
                    IdManager =  (((Manager)cmbUser.SelectedItem).Id),
                    IdCabin = (((Manager)cmbUser.SelectedItem).IdCabin)
                    
                };
                db.Add(register);
                db.SaveChanges();
                
                FrmCitizen form = new FrmCitizen();
                form.ShowDialog();

            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var db = new Proyecto_DB_POOContext();
            List<Manager> managers = db.Managers
                    .ToList();
           cmbUser.DataSource = managers;
           cmbUser.DisplayMember = "Username";
           cmbUser.ValueMember = "Id";
            
       
        }

        private void BtnShowRegister_Click(object sender, EventArgs e)
        {
            FrmRegisters form = new FrmRegisters();
            form.ShowDialog();   
        }
    }
}