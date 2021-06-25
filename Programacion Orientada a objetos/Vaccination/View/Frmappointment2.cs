using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Vaccination.SqlServerContext;

namespace Vaccination
{
    public partial class Frmappointment2 : Form
    {
        
        public Frmappointment2( string Duir,DateTime date)
        {
            InitializeComponent();
            
            txtDuir2.Text = Duir;
            dtpDate2.Value = date;


        }

        private void Frmappointment2_Load(object sender, EventArgs e)
        {
            var db = new Proyecto_DB_POOContext();
            List<SecondaryEffect> secondaryEffects = db.SecondaryEffects
                .ToList();
            cmbEffects.DataSource = secondaryEffects;
            cmbEffects.DisplayMember = "SecEffect";
            cmbEffects.ValueMember = "Id";
            
            
        }

        private void btnCreatecite2_Click(object sender, EventArgs e)
        {
            string  Duir = txtDuir2.Text;

            var db = new Proyecto_DB_POOContext();
            (from ci in db.Citizens
                    where ci.Dui == txtDuir2.Text
                    select ci).ToList()
                .ForEach(xx => xx.IdSecEffect = ((SecondaryEffect) cmbEffects.SelectedItem).Id); //siuuu logica para el efecto secundario
           
           
            (from ap in db.Appointments
                    where ap.Dui == txtDuir2.Text
                    select ap).ToList()
                .ForEach(xx => xx.SecondDate = dtpDate2.Value);
            
            (from ap in db.Appointments
                    where ap.Dui == txtDuir2.Text
                    select ap).ToList()
                .ForEach(xx => xx.SecondHour = dtpHour2.Value.TimeOfDay);
            
            db.SaveChanges();
            
            MessageBox.Show("Su segunda dosis fue registrada","Proceso de Vacunacion segunda dosis - Covid-19", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            
            FrmLogin form = new FrmLogin();
            form.ShowDialog();
        }
      
    }
}