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
    public partial class FormLogCarga : Form
    {
        public static string TextoChofer = "";
        public static string TextoCodigo = "";
        private Form FrmForm1;
        private Form FrmCarga;
        public FormLogCarga(Form Form1)
        {
            InitializeComponent();
            FrmCarga = new Carga(this);
            this.FrmForm1 = Form1;
        }

        private void datosTransporteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datosTransporteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datosDataSet);

        }

        private void FormLogCarga_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.DatosTransporte' Puede moverla o quitarla según sea necesario.
            this.datosTransporteTableAdapter.Fill(this.datosDataSet.DatosTransporte);

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
                TextoChofer = choferTextBox.Text;
                TextoCodigo = codigoTextBox.Text;
                this.Hide();
                FrmCarga.Show();
    }
        }
    }
}
