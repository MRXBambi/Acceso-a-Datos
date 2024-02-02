namespace WinFormsApp1
{
    partial class form1
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
            dataGridView1 = new DataGridView();
            btnObtener_Usuario = new Button();
            rdbtnUsuarios = new GroupBox();
            btnCrear_Usuario = new Button();
            btnListar_Usuario = new Button();
            btn_ModificarUsuario = new Button();
            btnEliminar_Usuario = new Button();
            RdbtnProducto = new GroupBox();
            btnEliminar_Producto = new Button();
            btnModificar_Producto = new Button();
            btnListar_Producto = new Button();
            btnCrear_Producto = new Button();
            btnObtener_Producto = new Button();
            rdbtnVentas = new GroupBox();
            btnEliminar_Venta = new Button();
            btnModificar_Venta = new Button();
            btnListar_Venta = new Button();
            btnCrear_Venta = new Button();
            btnObtener_Venta = new Button();
            rdbtnVentaProducto = new GroupBox();
            btnEliminar_ProductoVenta = new Button();
            btnModificar_ProductoVenta = new Button();
            btnListar_ProductoVenta = new Button();
            btnCrear_ProductoVenta = new Button();
            btnObtener_ProductoVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            rdbtnUsuarios.SuspendLayout();
            RdbtnProducto.SuspendLayout();
            rdbtnVentas.SuspendLayout();
            rdbtnVentaProducto.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(427, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnObtener_Usuario
            // 
            btnObtener_Usuario.Location = new Point(6, 22);
            btnObtener_Usuario.Name = "btnObtener_Usuario";
            btnObtener_Usuario.Size = new Size(68, 25);
            btnObtener_Usuario.TabIndex = 1;
            btnObtener_Usuario.Text = "Obtener";
            btnObtener_Usuario.UseVisualStyleBackColor = true;
            // 
            // rdbtnUsuarios
            // 
            rdbtnUsuarios.Controls.Add(btnEliminar_Usuario);
            rdbtnUsuarios.Controls.Add(btn_ModificarUsuario);
            rdbtnUsuarios.Controls.Add(btnListar_Usuario);
            rdbtnUsuarios.Controls.Add(btnCrear_Usuario);
            rdbtnUsuarios.Controls.Add(btnObtener_Usuario);
            rdbtnUsuarios.Location = new Point(25, 34);
            rdbtnUsuarios.Name = "rdbtnUsuarios";
            rdbtnUsuarios.Size = new Size(167, 141);
            rdbtnUsuarios.TabIndex = 2;
            rdbtnUsuarios.TabStop = false;
            rdbtnUsuarios.Text = "Usuarios";
            // 
            // btnCrear_Usuario
            // 
            btnCrear_Usuario.Location = new Point(6, 67);
            btnCrear_Usuario.Name = "btnCrear_Usuario";
            btnCrear_Usuario.Size = new Size(68, 25);
            btnCrear_Usuario.TabIndex = 2;
            btnCrear_Usuario.Text = "Crear";
            btnCrear_Usuario.UseVisualStyleBackColor = true;
            // 
            // btnListar_Usuario
            // 
            btnListar_Usuario.Location = new Point(99, 22);
            btnListar_Usuario.Name = "btnListar_Usuario";
            btnListar_Usuario.Size = new Size(68, 25);
            btnListar_Usuario.TabIndex = 3;
            btnListar_Usuario.Text = "Listar";
            btnListar_Usuario.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarUsuario
            // 
            btn_ModificarUsuario.Location = new Point(99, 67);
            btn_ModificarUsuario.Name = "btn_ModificarUsuario";
            btn_ModificarUsuario.Size = new Size(68, 25);
            btn_ModificarUsuario.TabIndex = 3;
            btn_ModificarUsuario.Text = "Modificar";
            btn_ModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminar_Usuario
            // 
            btnEliminar_Usuario.AllowDrop = true;
            btnEliminar_Usuario.Location = new Point(50, 98);
            btnEliminar_Usuario.Name = "btnEliminar_Usuario";
            btnEliminar_Usuario.Size = new Size(74, 25);
            btnEliminar_Usuario.TabIndex = 4;
            btnEliminar_Usuario.Text = "Eliminar";
            btnEliminar_Usuario.UseVisualStyleBackColor = true;
            // 
            // RdbtnProducto
            // 
            RdbtnProducto.Controls.Add(btnEliminar_Producto);
            RdbtnProducto.Controls.Add(btnModificar_Producto);
            RdbtnProducto.Controls.Add(btnListar_Producto);
            RdbtnProducto.Controls.Add(btnCrear_Producto);
            RdbtnProducto.Controls.Add(btnObtener_Producto);
            RdbtnProducto.Location = new Point(220, 34);
            RdbtnProducto.Name = "RdbtnProducto";
            RdbtnProducto.Size = new Size(161, 141);
            RdbtnProducto.TabIndex = 5;
            RdbtnProducto.TabStop = false;
            RdbtnProducto.Text = "Productos";
            // 
            // btnEliminar_Producto
            // 
            btnEliminar_Producto.AllowDrop = true;
            btnEliminar_Producto.Location = new Point(50, 98);
            btnEliminar_Producto.Name = "btnEliminar_Producto";
            btnEliminar_Producto.Size = new Size(74, 25);
            btnEliminar_Producto.TabIndex = 4;
            btnEliminar_Producto.Text = "Eliminar";
            btnEliminar_Producto.UseVisualStyleBackColor = true;
            // 
            // btnModificar_Producto
            // 
            btnModificar_Producto.Location = new Point(87, 67);
            btnModificar_Producto.Name = "btnModificar_Producto";
            btnModificar_Producto.Size = new Size(68, 25);
            btnModificar_Producto.TabIndex = 3;
            btnModificar_Producto.Text = "Modificar";
            btnModificar_Producto.UseVisualStyleBackColor = true;
            // 
            // btnListar_Producto
            // 
            btnListar_Producto.Location = new Point(87, 22);
            btnListar_Producto.Name = "btnListar_Producto";
            btnListar_Producto.Size = new Size(68, 25);
            btnListar_Producto.TabIndex = 3;
            btnListar_Producto.Text = "Listar";
            btnListar_Producto.UseVisualStyleBackColor = true;
            // 
            // btnCrear_Producto
            // 
            btnCrear_Producto.Location = new Point(6, 67);
            btnCrear_Producto.Name = "btnCrear_Producto";
            btnCrear_Producto.Size = new Size(68, 25);
            btnCrear_Producto.TabIndex = 2;
            btnCrear_Producto.Text = "Crear";
            btnCrear_Producto.UseVisualStyleBackColor = true;
            // 
            // btnObtener_Producto
            // 
            btnObtener_Producto.Location = new Point(6, 22);
            btnObtener_Producto.Name = "btnObtener_Producto";
            btnObtener_Producto.Size = new Size(68, 25);
            btnObtener_Producto.TabIndex = 1;
            btnObtener_Producto.Text = "Obtener";
            btnObtener_Producto.UseVisualStyleBackColor = true;
            // 
            // rdbtnVentas
            // 
            rdbtnVentas.Controls.Add(btnEliminar_Venta);
            rdbtnVentas.Controls.Add(btnModificar_Venta);
            rdbtnVentas.Controls.Add(btnListar_Venta);
            rdbtnVentas.Controls.Add(btnCrear_Venta);
            rdbtnVentas.Controls.Add(btnObtener_Venta);
            rdbtnVentas.Location = new Point(31, 229);
            rdbtnVentas.Name = "rdbtnVentas";
            rdbtnVentas.Size = new Size(161, 141);
            rdbtnVentas.TabIndex = 6;
            rdbtnVentas.TabStop = false;
            rdbtnVentas.Text = "Ventas";
            // 
            // btnEliminar_Venta
            // 
            btnEliminar_Venta.AllowDrop = true;
            btnEliminar_Venta.Location = new Point(50, 98);
            btnEliminar_Venta.Name = "btnEliminar_Venta";
            btnEliminar_Venta.Size = new Size(74, 25);
            btnEliminar_Venta.TabIndex = 4;
            btnEliminar_Venta.Text = "Eliminar";
            btnEliminar_Venta.UseVisualStyleBackColor = true;
            // 
            // btnModificar_Venta
            // 
            btnModificar_Venta.Location = new Point(87, 67);
            btnModificar_Venta.Name = "btnModificar_Venta";
            btnModificar_Venta.Size = new Size(68, 25);
            btnModificar_Venta.TabIndex = 3;
            btnModificar_Venta.Text = "Modificar";
            btnModificar_Venta.UseVisualStyleBackColor = true;
            // 
            // btnListar_Venta
            // 
            btnListar_Venta.Location = new Point(87, 22);
            btnListar_Venta.Name = "btnListar_Venta";
            btnListar_Venta.Size = new Size(68, 25);
            btnListar_Venta.TabIndex = 3;
            btnListar_Venta.Text = "Listar";
            btnListar_Venta.UseVisualStyleBackColor = true;
            // 
            // btnCrear_Venta
            // 
            btnCrear_Venta.Location = new Point(6, 67);
            btnCrear_Venta.Name = "btnCrear_Venta";
            btnCrear_Venta.Size = new Size(68, 25);
            btnCrear_Venta.TabIndex = 2;
            btnCrear_Venta.Text = "Crear";
            btnCrear_Venta.UseVisualStyleBackColor = true;
            // 
            // btnObtener_Venta
            // 
            btnObtener_Venta.Location = new Point(6, 22);
            btnObtener_Venta.Name = "btnObtener_Venta";
            btnObtener_Venta.Size = new Size(68, 25);
            btnObtener_Venta.TabIndex = 1;
            btnObtener_Venta.Text = "Obtener";
            btnObtener_Venta.UseVisualStyleBackColor = true;
            // 
            // rdbtnVentaProducto
            // 
            rdbtnVentaProducto.Controls.Add(btnEliminar_ProductoVenta);
            rdbtnVentaProducto.Controls.Add(btnModificar_ProductoVenta);
            rdbtnVentaProducto.Controls.Add(btnListar_ProductoVenta);
            rdbtnVentaProducto.Controls.Add(btnCrear_ProductoVenta);
            rdbtnVentaProducto.Controls.Add(btnObtener_ProductoVenta);
            rdbtnVentaProducto.Location = new Point(220, 229);
            rdbtnVentaProducto.Name = "rdbtnVentaProducto";
            rdbtnVentaProducto.Size = new Size(161, 141);
            rdbtnVentaProducto.TabIndex = 7;
            rdbtnVentaProducto.TabStop = false;
            rdbtnVentaProducto.Text = "Venta de Producto";
            // 
            // btnEliminar_ProductoVenta
            // 
            btnEliminar_ProductoVenta.AllowDrop = true;
            btnEliminar_ProductoVenta.Location = new Point(50, 98);
            btnEliminar_ProductoVenta.Name = "btnEliminar_ProductoVenta";
            btnEliminar_ProductoVenta.Size = new Size(74, 25);
            btnEliminar_ProductoVenta.TabIndex = 4;
            btnEliminar_ProductoVenta.Text = "Eliminar";
            btnEliminar_ProductoVenta.UseVisualStyleBackColor = true;
            // 
            // btnModificar_ProductoVenta
            // 
            btnModificar_ProductoVenta.Location = new Point(87, 67);
            btnModificar_ProductoVenta.Name = "btnModificar_ProductoVenta";
            btnModificar_ProductoVenta.Size = new Size(68, 25);
            btnModificar_ProductoVenta.TabIndex = 3;
            btnModificar_ProductoVenta.Text = "Modificar";
            btnModificar_ProductoVenta.UseVisualStyleBackColor = true;
            // 
            // btnListar_ProductoVenta
            // 
            btnListar_ProductoVenta.Location = new Point(87, 22);
            btnListar_ProductoVenta.Name = "btnListar_ProductoVenta";
            btnListar_ProductoVenta.Size = new Size(68, 25);
            btnListar_ProductoVenta.TabIndex = 3;
            btnListar_ProductoVenta.Text = "Listar";
            btnListar_ProductoVenta.UseVisualStyleBackColor = true;
            // 
            // btnCrear_ProductoVenta
            // 
            btnCrear_ProductoVenta.Location = new Point(6, 67);
            btnCrear_ProductoVenta.Name = "btnCrear_ProductoVenta";
            btnCrear_ProductoVenta.Size = new Size(68, 25);
            btnCrear_ProductoVenta.TabIndex = 2;
            btnCrear_ProductoVenta.Text = "Crear";
            btnCrear_ProductoVenta.UseVisualStyleBackColor = true;
            // 
            // btnObtener_ProductoVenta
            // 
            btnObtener_ProductoVenta.Location = new Point(6, 22);
            btnObtener_ProductoVenta.Name = "btnObtener_ProductoVenta";
            btnObtener_ProductoVenta.Size = new Size(68, 25);
            btnObtener_ProductoVenta.TabIndex = 1;
            btnObtener_ProductoVenta.Text = "Obtener";
            btnObtener_ProductoVenta.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(rdbtnVentaProducto);
            Controls.Add(rdbtnVentas);
            Controls.Add(RdbtnProducto);
            Controls.Add(rdbtnUsuarios);
            Controls.Add(dataGridView1);
            Name = "form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            rdbtnUsuarios.ResumeLayout(false);
            RdbtnProducto.ResumeLayout(false);
            rdbtnVentas.ResumeLayout(false);
            rdbtnVentaProducto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnObtener_Usuario;
        private GroupBox rdbtnUsuarios;
        private Button btnEliminar_Usuario;
        private Button btn_ModificarUsuario;
        private Button btnListar_Usuario;
        private Button btnCrear_Usuario;
        private GroupBox RdbtnProducto;
        private Button btnEliminar_Producto;
        private Button btnModificar_Producto;
        private Button btnListar_Producto;
        private Button btnCrear_Producto;
        private Button btnObtener_Producto;
        private GroupBox rdbtnVentas;
        private Button btnEliminar_Venta;
        private Button btnModificar_Venta;
        private Button btnListar_Venta;
        private Button btnCrear_Venta;
        private Button btnObtener_Venta;
        private GroupBox rdbtnVentaProducto;
        private Button btnEliminar_ProductoVenta;
        private Button btnModificar_ProductoVenta;
        private Button btnListar_ProductoVenta;
        private Button btnCrear_ProductoVenta;
        private Button btnObtener_ProductoVenta;
    }
}
