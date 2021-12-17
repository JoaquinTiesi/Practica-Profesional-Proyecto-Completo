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
    public partial class FormReporte : Form
    {
        private Form FrmMenu;
        public FormReporte(Form FormAdminMenu)
        {
            InitializeComponent();
            this.FrmMenu = FormAdminMenu;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu.Show();
        }

        private void transporteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transporteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datosDataSet);

        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.datosDataSet.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.Transporte' Puede moverla o quitarla según sea necesario.
            this.transporteTableAdapter.Fill(this.datosDataSet.Transporte);

            empleadoDataGridView.Update();
            transporteDataGridView.Update();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.empleadoTableAdapter.Fill(this.datosDataSet.Empleado);
            this.transporteTableAdapter.Fill(this.datosDataSet.Transporte);
        }

        private void btnFiltrarChofer_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = transporteDataGridView.DataSource;
            bs.Filter = "[Chofer] Like '%" + filtradochofer.Text + "%'";
            transporteDataGridView.DataSource = bs;
        }

        private void btnFiltrarFuel_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = transporteDataGridView.DataSource;
            bs.Filter = "[Fuel] Like '%" + filtradofuel.Text + "%'";
            transporteDataGridView.DataSource = bs;
        }

        private void btnFiltrarCantidad_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = transporteDataGridView.DataSource;
            bs.Filter = "[Cantidad] Like '%" + filtradocantidad.Text + "%'";
            transporteDataGridView.DataSource = bs;
        }

        private void btnFiltrarGenerico_Click(object sender, EventArgs e)
        {
            string str = filtradoOpcion.Text;
            switch (str)
            {
                case "Codigo":
                    BindingSource bs = new BindingSource();
                    bs.DataSource = empleadoDataGridView.DataSource;
                    bs.Filter = "[Codigo] Like '%" + filtradoValor.Text + "%'";
                    empleadoDataGridView.DataSource = bs;
                    break;
                case "Nombre":
                    BindingSource br = new BindingSource();
                    br.DataSource = empleadoDataGridView.DataSource;
                    br.Filter = "[Nombre] Like '%" + filtradoValor.Text + "%'";
                    empleadoDataGridView.DataSource = br;
                    break;
                case "Fuel":
                    BindingSource bf = new BindingSource();
                    bf.DataSource = empleadoDataGridView.DataSource;
                    bf.Filter = "[Fuel] Like '%" + filtradoValor.Text + "%'";
                    empleadoDataGridView.DataSource = bf;
                    break;
                case "Cantidad":
                    BindingSource bc = new BindingSource();
                    bc.DataSource = empleadoDataGridView.DataSource;
                    bc.Filter = "[Cantidad] Like '%" + filtradoValor.Text + "%'";
                    empleadoDataGridView.DataSource = bc;
                    break;
                case "Surtidor":
                    BindingSource bz = new BindingSource();
                    bz.DataSource = empleadoDataGridView.DataSource;
                    bz.Filter = "[Surtidor] Like '%" + filtradoValor.Text + "%'";
                    empleadoDataGridView.DataSource = bz;
                    break;
                case "Precio":
                    BindingSource bp = new BindingSource();
                    bp.DataSource = empleadoDataGridView.DataSource;
                    bp.Filter = "[Precio] Like '%" + filtradoValor.Text + "%'";
                    empleadoDataGridView.DataSource = bp;
                    break;
                default:
                    MessageBox.Show("Valores no Validos!");
                    break;
            }

        }
    }
}
