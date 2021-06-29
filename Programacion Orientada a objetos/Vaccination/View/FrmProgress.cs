using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Vaccination
{
    public partial class FrmProgress : Form
    {
        public FrmProgress()
        {
            InitializeComponent();
            label1.Text = "";
            
        }
        BackgroundWorker bgw = new BackgroundWorker();

        private void button1_Click(object sender, EventArgs e)
        {
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
            button1.Enabled = false;
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 57; //some number (this is your variable to change)!!

            for (int i = 0; i <= total; i++) //some number (total)
            {
                System.Threading.Thread.Sleep(100);
                int percents = (i * 100) / total;
                bgw.ReportProgress(percents, i);
                //2 arguments:
                //1. procenteges (from 0 t0 100) - i do a calcumation 
                //2. some current value!
            }
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = String.Format("Vacunando...");
            
           
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Primera dosis aplicada :)");
            this.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}