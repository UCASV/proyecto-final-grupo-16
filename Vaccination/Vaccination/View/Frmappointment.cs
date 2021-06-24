using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Vaccination.SqlServerContext;

namespace Vaccination
{
    public partial class Frmappointment : Form
    {
        
        public Frmappointment(string Dui)
        {
            InitializeComponent();
           
            txtDuiR.Text = Dui;

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            var db = new Proyecto_DB_POOContext();

            Appointment apo = new Appointment()
            {
                Dui = txtDuiR.Text,
                FirstDate = dateTimePicker2.Value,
                FirstHour = dateTimePicker3.Value.TimeOfDay,
                IdCabin = ((Cabin) cbxCabin.SelectedItem).Id,
                VaccinationPlace = ((Cabin) cbxCabin.SelectedItem).AddressCabin
            };
            
                db.Add(apo);
                db.SaveChanges();
                MessageBox.Show("Cita Registrada!!!", "Sistema de registro - Citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MessageBox.Show("vacundo:) ","Proceso de Vacunacion - Covid-19", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Close();
                
                Frmappointment2 form = new Frmappointment2(txtDuiR.Text,dateTimePicker2.Value.AddDays(49));
                form.ShowDialog();
            }


        private void Frmappointment_Load(object sender, EventArgs e)
        {
            var db = new Proyecto_DB_POOContext();
            List<Cabin> cabin = db.Cabins
                .ToList();
            cbxCabin.DataSource = cabin;
            cbxCabin.DisplayMember = "AddressCabin";
            cbxCabin.ValueMember = "Id";
        }
    }
    }
