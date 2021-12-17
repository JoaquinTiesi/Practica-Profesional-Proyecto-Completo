
namespace ProyectostacionServicio
{
    partial class FormDescarga
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fuelLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label surtidorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescarga));
            this.btnVolver = new System.Windows.Forms.Button();
            this.datosDataSet = new ProyectostacionServicio.DatosDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager();
            this.combustibleTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.CombustibleTableAdapter();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fuelTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.combustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combustibleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTextBox1 = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.surtidorTextBox = new System.Windows.Forms.TextBox();
            this.Surtidor1 = new System.Windows.Forms.Button();
            this.Surtidor2 = new System.Windows.Forms.Button();
            this.Surtidor3 = new System.Windows.Forms.Button();
            this.Surtidor4 = new System.Windows.Forms.Button();
            codigoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fuelLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            surtidorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).BeginInit();
            this.empleadoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(12, 34);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(93, 13);
            codigoLabel.TabIndex = 21;
            codigoLabel.Text = "Codigo Empleado:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 60);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(97, 13);
            nombreLabel.TabIndex = 23;
            nombreLabel.Text = "Nombre Empleado:";
            // 
            // fuelLabel
            // 
            fuelLabel.AutoSize = true;
            fuelLabel.Location = new System.Drawing.Point(12, 86);
            fuelLabel.Name = "fuelLabel";
            fuelLabel.Size = new System.Drawing.Size(67, 13);
            fuelLabel.TabIndex = 25;
            fuelLabel.Text = "Combustible:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(12, 112);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(75, 13);
            cantidadLabel.TabIndex = 27;
            cantidadLabel.Text = "Cantidad (Lts):";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(12, 138);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(71, 13);
            precioLabel.TabIndex = 29;
            precioLabel.Text = "Precio Venta:";
            // 
            // surtidorLabel
            // 
            surtidorLabel.AutoSize = true;
            surtidorLabel.Location = new System.Drawing.Point(12, 166);
            surtidorLabel.Name = "surtidorLabel";
            surtidorLabel.Size = new System.Drawing.Size(46, 13);
            surtidorLabel.TabIndex = 33;
            surtidorLabel.Text = "Surtidor:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(455, 214);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 38);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // datosDataSet
            // 
            this.datosDataSet.DataSetName = "DatosDataSet";
            this.datosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.datosDataSet;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombustibleTableAdapter = this.combustibleTableAdapter;
            this.tableAdapterManager.DatosEmpleadoTableAdapter = null;
            this.tableAdapterManager.DatosTransporteTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.TransporteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combustibleTableAdapter
            // 
            this.combustibleTableAdapter.ClearBeforeFill = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(122, 31);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 22;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(122, 57);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 24;
            // 
            // fuelTextBox
            // 
            this.fuelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Fuel", true));
            this.fuelTextBox.Location = new System.Drawing.Point(122, 83);
            this.fuelTextBox.Name = "fuelTextBox";
            this.fuelTextBox.ReadOnly = true;
            this.fuelTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelTextBox.TabIndex = 26;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(122, 109);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 28;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(122, 135);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 30;
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.combustibleDataGridView.DataSource = this.combustibleBindingSource;
            this.combustibleDataGridView.Location = new System.Drawing.Point(250, 31);
            this.combustibleDataGridView.Name = "combustibleDataGridView";
            this.combustibleDataGridView.ReadOnly = true;
            this.combustibleDataGridView.Size = new System.Drawing.Size(344, 133);
            this.combustibleDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fuel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fuel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn3.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // fuelTextBox1
            // 
            this.fuelTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combustibleBindingSource, "Fuel", true));
            this.fuelTextBox1.Location = new System.Drawing.Point(266, 170);
            this.fuelTextBox1.Name = "fuelTextBox1";
            this.fuelTextBox1.ReadOnly = true;
            this.fuelTextBox1.Size = new System.Drawing.Size(100, 20);
            this.fuelTextBox1.TabIndex = 31;
            this.fuelTextBox1.TextChanged += new System.EventHandler(this.fuelTextBox1_TextChanged);
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combustibleBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(372, 170);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockTextBox.TabIndex = 32;
            // 
            // precioTextBox1
            // 
            this.precioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combustibleBindingSource, "Precio", true));
            this.precioTextBox1.Location = new System.Drawing.Point(478, 170);
            this.precioTextBox1.Name = "precioTextBox1";
            this.precioTextBox1.ReadOnly = true;
            this.precioTextBox1.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox1.TabIndex = 33;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorAddNewItem.MouseLeave += new System.EventHandler(this.bindingNavigatorAddNewItem_MouseLeave);
            this.bindingNavigatorAddNewItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorAddNewItem_MouseUp);
            // 
            // empleadoBindingNavigatorSaveItem
            // 
            this.empleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoBindingNavigatorSaveItem.Image")));
            this.empleadoBindingNavigatorSaveItem.Name = "empleadoBindingNavigatorSaveItem";
            this.empleadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empleadoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.empleadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.empleadoBindingNavigatorSaveItem_Click);
            // 
            // empleadoBindingNavigator
            // 
            this.empleadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadoBindingNavigator.BindingSource = this.empleadoBindingSource;
            this.empleadoBindingNavigator.CountItem = null;
            this.empleadoBindingNavigator.DeleteItem = null;
            this.empleadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.empleadoBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.empleadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empleadoBindingNavigator.MoveFirstItem = null;
            this.empleadoBindingNavigator.MoveLastItem = null;
            this.empleadoBindingNavigator.MoveNextItem = null;
            this.empleadoBindingNavigator.MovePreviousItem = null;
            this.empleadoBindingNavigator.Name = "empleadoBindingNavigator";
            this.empleadoBindingNavigator.PositionItem = null;
            this.empleadoBindingNavigator.Size = new System.Drawing.Size(603, 25);
            this.empleadoBindingNavigator.TabIndex = 19;
            this.empleadoBindingNavigator.Text = "bindingNavigator1";
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
            // surtidorTextBox
            // 
            this.surtidorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Surtidor", true));
            this.surtidorTextBox.Location = new System.Drawing.Point(122, 163);
            this.surtidorTextBox.Name = "surtidorTextBox";
            this.surtidorTextBox.ReadOnly = true;
            this.surtidorTextBox.Size = new System.Drawing.Size(100, 20);
            this.surtidorTextBox.TabIndex = 34;
            // 
            // Surtidor1
            // 
            this.Surtidor1.Location = new System.Drawing.Point(30, 193);
            this.Surtidor1.Name = "Surtidor1";
            this.Surtidor1.Size = new System.Drawing.Size(75, 23);
            this.Surtidor1.TabIndex = 35;
            this.Surtidor1.Text = "Surtidor 1";
            this.Surtidor1.UseVisualStyleBackColor = true;
            this.Surtidor1.Click += new System.EventHandler(this.Surtidor1_Click);
            // 
            // Surtidor2
            // 
            this.Surtidor2.Location = new System.Drawing.Point(122, 193);
            this.Surtidor2.Name = "Surtidor2";
            this.Surtidor2.Size = new System.Drawing.Size(75, 23);
            this.Surtidor2.TabIndex = 36;
            this.Surtidor2.Text = "Surtidor 2";
            this.Surtidor2.UseVisualStyleBackColor = true;
            this.Surtidor2.Click += new System.EventHandler(this.Surtidor2_Click);
            // 
            // Surtidor3
            // 
            this.Surtidor3.Location = new System.Drawing.Point(30, 229);
            this.Surtidor3.Name = "Surtidor3";
            this.Surtidor3.Size = new System.Drawing.Size(75, 23);
            this.Surtidor3.TabIndex = 37;
            this.Surtidor3.Text = "Surtidor 3";
            this.Surtidor3.UseVisualStyleBackColor = true;
            this.Surtidor3.Click += new System.EventHandler(this.Surtidor3_Click);
            // 
            // Surtidor4
            // 
            this.Surtidor4.Location = new System.Drawing.Point(122, 229);
            this.Surtidor4.Name = "Surtidor4";
            this.Surtidor4.Size = new System.Drawing.Size(75, 23);
            this.Surtidor4.TabIndex = 38;
            this.Surtidor4.Text = "Surtidor 4";
            this.Surtidor4.UseVisualStyleBackColor = true;
            this.Surtidor4.Click += new System.EventHandler(this.Surtidor4_Click);
            // 
            // FormDescarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 268);
            this.Controls.Add(this.Surtidor4);
            this.Controls.Add(this.Surtidor3);
            this.Controls.Add(this.Surtidor2);
            this.Controls.Add(this.Surtidor1);
            this.Controls.Add(surtidorLabel);
            this.Controls.Add(this.surtidorTextBox);
            this.Controls.Add(this.precioTextBox1);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.fuelTextBox1);
            this.Controls.Add(this.combustibleDataGridView);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fuelLabel);
            this.Controls.Add(this.fuelTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.empleadoBindingNavigator);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDescarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descarga de Combustible";
            this.Load += new System.EventHandler(this.FormDescarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).EndInit();
            this.empleadoBindingNavigator.ResumeLayout(false);
            this.empleadoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private DatosDataSet datosDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DatosDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private DatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox fuelTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private DatosDataSetTableAdapters.CombustibleTableAdapter combustibleTableAdapter;
        private System.Windows.Forms.BindingSource combustibleBindingSource;
        private System.Windows.Forms.DataGridView combustibleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox fuelTextBox1;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox precioTextBox1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton empleadoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator empleadoBindingNavigator;
        private System.Windows.Forms.TextBox surtidorTextBox;
        private System.Windows.Forms.Button Surtidor1;
        private System.Windows.Forms.Button Surtidor2;
        private System.Windows.Forms.Button Surtidor3;
        private System.Windows.Forms.Button Surtidor4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}