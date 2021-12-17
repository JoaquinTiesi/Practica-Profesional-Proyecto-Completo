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
    public partial class FormAdminTransporte : Form
    {
        private Form FrmAdminMenu;
        public FormAdminTransporte(Form FormAdminMenu)
        {
            InitializeComponent();
            this.FrmAdminMenu = FormAdminMenu;
        }

        private void datosTransporteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datosTransporteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datosDataSet);

        }

        private void FormAdminTransporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.DatosTransporte' Puede moverla o quitarla según sea necesario.
            this.datosTransporteTableAdapter.Fill(this.datosDataSet.DatosTransporte);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminMenu.Show();
        }
    }
}
