namespace ListasDoblesOrdenAlfabetico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grConsulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.chkDescendente = new System.Windows.Forms.CheckBox();
            this.cboCategoriaConsulta = new System.Windows.Forms.ComboBox();
            this.txtPrecioConsulta = new System.Windows.Forms.TextBox();
            this.optCategoria = new System.Windows.Forms.RadioButton();
            this.optPrecio = new System.Windows.Forms.RadioButton();
            this.optTodos = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(27, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 33);
            this.txtID.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(178, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(256, 33);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(656, 81);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 33);
            this.txtPrecio.TabIndex = 6;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(495, 81);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(94, 33);
            this.cboCategoria.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grConsulta);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.chkDescendente);
            this.groupBox1.Controls.Add(this.cboCategoriaConsulta);
            this.groupBox1.Controls.Add(this.txtPrecioConsulta);
            this.groupBox1.Controls.Add(this.optCategoria);
            this.groupBox1.Controls.Add(this.optPrecio);
            this.groupBox1.Controls.Add(this.optTodos);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 302);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grConsulta
            // 
            this.grConsulta.AllowUserToAddRows = false;
            this.grConsulta.AllowUserToDeleteRows = false;
            this.grConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grConsulta.Location = new System.Drawing.Point(60, 116);
            this.grConsulta.Name = "grConsulta";
            this.grConsulta.ReadOnly = true;
            this.grConsulta.RowHeadersVisible = false;
            this.grConsulta.RowTemplate.Height = 25;
            this.grConsulta.Size = new System.Drawing.Size(756, 170);
            this.grConsulta.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoria";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(764, 39);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 36);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chkDescendente
            // 
            this.chkDescendente.AutoSize = true;
            this.chkDescendente.Location = new System.Drawing.Point(570, 48);
            this.chkDescendente.Name = "chkDescendente";
            this.chkDescendente.Size = new System.Drawing.Size(140, 29);
            this.chkDescendente.TabIndex = 10;
            this.chkDescendente.Text = "Descendente";
            this.chkDescendente.UseVisualStyleBackColor = true;
            // 
            // cboCategoriaConsulta
            // 
            this.cboCategoriaConsulta.FormattingEnabled = true;
            this.cboCategoriaConsulta.Location = new System.Drawing.Point(435, 45);
            this.cboCategoriaConsulta.Name = "cboCategoriaConsulta";
            this.cboCategoriaConsulta.Size = new System.Drawing.Size(94, 33);
            this.cboCategoriaConsulta.TabIndex = 9;
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.Location = new System.Drawing.Point(264, 46);
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.Size = new System.Drawing.Size(100, 33);
            this.txtPrecioConsulta.TabIndex = 9;
            // 
            // optCategoria
            // 
            this.optCategoria.AutoSize = true;
            this.optCategoria.Location = new System.Drawing.Point(403, 53);
            this.optCategoria.Name = "optCategoria";
            this.optCategoria.Size = new System.Drawing.Size(14, 13);
            this.optCategoria.TabIndex = 2;
            this.optCategoria.TabStop = true;
            this.optCategoria.UseVisualStyleBackColor = true;
            // 
            // optPrecio
            // 
            this.optPrecio.AutoSize = true;
            this.optPrecio.Location = new System.Drawing.Point(149, 46);
            this.optPrecio.Name = "optPrecio";
            this.optPrecio.Size = new System.Drawing.Size(109, 29);
            this.optPrecio.TabIndex = 1;
            this.optPrecio.TabStop = true;
            this.optPrecio.Text = "Precios >";
            this.optPrecio.UseVisualStyleBackColor = true;
            // 
            // optTodos
            // 
            this.optTodos.AutoSize = true;
            this.optTodos.Location = new System.Drawing.Point(24, 46);
            this.optTodos.Name = "optTodos";
            this.optTodos.Size = new System.Drawing.Size(79, 29);
            this.optTodos.TabIndex = 0;
            this.optTodos.TabStop = true;
            this.optTodos.Text = "Todos";
            this.optTodos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private ComboBox cboCategoria;
        private GroupBox groupBox1;
        private DataGridView grConsulta;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnConsultar;
        private CheckBox chkDescendente;
        private ComboBox cboCategoriaConsulta;
        private TextBox txtPrecioConsulta;
        private RadioButton optCategoria;
        private RadioButton optPrecio;
        private RadioButton optTodos;
        private Button button1;
    }
}