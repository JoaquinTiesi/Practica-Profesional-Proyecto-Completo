
namespace ProyectostacionServicio
{
    partial class FormLogDescarga
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
            this.datosEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosEmpleadoTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.DatosEmpleadoTableAdapter();
            this.tableAdapterManager = new ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager();
            this.datosEmpleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosEmpleadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // datosDataSet
            // 
            this.datosDataSet.DataSetName = "DatosDataSet";
            this.datosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosEmpleadoBindingSource
            // 
            this.datosEmpleadoBindingSource.DataMember = "DatosEmpleado";
            this.datosEmpleadoBindingSource.DataSource = this.datosDataSet;
            // 
            // datosEmpleadoTableAdapter
            // 
            this.datosEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombustibleTableAdapter = null;
            this.tableAdapterManager.DatosEmpleadoTableAdapter = this.datosEmpleadoTableAdapter;
            this.tableAdapterManager.DatosTransporteTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.TransporteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datosEmpleadoDataGridView
            // 
            this.datosEmpleadoDataGridView.AllowUserToAddRows = false;
            this.datosEmpleadoDataGridView.AllowUserToDeleteRows = false;
            this.datosEmpleadoDataGridView.AutoGenerateColumns = false;
            this.datosEmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosEmpleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.datosEmpleadoDataGridView.DataSource = this.datosEmpleadoBindingSource;
            this.datosEmpleadoDataGridView.Location = new System.Drawing.Point(12, 12);
            this.datosEmpleadoDataGridView.Name = "datosEmpleadoDataGridView";
            this.datosEmpleadoDataGridView.ReadOnly = true;
            this.datosEmpleadoDataGridView.Size = new System.Drawing.Size(246, 220);
            this.datosEmpleadoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
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
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpleadoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(264, 12);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(10, 20);
            this.nombreTextBox.TabIndex = 2;
            this.nombreTextBox.UseSystemPasswordChar = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpleadoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(264, 48);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(10, 20);
            this.codigoTextBox.TabIndex = 4;
            this.codigoTextBox.UseSystemPasswordChar = true;
            // 
            // passTextBox
            // 
            this.passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosEmpleadoBindingSource, "pass", true));
            this.passTextBox.Location = new System.Drawing.Point(264, 89);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(10, 20);
            this.passTextBox.TabIndex = 6;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(119, 344);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 38);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(146, 274);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(112, 30);
            this.btnLog.TabIndex = 23;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingrese su Contraseña:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(132, 248);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(126, 20);
            this.pass.TabIndex = 24;
            // 
            // FormLogDescarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.datosEmpleadoDataGridView);
            this.Name = "FormLogDescarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogDescarga";
            this.Load += new System.EventHandler(this.FormLogDescarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosEmpleadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatosDataSet datosDataSet;
        private System.Windows.Forms.BindingSource datosEmpleadoBindingSource;
        private DatosDataSetTableAdapters.DatosEmpleadoTableAdapter datosEmpleadoTableAdapter;
        private DatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView datosEmpleadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass;
    }
}