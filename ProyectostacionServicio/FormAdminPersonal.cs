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
    public partial class FormAdminPersonal : Form
    {
        private Form FrmAdminMenu;
        public FormAdminPersonal(Form FormAdminMenu)
        {
            InitializeComponent();
            this.FrmAdminMenu = FormAdminMenu;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminMenu.Show();
        }

        private void datosEmpleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datosEmpleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datosDataSet);

        }

        private void FormAdminPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.DatosEmpleado' Puede moverla o quitarla según sea necesario.
            this.datosEmpleadoTableAdapter.Fill(this.datosDataSet.DatosEmpleado);

        }
    }
}
