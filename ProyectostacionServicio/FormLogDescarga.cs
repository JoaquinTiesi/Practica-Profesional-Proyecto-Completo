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
    public partial class FormLogDescarga : Form
    {
        public static string TextoEmpleado = "";
        public static string TextoCodigoEmpleado = "";
        private Form FrmForm1;
        private Form FrmDescarga;
        public FormLogDescarga(Form Form1)
        {
            InitializeComponent();
            this.FrmForm1 = Form1;
            FrmDescarga = new FormDescarga(this);
        }

        private void datosEmpleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datosEmpleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datosDataSet);

        }

        private void FormLogDescarga_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.DatosEmpleado' Puede moverla o quitarla según sea necesario.
            this.datosEmpleadoTableAdapter.Fill(this.datosDataSet.DatosEmpleado);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmForm1.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(passTextBox.Text) == Convert.ToInt32(pass.Text))
            {
                TextoEmpleado = nombreTextBox.Text;
                TextoCodigoEmpleado = codigoTextBox.Text;
                this.Hide();
                FrmDescarga.Show();
            }
        }
    }
}
