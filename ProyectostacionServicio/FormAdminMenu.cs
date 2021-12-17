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
    public partial class FormAdminMenu : Form
    {
        private Form FrmLog;
        private Form FrmPersonal;
        private Form FrmTransporte;
        private Form FrmReporte;
        public FormAdminMenu(Form FormLogAdmin)
        {
            InitializeComponent();
            FrmPersonal = new FormAdminPersonal(this);
            FrmTransporte = new FormAdminTransporte(this);
            FrmReporte = new FormReporte(this);
            this.FrmLog = FormLogAdmin;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLog.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPersonal.Show();
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransporte.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReporte.Show();
        }
    }
}
