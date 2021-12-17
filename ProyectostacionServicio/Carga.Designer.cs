
namespace ProyectostacionServicio
{
    partial class Carga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label choferLabel;
            System.Windows.Forms.Label fuelLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carga));
            this.btnVolver = new System.Windows.Forms.Button();
            this.datosDataSet = new ProyectostacionServicio.DatosDataSet();
            this.transporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transporteTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.TransporteTableAdapter();
            this.tableAdapterManager = new ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager();
            this.combustibleTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.CombustibleTableAdapter();
            this.transporteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.transporteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.choferTextBox = new System.Windows.Forms.TextBox();
            this.fuelTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.combustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combustibleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTextBox1 = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            choferLabel = new System.Windows.Forms.Label();
            fuelLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transporteBindingNavigator)).BeginInit();
            this.transporteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(9, 31);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(97, 13);
            codigoLabel.TabIndex = 23;
            codigoLabel.Text = "Codigo Transporte:";
            // 
            // choferLabel
            // 
            choferLabel.AutoSize = true;
            choferLabel.Location = new System.Drawing.Point(9, 57);
            choferLabel.Name = "choferLabel";
            choferLabel.Size = new System.Drawing.Size(95, 13);
            choferLabel.TabIndex = 25;
            choferLabel.Text = "Chofer Transporte:";
            // 
            // fuelLabel
            // 
            fuelLabel.AutoSize = true;
            fuelLabel.Location = new System.Drawing.Point(9, 83);
            fuelLabel.Name = "fuelLabel";
            fuelLabel.Size = new System.Drawing.Size(67, 13);
            fuelLabel.TabIndex = 27;
            fuelLabel.Text = "Combustible:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(9, 109);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(75, 13);
            cantidadLabel.TabIndex = 29;
            cantidadLabel.Text = "Cantidad (Lts):";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(117, 333);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 38);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // datosDataSet
            // 
            this.datosDataSet.DataSetName = "DatosDataSet";
            this.datosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transporteBindingSource
            // 
            this.transporteBindingSource.DataMember = "Transporte";
            this.transporteBindingSource.DataSource = this.datosDataSet;
            // 
            // transporteTableAdapter
            // 
            this.transporteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombustibleTableAdapter = this.combustibleTableAdapter;
            this.tableAdapterManager.DatosEmpleadoTableAdapter = null;
            this.tableAdapterManager.DatosTransporteTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.TransporteTableAdapter = this.transporteTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combustibleTableAdapter
            // 
            this.combustibleTableAdapter.ClearBeforeFill = true;
            // 
            // transporteBindingNavigator
            // 
            this.transporteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transporteBindingNavigator.BindingSource = this.transporteBindingSource;
            this.transporteBindingNavigator.CountItem = null;
            this.transporteBindingNavigator.DeleteItem = null;
            this.transporteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.transporteBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.transporteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transporteBindingNavigator.MoveFirstItem = null;
            this.transporteBindingNavigator.MoveLastItem = null;
            this.transporteBindingNavigator.MoveNextItem = null;
            this.transporteBindingNavigator.MovePreviousItem = null;
            this.transporteBindingNavigator.Name = "transporteBindingNavigator";
            this.transporteBindingNavigator.PositionItem = null;
            this.transporteBindingNavigator.Size = new System.Drawing.Size(270, 25);
            this.transporteBindingNavigator.TabIndex = 21;
            this.transporteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // transporteBindingNavigatorSaveItem
            // 
            this.transporteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transporteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transporteBindingNavigatorSaveItem.Image")));
            this.transporteBindingNavigatorSaveItem.Name = "transporteBindingNavigatorSaveItem";
            this.transporteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.transporteBindingNavigatorSaveItem.Text = "Guardar datos";
            this.transporteBindingNavigatorSaveItem.Click += new System.EventHandler(this.transporteBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transporteBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(112, 28);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 24;
            // 
            // choferTextBox
            // 
            this.choferTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transporteBindingSource, "Chofer", true));
            this.choferTextBox.Location = new System.Drawing.Point(112, 54);
            this.choferTextBox.Name = "choferTextBox";
            this.choferTextBox.ReadOnly = true;
            this.choferTextBox.Size = new System.Drawing.Size(100, 20);
            this.choferTextBox.TabIndex = 26;
            // 
            // fuelTextBox
            // 
            this.fuelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transporteBindingSource, "Fuel", true));
            this.fuelTextBox.Location = new System.Drawing.Point(112, 80);
            this.fuelTextBox.Name = "fuelTextBox";
            this.fuelTextBox.ReadOnly = true;
            this.fuelTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelTextBox.TabIndex = 28;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transporteBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(112, 106);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 30;
            // 
            // combustibleBindingSource
            // 
            this.combustibleBindingSource.DataMember = "Combustible";
            this.combustibleBindingSource.DataSource = this.datosDataSet;
            // 
            // combustibleDataGridView
            // 
            this.combustibleDataGridView.AutoGenerateColumns = false;
            this.combustibleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combustibleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.combustibleDataGridView.DataSource = this.combustibleBindingSource;
            this.combustibleDataGridView.Location = new System.Drawing.Point(12, 132);
            this.combustibleDataGridView.Name = "combustibleDataGridView";
            this.combustibleDataGridView.ReadOnly = true;
            this.combustibleDataGridView.Size = new System.Drawing.Size(244, 133);
            this.combustibleDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Fuel";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fuel";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn9.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // fuelTextBox1
            // 
            this.fuelTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combustibleBindingSource, "Fuel", true));
            this.fuelTextBox1.Location = new System.Drawing.Point(27, 287);
            this.fuelTextBox1.Name = "fuelTextBox1";
            this.fuelTextBox1.ReadOnly = true;
            this.fuelTextBox1.Size = new System.Drawing.Size(100, 20);
            this.fuelTextBox1.TabIndex = 35;
            this.fuelTextBox1.TextChanged += new System.EventHandler(this.fuelTextBox1_TextChanged);
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combustibleBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(133, 287);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockTextBox.TabIndex = 37;
            // 
            // Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 383);
            this.Controls.Add(this.fuelTextBox1);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.combustibleDataGridView);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(choferLabel);
            this.Controls.Add(this.choferTextBox);
            this.Controls.Add(fuelLabel);
            this.Controls.Add(this.fuelTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.transporteBindingNavigator);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Combustible";
            this.Load += new System.EventHandler(this.Carga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transporteBindingNavigator)).EndInit();
            this.transporteBindingNavigator.ResumeLayout(false);
            this.transporteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private DatosDataSet datosDataSet;
        private System.Windows.Forms.BindingSource transporteBindingSource;
        private DatosDataSetTableAdapters.TransporteTableAdapter transporteTableAdapter;
        private DatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transporteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton transporteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox choferTextBox;
        private System.Windows.Forms.TextBox fuelTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private DatosDataSetTableAdapters.CombustibleTableAdapter combustibleTableAdapter;
        private System.Windows.Forms.BindingSource combustibleBindingSource;
        private System.Windows.Forms.DataGridView combustibleDataGridView;
        private System.Windows.Forms.TextBox fuelTextBox1;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}