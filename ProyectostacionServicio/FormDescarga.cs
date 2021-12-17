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
    public partial class FormDescarga : Form
    {
        private Form FrmMenu;
        public FormDescarga(Form FormLogDescarga)
        {
            InitializeComponent();
            this.FrmMenu = FormLogDescarga;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            codigoTextBox.Text = "";
            nombreTextBox.Text = "";
            this.Hide();
            FrmMenu.Show();
        }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (fuelTextBox.Text != "" && surtidorTextBox.Text != "")
            {
                int precioVenta = Convert.ToInt32(cantidadTextBox.Text) * Convert.ToInt32(precioTextBox1.Text);
                int venta = Convert.ToInt32(stockTextBox.Text) - Convert.ToInt32(cantidadTextBox.Text);
                if (venta >= 1000)
                {
                    stockTextBox.Text = Convert.ToString(venta);
                    precioTextBox.Text = Convert.ToString(precioVenta);
                    this.Validate();
                    this.combustibleBindingSource.EndEdit();
                    this.empleadoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.datosDataSet);
                    MessageBox.Show("Vendidos " + cantidadTextBox.Text + " Litros de " + fuelTextBox1.Text);
                    bindingNavigatorAddNewItem.PerformClick();
                    codigoTextBox.Text = FormLogDescarga.TextoCodigoEmpleado;
                    nombreTextBox.Text = FormLogDescarga.TextoEmpleado;
                }
                else
                {
                    MessageBox.Show("Cantidad minima alcanzada!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }

            
            

        }

        private void FormDescarga_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.Combustible' Puede moverla o quitarla según sea necesario.
            this.combustibleTableAdapter.Fill(this.datosDataSet.Combustible);
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.datosDataSet.Empleado);


            combustibleDataGridView.Update();
            bindingNavigatorAddNewItem.PerformClick();
            codigoTextBox.Text = FormLogDescarga.TextoCodigoEmpleado;
            nombreTextBox.Text = FormLogDescarga.TextoEmpleado;

        }

        private void fuelTextBox1_TextChanged(object sender, EventArgs e)
        {
            fuelTextBox.Text = fuelTextBox1.Text;
        }

        private void Surtidor1_Click(object sender, EventArgs e)
        {
            surtidorTextBox.Text = "Surtidor 1";
        }

        private void Surtidor2_Click(object sender, EventArgs e)
        {
            surtidorTextBox.Text = "Surtidor 2";
        }

        private void Surtidor3_Click(object sender, EventArgs e)
        {
            surtidorTextBox.Text = "Surtidor 3";
        }

        private void Surtidor4_Click(object sender, EventArgs e)
        {
            surtidorTextBox.Text = "Surtidor 4";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.combustibleTableAdapter.Fill(this.datosDataSet.Combustible);
            this.empleadoTableAdapter.Fill(this.datosDataSet.Empleado);
            bindingNavigatorAddNewItem.PerformClick();
            codigoTextBox.Text = FormLogDescarga.TextoCodigoEmpleado;
            nombreTextBox.Text = FormLogDescarga.TextoEmpleado;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_MouseLeave(object sender, EventArgs e)
        {
            codigoTextBox.Text = FormLogDescarga.TextoCodigoEmpleado;
            nombreTextBox.Text = FormLogDescarga.TextoEmpleado;
        }

        private void bindingNavigatorAddNewItem_MouseUp(object sender, MouseEventArgs e)
        {
            codigoTextBox.Text = FormLogDescarga.TextoCodigoEmpleado;
            nombreTextBox.Text = FormLogDescarga.TextoEmpleado;
        }
    }
}
