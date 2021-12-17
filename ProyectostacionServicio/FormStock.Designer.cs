
namespace ProyectostacionServicio
{
    partial class FormStock
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
            System.Windows.Forms.Label stockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.btnVolver = new System.Windows.Forms.Button();
            this.datosDataSet = new ProyectostacionServicio.DatosDataSet();
            this.combustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combustibleTableAdapter = new ProyectostacionServicio.DatosDataSetTableAdapters.CombustibleTableAdapter();
            this.tableAdapterManager = new ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.combustibleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(211, 104);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(108, 13);
            stockLabel.TabIndex = 23;
            stockLabel.Text = "Nivel de combustible:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(248, 146);
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
            // combustibleBindingSource
            // 
            this.combustibleBindingSource.DataMember = "Combustible";
            this.combustibleBindingSource.DataSource = this.datosDataSet;
            // 
            // combustibleTableAdapter
            // 
            this.combustibleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombustibleTableAdapter = this.combustibleTableAdapter;
            this.tableAdapterManager.DatosEmpleadoTableAdapter = null;
            this.tableAdapterManager.DatosTransporteTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.TransporteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectostacionServicio.DatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combustibleBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(214, 120);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockTextBox.TabIndex = 24;
            // 
            // combustibleDataGridView
            // 
            this.combustibleDataGridView.AllowUserToAddRows = false;
            this.combustibleDataGridView.AllowUserToDeleteRows = false;
            this.combustibleDataGridView.AutoGenerateColumns = false;
            this.combustibleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combustibleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.combustibleDataGridView.DataSource = this.combustibleBindingSource;
            this.combustibleDataGridView.Location = new System.Drawing.Point(12, 46);
            this.combustibleDataGridView.Name = "combustibleDataGridView";
            this.combustibleDataGridView.ReadOnly = true;
            this.combustibleDataGridView.Size = new System.Drawing.Size(143, 116);
            this.combustibleDataGridView.TabIndex = 24;
            this.combustibleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.combustibleDataGridView_CellClick);
            this.combustibleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.combustibleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fuel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fuel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // barraProgreso
            // 
            this.barraProgreso.Location = new System.Drawing.Point(161, 46);
            this.barraProgreso.Maximum = 10000;
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgreso.Size = new System.Drawing.Size(225, 34);
            this.barraProgreso.Step = 1;
            this.barraProgreso.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "0 lts <------------------> 10000 lts";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 201);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combustibleDataGridView);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock de Combustible";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combustibleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private DatosDataSet datosDataSet;
        private System.Windows.Forms.BindingSource combustibleBindingSource;
        private DatosDataSetTableAdapters.CombustibleTableAdapter combustibleTableAdapter;
        private DatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.DataGridView combustibleDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Label label10;
    }
}