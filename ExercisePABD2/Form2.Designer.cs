namespace ExercisePABD2
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adminitrasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perpustakaanDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perpustakaanDataSet1 = new ExercisePABD2.PerpustakaanDataSet1();
            this.perpustakaanDataSet = new ExercisePABD2.PerpustakaanDataSet();
            this.perpustakaanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adminitrasi,
            this.Anggota,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.DataSource = this.perpustakaanDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Adminitrasi
            // 
            this.Adminitrasi.HeaderText = "Administrasi";
            this.Adminitrasi.MinimumWidth = 6;
            this.Adminitrasi.Name = "Adminitrasi";
            this.Adminitrasi.Width = 125;
            // 
            // Anggota
            // 
            this.Anggota.HeaderText = "Nama";
            this.Anggota.MinimumWidth = 6;
            this.Anggota.Name = "Anggota";
            this.Anggota.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // perpustakaanDataSet1BindingSource
            // 
            this.perpustakaanDataSet1BindingSource.DataSource = this.perpustakaanDataSet1;
            this.perpustakaanDataSet1BindingSource.Position = 0;
            // 
            // perpustakaanDataSet1
            // 
            this.perpustakaanDataSet1.DataSetName = "PerpustakaanDataSet1";
            this.perpustakaanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "PerpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perpustakaanDataSetBindingSource
            // 
            this.perpustakaanDataSetBindingSource.DataSource = this.perpustakaanDataSet;
            this.perpustakaanDataSetBindingSource.Position = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource perpustakaanDataSetBindingSource;
        private PerpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource perpustakaanDataSet1BindingSource;
        private PerpustakaanDataSet1 perpustakaanDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adminitrasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}