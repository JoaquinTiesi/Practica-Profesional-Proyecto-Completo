
namespace ProyectostacionServicio
{
    partial class FormLogCarga
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
            this.datosDataSet = new ProyectostacionServicio.DatosDataSet();
            this.datosTransporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosTransporteTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.DatosTransporteTableAdapter();
            this.tableAdapterManager = new ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager();
            this.datosTransporteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.choferTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTransporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTransporteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // datosDataSet
            // 
            this.datosDataSet.DataSetName = "DatosDataSet";
            this.datosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosTransporteBindingSource
            // 
            this.datosTransporteBindingSource.DataMember = "DatosTransporte";
            this.datosTransporteBindingSource.DataSource = this.datosDataSet;
            // 
            // datosTransporteTableAdapter
            // 
            this.datosTransporteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombustibleTableAdapter = null;
            this.tableAdapterManager.DatosEmpleadoTableAdapter = null;
            this.tableAdapterManager.DatosTransporteTableAdapter = this.datosTransporteTableAdapter;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.TransporteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datosTransporteDataGridView
            // 
            this.datosTransporteDataGridView.AllowUserToAddRows = false;
            this.datosTransporteDataGridView.AllowUserToDeleteRows = false;
            this.datosTransporteDataGridView.AutoGenerateColumns = false;
            this.datosTransporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosTransporteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.datosTransporteDataGridView.DataSource = this.datosTransporteBindingSource;
            this.datosTransporteDataGridView.Location = new System.Drawing.Point(11, 12);
            this.datosTransporteDataGridView.Name = "datosTransporteDataGridView";
            this.datosTransporteDataGridView.ReadOnly = true;
            this.datosTransporteDataGridView.Size = new System.Drawing.Size(245, 220);
            this.datosTransporteDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Chofer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Chofer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // passTextBox
            // 
            this.passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosTransporteBindingSource, "pass", true));
            this.passTextBox.Location = new System.Drawing.Point(262, 12);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.ReadOnly = true;
            this.passTextBox.Size = new System.Drawing.Size(10, 20);
            this.passTextBox.TabIndex = 5;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(130, 250);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(126, 20);
            this.pass.TabIndex = 6;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(117, 351);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 38);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(144, 276);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(112, 30);
            this.btnLog.TabIndex = 22;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ingrese su Contraseña:";
            // 
            // choferTextBox
            // 
            this.choferTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosTransporteBindingSource, "Chofer", true));
            this.choferTextBox.Location = new System.Drawing.Point(262, 38);
            this.choferTextBox.Name = "choferTextBox";
            this.choferTextBox.Size = new System.Drawing.Size(10, 20);
            this.choferTextBox.TabIndex = 24;
            this.choferTextBox.UseSystemPasswordChar = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosTransporteBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(262, 64);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(10, 20);
            this.codigoTextBox.TabIndex = 25;
            this.codigoTextBox.UseSystemPasswordChar = true;
            // 
            // FormLogCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 409);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.choferTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.datosTransporteDataGridView);
            this.Name = "FormLogCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogCarga";
            this.Load += new System.EventHandler(this.FormLogCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTransporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosTransporteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatosDataSet datosDataSet;
        private System.Windows.Forms.BindingSource datosTransporteBindingSource;
        private DatosDataSetTableAdapters.DatosTransporteTableAdapter datosTransporteTableAdapter;
        private DatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView datosTransporteDataGridView;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox choferTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
    }
}