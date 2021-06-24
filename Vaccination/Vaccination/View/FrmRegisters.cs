using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Vaccination
{
    public partial class FrmRegisters : Form
    {
        SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Proyecto_DB_POO;Trusted_Connection=true;");
        public FrmRegisters()
        {
            InitializeComponent();
        }
        
       
        private void BtnCitizen_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT CITIZEN.Dui,CITIZEN.Full_name'Nombre',First_date 'Fecha primera dosis',First_hour'Hora primera dosis',Second_date'Fecha segunda dosis',Second_hour'Hora segunda dosis',Vaccination_place'Direccion de cabina' FROM APPOINTMENT INNER JOIN CITIZEN ON APPOINTMENT.Dui = CITIZEN.Dui",connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT MANAGER.username'Usuario', address_cabin'Direccion de cabina', REGISTER.date_cabine'Fecha de inicio de sesion' FROM REGISTER INNER JOIN MANAGER ON REGISTER.id_manager = MANAGER.Id INNER JOIN CABIN ON REGISTER.id_cabin = CABIN.Id",connection);
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}