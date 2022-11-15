using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planificadoresz
{
    

    public partial class Form1 : Form
    {
        Proceso con = new Proceso();
       // public static List<Proceso> lista = new List<Proceso>();
        public Form1()
        {
            InitializeComponent();
            //. List<ProcesosCPU> lista_ProcesosCPU = new List<>();
            //int [] valores;
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelCPU.Visible = true;
            PanelPrioridad.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelCPU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelCPU.Visible = false;
            PanelPrioridad.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            string nombreProceso = CPUtxt.Text.ToString();
            int CPUvalue = Convert.ToInt32(CPUtxt.Text);
             //public static List<Proceso> lista = new List<Proceso>();


    }

    private void PanelPrioridad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcesosForm pf = new ProcesosForm();
            pf.Visible = true;
           
        }
    }
}
