namespace Prototipo
{
    partial class DeclaracionF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeclaracionF));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.transparentPanel1 = new Prototipo.TransparentPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dragControl1 = new Prototipo.DragControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declaracionfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dospDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declaraciónFiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.el_Pana_MiguelDataSet4 = new Prototipo.El_Pana_MiguelDataSet4();
            this.declaración_fiscalTableAdapter = new Prototipo.El_Pana_MiguelDataSet4TableAdapters.declaración_fiscalTableAdapter();
            this.fecha_In = new System.Windows.Forms.DateTimePicker();
            this.fecha_Fn = new System.Windows.Forms.DateTimePicker();
            this.dospor = new System.Windows.Forms.DateTimePicker();
            this.seguros = new System.Windows.Forms.DateTimePicker();
            this.declaracion = new System.Windows.Forms.DateTimePicker();
            this.dragControl2 = new Prototipo.DragControl();
            this.transparentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaraciónFiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Pana_MiguelDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(34, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 50);
            this.label7.TabIndex = 49;
            this.label7.Text = "Declaración Fiscal";
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Controls.Add(this.button1);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(900, 49);
            this.transparentPanel1.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(849, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectoControl = this.transparentPanel1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID del Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Feca de creación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Fecha de caducidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Declaración:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Seguro social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Dos porciento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Prototipo.Properties.Resources.firma1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(672, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 216);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Prototipo.Properties.Resources.no_hover;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(171, 580);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 52);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Prototipo.Properties.Resources.ok_hover;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(34, 580);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientesDataGridViewTextBoxColumn,
            this.fechainDataGridViewTextBoxColumn,
            this.fechafnDataGridViewTextBoxColumn,
            this.declaracionfDataGridViewTextBoxColumn,
            this.segurosDataGridViewTextBoxColumn,
            this.dospDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.declaraciónFiscalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(245, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 305);
            this.dataGridView1.TabIndex = 66;
            // 
            // idclientesDataGridViewTextBoxColumn
            // 
            this.idclientesDataGridViewTextBoxColumn.DataPropertyName = "id_clientes";
            this.idclientesDataGridViewTextBoxColumn.HeaderText = "id_clientes";
            this.idclientesDataGridViewTextBoxColumn.Name = "idclientesDataGridViewTextBoxColumn";
            // 
            // fechainDataGridViewTextBoxColumn
            // 
            this.fechainDataGridViewTextBoxColumn.DataPropertyName = "fecha_in";
            this.fechainDataGridViewTextBoxColumn.HeaderText = "fecha_in";
            this.fechainDataGridViewTextBoxColumn.Name = "fechainDataGridViewTextBoxColumn";
            // 
            // fechafnDataGridViewTextBoxColumn
            // 
            this.fechafnDataGridViewTextBoxColumn.DataPropertyName = "fecha_fn";
            this.fechafnDataGridViewTextBoxColumn.HeaderText = "fecha_fn";
            this.fechafnDataGridViewTextBoxColumn.Name = "fechafnDataGridViewTextBoxColumn";
            // 
            // declaracionfDataGridViewTextBoxColumn
            // 
            this.declaracionfDataGridViewTextBoxColumn.DataPropertyName = "declaracion_f";
            this.declaracionfDataGridViewTextBoxColumn.HeaderText = "declaracion_f";
            this.declaracionfDataGridViewTextBoxColumn.Name = "declaracionfDataGridViewTextBoxColumn";
            // 
            // segurosDataGridViewTextBoxColumn
            // 
            this.segurosDataGridViewTextBoxColumn.DataPropertyName = "seguro_s";
            this.segurosDataGridViewTextBoxColumn.HeaderText = "seguro_s";
            this.segurosDataGridViewTextBoxColumn.Name = "segurosDataGridViewTextBoxColumn";
            // 
            // dospDataGridViewTextBoxColumn
            // 
            this.dospDataGridViewTextBoxColumn.DataPropertyName = "dos_p";
            this.dospDataGridViewTextBoxColumn.HeaderText = "dos_p";
            this.dospDataGridViewTextBoxColumn.Name = "dospDataGridViewTextBoxColumn";
            // 
            // declaraciónFiscalBindingSource
            // 
            this.declaraciónFiscalBindingSource.DataMember = "declaración fiscal";
            this.declaraciónFiscalBindingSource.DataSource = this.el_Pana_MiguelDataSet4;
            // 
            // el_Pana_MiguelDataSet4
            // 
            this.el_Pana_MiguelDataSet4.DataSetName = "El_Pana_MiguelDataSet4";
            this.el_Pana_MiguelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // declaración_fiscalTableAdapter
            // 
            this.declaración_fiscalTableAdapter.ClearBeforeFill = true;
            // 
            // fecha_In
            // 
            this.fecha_In.Location = new System.Drawing.Point(34, 258);
            this.fecha_In.Name = "fecha_In";
            this.fecha_In.Size = new System.Drawing.Size(189, 20);
            this.fecha_In.TabIndex = 68;
            // 
            // fecha_Fn
            // 
            this.fecha_Fn.Location = new System.Drawing.Point(34, 328);
            this.fecha_Fn.Name = "fecha_Fn";
            this.fecha_Fn.Size = new System.Drawing.Size(189, 20);
            this.fecha_Fn.TabIndex = 69;
            // 
            // dospor
            // 
            this.dospor.Location = new System.Drawing.Point(34, 538);
            this.dospor.Name = "dospor";
            this.dospor.Size = new System.Drawing.Size(189, 20);
            this.dospor.TabIndex = 70;
            // 
            // seguros
            // 
            this.seguros.Location = new System.Drawing.Point(34, 472);
            this.seguros.Name = "seguros";
            this.seguros.Size = new System.Drawing.Size(189, 20);
            this.seguros.TabIndex = 71;
            // 
            // declaracion
            // 
            this.declaracion.Location = new System.Drawing.Point(34, 398);
            this.declaracion.Name = "declaracion";
            this.declaracion.Size = new System.Drawing.Size(189, 20);
            this.declaracion.TabIndex = 72;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectoControl = null;
            // 
            // DeclaracionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.declaracion);
            this.Controls.Add(this.seguros);
            this.Controls.Add(this.dospor);
            this.Controls.Add(this.fecha_Fn);
            this.Controls.Add(this.fecha_In);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeclaracionF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Declaracion Fiscal";
            this.Load += new System.EventHandler(this.DeclaracionF_Load);
            this.transparentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.declaraciónFiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Pana_MiguelDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button button1;
        private DragControl dragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private El_Pana_MiguelDataSet4 el_Pana_MiguelDataSet4;
        private System.Windows.Forms.BindingSource declaraciónFiscalBindingSource;
        private El_Pana_MiguelDataSet4TableAdapters.declaración_fiscalTableAdapter declaración_fiscalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn declaracionfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dospDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker fecha_In;
        private System.Windows.Forms.DateTimePicker fecha_Fn;
        private System.Windows.Forms.DateTimePicker dospor;
        private System.Windows.Forms.DateTimePicker seguros;
        private System.Windows.Forms.DateTimePicker declaracion;
        private DragControl dragControl2;
    }
}