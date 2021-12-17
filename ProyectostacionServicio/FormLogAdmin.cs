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
    public partial class FormLogAdmin : Form
    {
        private Form FrmPrincipal;
        private Form FrmAdminMenu;
        public FormLogAdmin(Form FormMenu)
        {
            InitializeComponent();
            this.FrmPrincipal = FormMenu;
            FrmAdminMenu = new FormAdminMenu(this);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textpass.Text) == 123456)
            {
                textpass.Text = "000000";
                this.Hide();
                FrmAdminMenu.Show();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta!");
            }

        }
    }
}
