using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectostacionServicio
{
    public partial class Form1 : Form
    {   //private Form FrmCarga;
        //private Form FrmDescarga;
        //private Form FrmReporte;
        private Form FrmStock;
        private Form FrmPrincipal;
        private Form FrmLogCarga;
        private Form FrmLogDescarga;
        public Form1(Form FormMenu)
        {
            InitializeComponent();
            //FrmCarga = new Carga(this);
            //FrmDescarga = new FormDescarga(this);

            FrmLogCarga = new FormLogCarga(this);
            FrmLogDescarga = new FormLogDescarga(this);
            //FrmReporte = new FormReporte(this);
            FrmStock = new FormStock(this);
            this.FrmPrincipal = FormMenu;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogCarga.Show();
        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogDescarga.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStock.Show();
        }
    }
}
