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
    public partial class FormStock : Form
    {
        private Form FrmMenu;
        public FormStock(Form Form1)
        {
            InitializeComponent();
            this.FrmMenu = Form1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu.Show();
        }

        private void combustibleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.combustibleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.datosDataSet);

        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosDataSet.Combustible' Puede moverla o quitarla según sea necesario.
            this.combustibleTableAdapter.Fill(this.datosDataSet.Combustible);

            //barraProgreso.Value = Convert.ToInt32(stockTextBox.Text);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.combustibleTableAdapter.Fill(this.datosDataSet.Combustible);
        }

        private void combustibleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stockTextBox.Text != "")
            {
                barraProgreso.Value = Convert.ToInt32(stockTextBox.Text);
            }
        }

        private void combustibleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stockTextBox.Text != "")
            {
                barraProgreso.Value = Convert.ToInt32(stockTextBox.Text);
            }
        }
    }
}
