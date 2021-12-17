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
    public partial class FormMenu : Form
    {
        private Form FrmForm1;
        private Form FrmLog;
        public FormMenu()
        {
            InitializeComponent();
            FrmForm1 = new Form1(this);
            FrmLog = new FormLogAdmin(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmForm1.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLog.Show();
        }
    }
}
