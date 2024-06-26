namespace WinFormsAppInventarioBásico
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
            labelTitulo = new Label();
            groupBoxRegistro = new GroupBox();
            labelInfo = new Label();
            dataGridView1 = new DataGridView();
            ColumnProductos = new DataGridViewTextBoxColumn();
            ColumnCantidades = new DataGridViewTextBoxColumn();
            textBoxCantidades = new TextBox();
            textBoxProductos = new TextBox();
            buttonSalida = new Button();
            buttonEliminar = new Button();
            buttonAgregar = new Button();
            labelStock = new Label();
            labelProducto = new Label();
            groupBoxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Consolas", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(98, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(219, 43);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Inventario";
            // 
            // groupBoxRegistro
            // 
            groupBoxRegistro.BackColor = Color.Transparent;
            groupBoxRegistro.Controls.Add(labelInfo);
            groupBoxRegistro.Controls.Add(dataGridView1);
            groupBoxRegistro.Controls.Add(textBoxCantidades);
            groupBoxRegistro.Controls.Add(textBoxProductos);
            groupBoxRegistro.Controls.Add(buttonSalida);
            groupBoxRegistro.Controls.Add(buttonEliminar);
            groupBoxRegistro.Controls.Add(buttonAgregar);
            groupBoxRegistro.Controls.Add(labelStock);
            groupBoxRegistro.Controls.Add(labelProducto);
            groupBoxRegistro.Font = new Font("Consolas", 12F);
            groupBoxRegistro.Location = new Point(-5, 85);
            groupBoxRegistro.Name = "groupBoxRegistro";
            groupBoxRegistro.Size = new Size(467, 508);
            groupBoxRegistro.TabIndex = 1;
            groupBoxRegistro.TabStop = false;
            groupBoxRegistro.Text = "Registro de datos";
            groupBoxRegistro.Enter += groupBoxRegistro_Enter;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(38, 189);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(63, 19);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnProductos, ColumnCantidades });
            dataGridView1.Location = new Point(29, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 165);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ColumnProductos
            // 
            ColumnProductos.HeaderText = "Nombre del producto";
            ColumnProductos.Name = "ColumnProductos";
            // 
            // ColumnCantidades
            // 
            ColumnCantidades.HeaderText = "Unidades en Stock";
            ColumnCantidades.Name = "ColumnCantidades";
            // 
            // textBoxCantidades
            // 
            textBoxCantidades.Location = new Point(287, 99);
            textBoxCantidades.Name = "textBoxCantidades";
            textBoxCantidades.Size = new Size(127, 26);
            textBoxCantidades.TabIndex = 8;
            // 
            // textBoxProductos
            // 
            textBoxProductos.Location = new Point(287, 45);
            textBoxProductos.Name = "textBoxProductos";
            textBoxProductos.Size = new Size(127, 26);
            textBoxProductos.TabIndex = 7;
            // 
            // buttonSalida
            // 
            buttonSalida.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalida.ForeColor = Color.Red;
            buttonSalida.Location = new Point(188, 436);
            buttonSalida.Name = "buttonSalida";
            buttonSalida.Size = new Size(96, 38);
            buttonSalida.TabIndex = 6;
            buttonSalida.Text = "Salir";
            buttonSalida.UseVisualStyleBackColor = true;
            buttonSalida.Click += buttonSalida_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(356, 287);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(96, 38);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregar.Location = new Point(356, 189);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(96, 36);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(6, 99);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(90, 19);
            labelStock.TabIndex = 3;
            labelStock.Text = "Cantidad:";
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Location = new Point(6, 45);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(90, 19);
            labelProducto.TabIndex = 2;
            labelProducto.Text = "Producto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Aquanene_de_sistemas;
            ClientSize = new Size(459, 591);
            Controls.Add(groupBoxRegistro);
            Controls.Add(labelTitulo);
            Name = "Form1";
            Text = "Form1";
            groupBoxRegistro.ResumeLayout(false);
            groupBoxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private GroupBox groupBoxRegistro;
        private Label labelStock;
        private Label labelProducto;
        private Button buttonSalida;
        private Button buttonEliminar;
        private Button buttonAgregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnProductos;
        private DataGridViewTextBoxColumn ColumnCantidades;
        private TextBox textBoxCantidades;
        private TextBox textBoxProductos;
        private Label labelInfo;
    }
}
