
namespace ProyectostacionServicio
{
    partial class FormReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            this.btnVolver = new System.Windows.Forms.Button();
            this.transporteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosDataSet = new ProyectostacionServicio.DatosDataSet();
            this.empleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transporteTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.TransporteTableAdapter();
            this.tableAdapterManager = new ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager();
            this.empleadoTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.EmpleadoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filtradochofer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrarChofer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.filtradofuel = new System.Windows.Forms.TextBox();
            this.btnFiltrarFuel = new System.Windows.Forms.Button();
            this.btnFiltrarCantidad = new System.Windows.Forms.Button();
            this.filtradocantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surtidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.filtradoOpcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.filtradoValor = new System.Windows.Forms.TextBox();
            this.btnFiltrarGenerico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transporteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(516, 520);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 38);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // transporteDataGridView
            // 
            this.transporteDataGridView.AllowUserToAddRows = false;
            this.transporteDataGridView.AllowUserToDeleteRows = false;
            this.transporteDataGridView.AutoGenerateColumns = false;
            this.transporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transporteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.transporteDataGridView.DataSource = this.transporteBindingSource;
            this.transporteDataGridView.Location = new System.Drawing.Point(12, 338);
            this.transporteDataGridView.Name = "transporteDataGridView";
            this.transporteDataGridView.ReadOnly = true;
            this.transporteDataGridView.Size = new System.Drawing.Size(448, 220);
            this.transporteDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Chofer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Chofer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fuel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fuel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // transporteBindingSource
            // 
            this.transporteBindingSource.DataMember = "Transporte";
            this.transporteBindingSource.DataSource = this.datosDataSet;
            // 
            // datosDataSet
            // 
            this.datosDataSet.DataSetName = "DatosDataSet";
            this.datosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoDataGridView
            // 
            this.empleadoDataGridView.AllowUserToAddRows = false;
            this.empleadoDataGridView.AllowUserToDeleteRows = false;
            this.empleadoDataGridView.AutoGenerateColumns = false;
            this.empleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Surtidor,
            this.dataGridViewTextBoxColumn10});
            this.empleadoDataGridView.DataSource = this.empleadoBindingSource;
            this.empleadoDataGridView.Location = new System.Drawing.Point(12, 80);
            this.empleadoDataGridView.Name = "empleadoDataGridView";
            this.empleadoDataGridView.ReadOnly = true;
            this.empleadoDataGridView.Size = new System.Drawing.Size(651, 220);
            this.empleadoDataGridView.TabIndex = 19;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.datosDataSet;
            // 
            // transporteTableAdapter
            // 
            this.transporteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombustibleTableAdapter = null;
            this.tableAdapterManager.DatosEmpleadoTableAdapter = null;
            this.tableAdapterManager.DatosTransporteTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.TransporteTableAdapter = this.transporteTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Reporte Empleados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Reporte Entregas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // filtradochofer
            // 
            this.filtradochofer.Location = new System.Drawing.Point(466, 359);
            this.filtradochofer.Name = "filtradochofer";
            this.filtradochofer.Size = new System.Drawing.Size(100, 20);
            this.filtradochofer.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Filtrar por Chofer:";
            // 
            // btnFiltrarChofer
            // 
            this.btnFiltrarChofer.Location = new System.Drawing.Point(582, 359);
            this.btnFiltrarChofer.Name = "btnFiltrarChofer";
            this.btnFiltrarChofer.Size = new System.Drawing.Size(75, 20);
            this.btnFiltrarChofer.TabIndex = 26;
            this.btnFiltrarChofer.Text = "Filtrar";
            this.btnFiltrarChofer.UseVisualStyleBackColor = true;
            this.btnFiltrarChofer.Click += new System.EventHandler(this.btnFiltrarChofer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Filtrar por Fuel:";
            // 
            // filtradofuel
            // 
            this.filtradofuel.Location = new System.Drawing.Point(466, 408);
            this.filtradofuel.Name = "filtradofuel";
            this.filtradofuel.Size = new System.Drawing.Size(100, 20);
            this.filtradofuel.TabIndex = 28;
            // 
            // btnFiltrarFuel
            // 
            this.btnFiltrarFuel.Location = new System.Drawing.Point(582, 408);
            this.btnFiltrarFuel.Name = "btnFiltrarFuel";
            this.btnFiltrarFuel.Size = new System.Drawing.Size(75, 20);
            this.btnFiltrarFuel.TabIndex = 29;
            this.btnFiltrarFuel.Text = "filtrar";
            this.btnFiltrarFuel.UseVisualStyleBackColor = true;
            this.btnFiltrarFuel.Click += new System.EventHandler(this.btnFiltrarFuel_Click);
            // 
            // btnFiltrarCantidad
            // 
            this.btnFiltrarCantidad.Location = new System.Drawing.Point(582, 458);
            this.btnFiltrarCantidad.Name = "btnFiltrarCantidad";
            this.btnFiltrarCantidad.Size = new System.Drawing.Size(75, 20);
            this.btnFiltrarCantidad.TabIndex = 32;
            this.btnFiltrarCantidad.Text = "filtrar";
            this.btnFiltrarCantidad.UseVisualStyleBackColor = true;
            this.btnFiltrarCantidad.Click += new System.EventHandler(this.btnFiltrarCantidad_Click);
            // 
            // filtradocantidad
            // 
            this.filtradocantidad.Location = new System.Drawing.Point(466, 458);
            this.filtradocantidad.Name = "filtradocantidad";
            this.filtradocantidad.Size = new System.Drawing.Size(100, 20);
            this.filtradocantidad.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Filtrar por Cantidad:";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Surtidor
            // 
            this.Surtidor.DataPropertyName = "Surtidor";
            this.Surtidor.HeaderText = "Surtidor";
            this.Surtidor.Name = "Surtidor";
            this.Surtidor.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn10.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Filtrar por...";
            // 
            // filtradoOpcion
            // 
            this.filtradoOpcion.Location = new System.Drawing.Point(731, 73);
            this.filtradoOpcion.Name = "filtradoOpcion";
            this.filtradoOpcion.Size = new System.Drawing.Size(100, 20);
            this.filtradoOpcion.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Valor:";
            // 
            // filtradoValor
            // 
            this.filtradoValor.Location = new System.Drawing.Point(731, 113);
            this.filtradoValor.Name = "filtradoValor";
            this.filtradoValor.Size = new System.Drawing.Size(100, 20);
            this.filtradoValor.TabIndex = 36;
            // 
            // btnFiltrarGenerico
            // 
            this.btnFiltrarGenerico.Location = new System.Drawing.Point(756, 153);
            this.btnFiltrarGenerico.Name = "btnFiltrarGenerico";
            this.btnFiltrarGenerico.Size = new System.Drawing.Size(75, 20);
            this.btnFiltrarGenerico.TabIndex = 37;
            this.btnFiltrarGenerico.Text = "Filtrar";
            this.btnFiltrarGenerico.UseVisualStyleBackColor = true;
            this.btnFiltrarGenerico.Click += new System.EventHandler(this.btnFiltrarGenerico_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 587);
            this.Controls.Add(this.btnFiltrarGenerico);
            this.Controls.Add(this.filtradoValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.filtradoOpcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFiltrarCantidad);
            this.Controls.Add(this.filtradocantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFiltrarFuel);
            this.Controls.Add(this.filtradofuel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFiltrarChofer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filtradochofer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empleadoDataGridView);
            this.Controls.Add(this.transporteDataGridView);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Movimientos";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transporteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private DatosDataSet datosDataSet;
        private System.Windows.Forms.BindingSource transporteBindingSource;
        private DatosDataSetTableAdapters.TransporteTableAdapter transporteTableAdapter;
        private DatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView transporteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DatosDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridView empleadoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox filtradochofer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrarChofer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filtradofuel;
        private System.Windows.Forms.Button btnFiltrarFuel;
        private System.Windows.Forms.Button btnFiltrarCantidad;
        private System.Windows.Forms.TextBox filtradocantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surtidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filtradoOpcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox filtradoValor;
        private System.Windows.Forms.Button btnFiltrarGenerico;
    }
}