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
    public partial class Carga : Form
    {
        private Form FrmMenu;
        public Carga(Form FormLogCarga)
        {
            InitializeComponent();
            this.FrmMenu = FormLogCarga;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            codigoTextBox.Text = "";
            choferTextBox.Text = "";
            this.Hide();
            FrmMenu.Show();
        }

        private void transporteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text != "" && choferTextBox.Text != "" && fuelTextBox.Text != "" && cantidadTextBox.Text != "")
            {
                int carga = Convert.ToInt32(stockTextBox.Text) + Convert.ToInt32(cantidadTextBox.Text);
                if (carga <= 10000)
                {
                    stockTextBox.Text = Convert.ToString(carga);
                    this.Validate();
                    this.combustibleBindingSource.EndEdit();
                    this.transporteBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.datosDataSet);
                    MessageBox.Show("Cargadados " + cantidadTextBox.Text + " Litros de " + fuelTextBox1.Text);
                    bindingNavigatorAddNewItem.PerformClick();
                }
                else
                {
                    MessageBox.Show("Cantidad maxima alcanzada!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
            

            
            

        }

        private void Carga_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.Combustible' Puede moverla o quitarla según sea necesario.
            this.combustibleTableAdapter.Fill(this.datosDataSet.Combustible);
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.Transporte' Puede moverla o quitarla según sea necesario.
            this.transporteTableAdapter.Fill(this.datosDataSet.Transporte);

            bindingNavigatorAddNewItem.PerformClick();
            

        }

        private void fuelTextBox1_TextChanged(object sender, EventArgs e)
        {
            fuelTextBox.Text = fuelTextBox1.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.combustibleTableAdapter.Fill(this.datosDataSet.Combustible);
            this.transporteTableAdapter.Fill(this.datosDataSet.Transporte);
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            codigoTextBox.Text = FormLogCarga.TextoCodigo;
            choferTextBox.Text = FormLogCarga.TextoChofer;
        }
    }
}
