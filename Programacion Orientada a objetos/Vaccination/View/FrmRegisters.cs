using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;

namespace Vaccination
{
    public partial class FrmRegisters : Form
    {
        SqlConnection connection = new SqlConnection("Server=localhost;Database=Proyecto_DB_POO;Trusted_Connection=true;");
        public FrmRegisters()
        {
            InitializeComponent();
        }
        
       
        private void BtnCitizen_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT CITIZEN.Dui,CITIZEN.Full_name'Nombre',First_date 'Fecha primera dosis',First_hour'Hora primera dosis',Second_date'Fecha segunda dosis',Second_hour'Hora segunda dosis' FROM APPOINTMENT INNER JOIN CITIZEN ON APPOINTMENT.Dui = CITIZEN.Dui ",connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            btnPdf.Visible = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT MANAGER.username'Usuario', address_cabin'Direccion de cabina', REGISTER.date_cabine'Fecha de inicio de sesion' FROM REGISTER INNER JOIN MANAGER ON REGISTER.id_manager = MANAGER.Id INNER JOIN CABIN ON REGISTER.id_cabin = CABIN.Id",connection);
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            btnPdf.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {  
                 SaveFileDialog sfd = new SaveFileDialog();  
                 sfd.Filter = "PDF (.pdf)|.pdf";  
                 sfd.FileName = "Data.pdf";  
                 bool fileError = false;  
                 if (sfd.ShowDialog() == DialogResult.OK)  
                 {  
                     if (File.Exists(sfd.FileName))  
                     {  
                         try  
                         {  
                             File.Delete(sfd.FileName);  
                         }  
                         catch (IOException ex)  
                         {  
                             fileError = true;  
                             MessageBox.Show("No fue posible escribir los datos en el disco." + ex.Message);  
                         }  
                     }  
                     if (!fileError)  
                     {  
                         try  
                         {
                             PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);  
                             pdfTable.DefaultCell.Padding = 3;  
                             pdfTable.WidthPercentage = 100;  
                             pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;  
  
                             foreach (DataGridViewColumn column in dataGridView1.Columns)  
                             {  
                                 PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));  
                                 pdfTable.AddCell(cell);  
                             }  
  
                             foreach (DataGridViewRow row in dataGridView1.Rows)  
                             {  
                                 foreach (DataGridViewCell cell in row.Cells)  
                                 {  
                                     if (cell.Value != null)
                                     {
                                         pdfTable.AddCell(cell.Value.ToString());
                                     } 
                                 }  
                             }  
  
                             using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))  
                             {  
                                 Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);  
                                 PdfWriter.GetInstance(pdfDoc, stream);  
                                 pdfDoc.Open();  
                                 Paragraph title;
                                 Font titleFont = FontFactory.GetFont("Arial", 32);
                                 title = new Paragraph("Datos recolectados", titleFont );
                                 title.Alignment = Element.ALIGN_CENTER;
                                 pdfDoc.Add(title);
                                 pdfDoc.Add(new Chunk("\n"));
                                 pdfDoc.Add(pdfTable);  
                                 pdfDoc.Close();  
                                 stream.Close();  
                             }  
  
                             MessageBox.Show("Datos exportados con exito!", "Covid-19 - Exportando datos",MessageBoxButtons.OK,MessageBoxIcon.Information);  
                         }  
                         catch (Exception ex)  
                         {  
                             MessageBox.Show("Error :" + ex.Message);  
                         }  
                     }  
                 }  
             }  
             else  
             {  
                 MessageBox.Show("No hay nada para exportar!", "Info");  
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT CITIZEN.Dui,CITIZEN.Full_name'Nombre',First_date 'Fecha primera dosis',First_hour'Hora primera dosis',Second_date'Fecha segunda dosis',Second_hour'Hora segunda dosis' FROM APPOINTMENT INNER JOIN CITIZEN ON APPOINTMENT.Dui = CITIZEN.Dui WHERE CITIZEN.Dui='"+textBox1.Text+"'",connection);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
            
                        btnPdf.Visible = true;
        }
    }
}