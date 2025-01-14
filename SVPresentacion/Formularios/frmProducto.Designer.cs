namespace SVPresentacion.Formularios
{
 partial class frmProducto
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
   label1 = new Label();
   btnGuardarEditar = new Button();
   btnVolverEditar = new Button();
   btnGuardarNuevo = new Button();
   btnVolverNuevo = new Button();
   cbbCategoriaNuevo = new ComboBox();
   txbCodigoNuevo = new TextBox();
   tabEditar = new TabPage();
   txbCantidadEditar = new NumericUpDown();
   txbPrecioVentaEditar = new TextBox();
   txbDescripcionEditar = new TextBox();
   label4 = new Label();
   label5 = new Label();
   txbPrecioCompraEditar = new TextBox();
   cbbHabilitado = new ComboBox();
   cbbCategoriaEditar = new ComboBox();
   txbCodigoEditar = new TextBox();
   label6 = new Label();
   label14 = new Label();
   label11 = new Label();
   label12 = new Label();
   label13 = new Label();
   label3 = new Label();
   tabNuevo = new TabPage();
   txbCantidadNuevo = new NumericUpDown();
   txbPrecioVentaNuevo = new TextBox();
   txbDescripcionNuevo = new TextBox();
   label9 = new Label();
   label7 = new Label();
   txbPrecioCompraNuevo = new TextBox();
   label8 = new Label();
   label10 = new Label();
   label2 = new Label();
   dgvProductos = new DataGridView();
   txbBuscar = new TextBox();
   btnBuscar = new Button();
   btnNuevoLista = new Button();
   tabLista = new TabPage();
   tabControlMain = new TabControl();
   tabEditar.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).BeginInit();
   tabNuevo.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).BeginInit();
   ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
   tabLista.SuspendLayout();
   tabControlMain.SuspendLayout();
   SuspendLayout();
   // 
   // label1
   // 
   label1.AutoSize = true;
   label1.Location = new Point(12, 15);
   label1.Name = "label1";
   label1.Size = new Size(120, 15);
   label1.TabIndex = 3;
   label1.Text = "Inventario / Producto";
   // 
   // btnGuardarEditar
   // 
   btnGuardarEditar.BackColor = Color.White;
   btnGuardarEditar.Cursor = Cursors.Hand;
   btnGuardarEditar.FlatStyle = FlatStyle.Flat;
   btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
   btnGuardarEditar.Location = new Point(662, 284);
   btnGuardarEditar.Name = "btnGuardarEditar";
   btnGuardarEditar.Size = new Size(59, 23);
   btnGuardarEditar.TabIndex = 10;
   btnGuardarEditar.Text = "Guardar";
   btnGuardarEditar.UseVisualStyleBackColor = false;
   btnGuardarEditar.Click += btnGuardarEditar_Click;
   // 
   // btnVolverEditar
   // 
   btnVolverEditar.BackColor = Color.White;
   btnVolverEditar.Cursor = Cursors.Hand;
   btnVolverEditar.FlatStyle = FlatStyle.Flat;
   btnVolverEditar.Location = new Point(13, 284);
   btnVolverEditar.Name = "btnVolverEditar";
   btnVolverEditar.Size = new Size(59, 23);
   btnVolverEditar.TabIndex = 9;
   btnVolverEditar.Text = "Volver";
   btnVolverEditar.UseVisualStyleBackColor = false;
   btnVolverEditar.Click += btnVolverEditar_Click;
   // 
   // btnGuardarNuevo
   // 
   btnGuardarNuevo.BackColor = Color.White;
   btnGuardarNuevo.Cursor = Cursors.Hand;
   btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
   btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
   btnGuardarNuevo.Location = new Point(663, 287);
   btnGuardarNuevo.Name = "btnGuardarNuevo";
   btnGuardarNuevo.Size = new Size(59, 23);
   btnGuardarNuevo.TabIndex = 4;
   btnGuardarNuevo.Text = "Guardar";
   btnGuardarNuevo.UseVisualStyleBackColor = false;
   btnGuardarNuevo.Click += btnGuardarNuevo_Click;
   // 
   // btnVolverNuevo
   // 
   btnVolverNuevo.BackColor = Color.White;
   btnVolverNuevo.Cursor = Cursors.Hand;
   btnVolverNuevo.FlatStyle = FlatStyle.Flat;
   btnVolverNuevo.Location = new Point(14, 287);
   btnVolverNuevo.Name = "btnVolverNuevo";
   btnVolverNuevo.Size = new Size(59, 23);
   btnVolverNuevo.TabIndex = 3;
   btnVolverNuevo.Text = "Volver";
   btnVolverNuevo.UseVisualStyleBackColor = false;
   btnVolverNuevo.Click += btnVolverNuevo_Click;
   // 
   // cbbCategoriaNuevo
   // 
   cbbCategoriaNuevo.BackColor = Color.White;
   cbbCategoriaNuevo.Cursor = Cursors.Hand;
   cbbCategoriaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
   cbbCategoriaNuevo.FormattingEnabled = true;
   cbbCategoriaNuevo.Location = new Point(9, 26);
   cbbCategoriaNuevo.Name = "cbbCategoriaNuevo";
   cbbCategoriaNuevo.Size = new Size(313, 23);
   cbbCategoriaNuevo.TabIndex = 2;
   // 
   // txbCodigoNuevo
   // 
   txbCodigoNuevo.BackColor = Color.White;
   txbCodigoNuevo.Location = new Point(9, 71);
   txbCodigoNuevo.Name = "txbCodigoNuevo";
   txbCodigoNuevo.Size = new Size(313, 23);
   txbCodigoNuevo.TabIndex = 1;
   // 
   // tabEditar
   // 
   tabEditar.Controls.Add(txbCantidadEditar);
   tabEditar.Controls.Add(txbPrecioVentaEditar);
   tabEditar.Controls.Add(txbDescripcionEditar);
   tabEditar.Controls.Add(label4);
   tabEditar.Controls.Add(label5);
   tabEditar.Controls.Add(txbPrecioCompraEditar);
   tabEditar.Controls.Add(cbbHabilitado);
   tabEditar.Controls.Add(cbbCategoriaEditar);
   tabEditar.Controls.Add(txbCodigoEditar);
   tabEditar.Controls.Add(label6);
   tabEditar.Controls.Add(label14);
   tabEditar.Controls.Add(label11);
   tabEditar.Controls.Add(label12);
   tabEditar.Controls.Add(label13);
   tabEditar.Controls.Add(btnGuardarEditar);
   tabEditar.Controls.Add(btnVolverEditar);
   tabEditar.Location = new Point(4, 24);
   tabEditar.Name = "tabEditar";
   tabEditar.Padding = new Padding(3);
   tabEditar.Size = new Size(732, 316);
   tabEditar.TabIndex = 2;
   tabEditar.Text = "Editar";
   tabEditar.UseVisualStyleBackColor = true;
   // 
   // txbCantidadEditar
   // 
   txbCantidadEditar.BackColor = Color.White;
   txbCantidadEditar.Location = new Point(342, 24);
   txbCantidadEditar.Name = "txbCantidadEditar";
   txbCantidadEditar.Size = new Size(381, 23);
   txbCantidadEditar.TabIndex = 22;
   // 
   // txbPrecioVentaEditar
   // 
   txbPrecioVentaEditar.BackColor = Color.White;
   txbPrecioVentaEditar.Location = new Point(5, 206);
   txbPrecioVentaEditar.Name = "txbPrecioVentaEditar";
   txbPrecioVentaEditar.Size = new Size(313, 23);
   txbPrecioVentaEditar.TabIndex = 20;
   // 
   // txbDescripcionEditar
   // 
   txbDescripcionEditar.BackColor = Color.White;
   txbDescripcionEditar.Location = new Point(5, 115);
   txbDescripcionEditar.Name = "txbDescripcionEditar";
   txbDescripcionEditar.Size = new Size(313, 23);
   txbDescripcionEditar.TabIndex = 21;
   // 
   // label4
   // 
   label4.AutoSize = true;
   label4.Location = new Point(6, 189);
   label4.Name = "label4";
   label4.Size = new Size(94, 15);
   label4.TabIndex = 18;
   label4.Text = "Precio de Venta :";
   // 
   // label5
   // 
   label5.AutoSize = true;
   label5.Location = new Point(6, 98);
   label5.Name = "label5";
   label5.Size = new Size(75, 15);
   label5.TabIndex = 19;
   label5.Text = "Descripcion :";
   // 
   // txbPrecioCompraEditar
   // 
   txbPrecioCompraEditar.BackColor = Color.White;
   txbPrecioCompraEditar.Location = new Point(6, 160);
   txbPrecioCompraEditar.Name = "txbPrecioCompraEditar";
   txbPrecioCompraEditar.Size = new Size(313, 23);
   txbPrecioCompraEditar.TabIndex = 15;
   // 
   // cbbHabilitado
   // 
   cbbHabilitado.BackColor = Color.White;
   cbbHabilitado.Cursor = Cursors.Hand;
   cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
   cbbHabilitado.FormattingEnabled = true;
   cbbHabilitado.Location = new Point(342, 69);
   cbbHabilitado.Name = "cbbHabilitado";
   cbbHabilitado.Size = new Size(313, 23);
   cbbHabilitado.TabIndex = 17;
   // 
   // cbbCategoriaEditar
   // 
   cbbCategoriaEditar.BackColor = Color.White;
   cbbCategoriaEditar.Cursor = Cursors.Hand;
   cbbCategoriaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
   cbbCategoriaEditar.FormattingEnabled = true;
   cbbCategoriaEditar.Location = new Point(6, 24);
   cbbCategoriaEditar.Name = "cbbCategoriaEditar";
   cbbCategoriaEditar.Size = new Size(313, 23);
   cbbCategoriaEditar.TabIndex = 17;
   // 
   // txbCodigoEditar
   // 
   txbCodigoEditar.BackColor = Color.White;
   txbCodigoEditar.Location = new Point(6, 69);
   txbCodigoEditar.Name = "txbCodigoEditar";
   txbCodigoEditar.Size = new Size(313, 23);
   txbCodigoEditar.TabIndex = 16;
   // 
   // label6
   // 
   label6.AutoSize = true;
   label6.Location = new Point(7, 143);
   label6.Name = "label6";
   label6.Size = new Size(111, 15);
   label6.TabIndex = 11;
   label6.Text = "Precio de  Compra :";
   // 
   // label14
   // 
   label14.AutoSize = true;
   label14.Location = new Point(345, 52);
   label14.Name = "label14";
   label14.Size = new Size(68, 15);
   label14.TabIndex = 13;
   label14.Text = "Habilitado :";
   // 
   // label11
   // 
   label11.AutoSize = true;
   label11.Location = new Point(342, 7);
   label11.Name = "label11";
   label11.Size = new Size(61, 15);
   label11.TabIndex = 12;
   label11.Text = "Cantidad :";
   // 
   // label12
   // 
   label12.AutoSize = true;
   label12.Location = new Point(9, 7);
   label12.Name = "label12";
   label12.Size = new Size(64, 15);
   label12.TabIndex = 13;
   label12.Text = "Categoria :";
   // 
   // label13
   // 
   label13.AutoSize = true;
   label13.Location = new Point(7, 52);
   label13.Name = "label13";
   label13.Size = new Size(52, 15);
   label13.TabIndex = 14;
   label13.Text = "Codigo :";
   // 
   // label3
   // 
   label3.AutoSize = true;
   label3.Location = new Point(12, 9);
   label3.Name = "label3";
   label3.Size = new Size(64, 15);
   label3.TabIndex = 0;
   label3.Text = "Categoria :";
   // 
   // tabNuevo
   // 
   tabNuevo.Controls.Add(txbCantidadNuevo);
   tabNuevo.Controls.Add(txbPrecioVentaNuevo);
   tabNuevo.Controls.Add(txbDescripcionNuevo);
   tabNuevo.Controls.Add(label9);
   tabNuevo.Controls.Add(label7);
   tabNuevo.Controls.Add(btnGuardarNuevo);
   tabNuevo.Controls.Add(btnVolverNuevo);
   tabNuevo.Controls.Add(txbPrecioCompraNuevo);
   tabNuevo.Controls.Add(cbbCategoriaNuevo);
   tabNuevo.Controls.Add(txbCodigoNuevo);
   tabNuevo.Controls.Add(label8);
   tabNuevo.Controls.Add(label10);
   tabNuevo.Controls.Add(label3);
   tabNuevo.Controls.Add(label2);
   tabNuevo.Location = new Point(4, 24);
   tabNuevo.Name = "tabNuevo";
   tabNuevo.Padding = new Padding(3);
   tabNuevo.Size = new Size(732, 316);
   tabNuevo.TabIndex = 1;
   tabNuevo.Text = "Nuevo";
   tabNuevo.UseVisualStyleBackColor = true;
   // 
   // txbCantidadNuevo
   // 
   txbCantidadNuevo.BackColor = Color.White;
   txbCantidadNuevo.Location = new Point(345, 26);
   txbCantidadNuevo.Name = "txbCantidadNuevo";
   txbCantidadNuevo.Size = new Size(381, 23);
   txbCantidadNuevo.TabIndex = 7;
   // 
   // txbPrecioVentaNuevo
   // 
   txbPrecioVentaNuevo.BackColor = Color.White;
   txbPrecioVentaNuevo.Location = new Point(8, 208);
   txbPrecioVentaNuevo.Name = "txbPrecioVentaNuevo";
   txbPrecioVentaNuevo.Size = new Size(313, 23);
   txbPrecioVentaNuevo.TabIndex = 6;
   // 
   // txbDescripcionNuevo
   // 
   txbDescripcionNuevo.BackColor = Color.White;
   txbDescripcionNuevo.Location = new Point(8, 117);
   txbDescripcionNuevo.Name = "txbDescripcionNuevo";
   txbDescripcionNuevo.Size = new Size(313, 23);
   txbDescripcionNuevo.TabIndex = 6;
   // 
   // label9
   // 
   label9.AutoSize = true;
   label9.Location = new Point(9, 191);
   label9.Name = "label9";
   label9.Size = new Size(94, 15);
   label9.TabIndex = 5;
   label9.Text = "Precio de Venta :";
   // 
   // label7
   // 
   label7.AutoSize = true;
   label7.Location = new Point(9, 100);
   label7.Name = "label7";
   label7.Size = new Size(75, 15);
   label7.TabIndex = 5;
   label7.Text = "Descripcion :";
   // 
   // txbPrecioCompraNuevo
   // 
   txbPrecioCompraNuevo.BackColor = Color.White;
   txbPrecioCompraNuevo.Location = new Point(9, 162);
   txbPrecioCompraNuevo.Name = "txbPrecioCompraNuevo";
   txbPrecioCompraNuevo.Size = new Size(313, 23);
   txbPrecioCompraNuevo.TabIndex = 1;
   // 
   // label8
   // 
   label8.AutoSize = true;
   label8.Location = new Point(10, 145);
   label8.Name = "label8";
   label8.Size = new Size(111, 15);
   label8.TabIndex = 0;
   label8.Text = "Precio de  Compra :";
   // 
   // label10
   // 
   label10.AutoSize = true;
   label10.Location = new Point(345, 9);
   label10.Name = "label10";
   label10.Size = new Size(61, 15);
   label10.TabIndex = 0;
   label10.Text = "Cantidad :";
   // 
   // label2
   // 
   label2.AutoSize = true;
   label2.Location = new Point(10, 54);
   label2.Name = "label2";
   label2.Size = new Size(52, 15);
   label2.TabIndex = 0;
   label2.Text = "Codigo :";
   // 
   // dgvProductos
   // 
   dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   dgvProductos.Location = new Point(10, 46);
   dgvProductos.Name = "dgvProductos";
   dgvProductos.Size = new Size(712, 260);
   dgvProductos.TabIndex = 2;
   dgvProductos.CellContentClick += dgvProductos_CellContentClick;
   // 
   // txbBuscar
   // 
   txbBuscar.BackColor = Color.WhiteSmoke;
   txbBuscar.Location = new Point(381, 8);
   txbBuscar.Name = "txbBuscar";
   txbBuscar.Size = new Size(274, 23);
   txbBuscar.TabIndex = 1;
   // 
   // btnBuscar
   // 
   btnBuscar.BackColor = Color.White;
   btnBuscar.Cursor = Cursors.Hand;
   btnBuscar.FlatStyle = FlatStyle.Flat;
   btnBuscar.Location = new Point(663, 8);
   btnBuscar.Name = "btnBuscar";
   btnBuscar.Size = new Size(59, 23);
   btnBuscar.TabIndex = 0;
   btnBuscar.Text = "Buscar";
   btnBuscar.UseVisualStyleBackColor = false;
   btnBuscar.Click += btnBuscar_Click;
   // 
   // btnNuevoLista
   // 
   btnNuevoLista.BackColor = Color.White;
   btnNuevoLista.Cursor = Cursors.Hand;
   btnNuevoLista.FlatStyle = FlatStyle.Flat;
   btnNuevoLista.Location = new Point(10, 11);
   btnNuevoLista.Name = "btnNuevoLista";
   btnNuevoLista.Size = new Size(59, 23);
   btnNuevoLista.TabIndex = 0;
   btnNuevoLista.Text = "Nuevo";
   btnNuevoLista.UseVisualStyleBackColor = false;
   btnNuevoLista.Click += btnNuevoLista_Click;
   // 
   // tabLista
   // 
   tabLista.Controls.Add(dgvProductos);
   tabLista.Controls.Add(txbBuscar);
   tabLista.Controls.Add(btnBuscar);
   tabLista.Controls.Add(btnNuevoLista);
   tabLista.Location = new Point(4, 24);
   tabLista.Name = "tabLista";
   tabLista.Padding = new Padding(3);
   tabLista.Size = new Size(732, 316);
   tabLista.TabIndex = 0;
   tabLista.Text = "Lista";
   tabLista.UseVisualStyleBackColor = true;
   // 
   // tabControlMain
   // 
   tabControlMain.Controls.Add(tabLista);
   tabControlMain.Controls.Add(tabNuevo);
   tabControlMain.Controls.Add(tabEditar);
   tabControlMain.ItemSize = new Size(80, 20);
   tabControlMain.Location = new Point(12, 47);
   tabControlMain.Name = "tabControlMain";
   tabControlMain.SelectedIndex = 0;
   tabControlMain.Size = new Size(740, 344);
   tabControlMain.SizeMode = TabSizeMode.Fixed;
   tabControlMain.TabIndex = 2;
   // 
   // frmProducto
   // 
   AutoScaleDimensions = new SizeF(7F, 15F);
   AutoScaleMode = AutoScaleMode.Font;
   ClientSize = new Size(764, 407);
   Controls.Add(label1);
   Controls.Add(tabControlMain);
   FormBorderStyle = FormBorderStyle.None;
   Name = "frmProducto";
   StartPosition = FormStartPosition.CenterScreen;
   Text = "frmProducto";
   Load += frmProducto_Load;
   tabEditar.ResumeLayout(false);
   tabEditar.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).EndInit();
   tabNuevo.ResumeLayout(false);
   tabNuevo.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).EndInit();
   ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
   tabLista.ResumeLayout(false);
   tabLista.PerformLayout();
   tabControlMain.ResumeLayout(false);
   ResumeLayout(false);
   PerformLayout();
  }

  #endregion

  private Label label1;
  private Button btnGuardarEditar;
  private Button btnVolverEditar;
  private Button btnGuardarNuevo;
  private Button btnVolverNuevo;
  private ComboBox cbbCategoriaNuevo;
  private TextBox txbCodigoNuevo;
  private TabPage tabEditar;
  private Label label3;
  private TabPage tabNuevo;
  private TextBox txbDescripcionNuevo;
  private Label label7;
  private Label label2;
  private DataGridView dgvProductos;
  private TextBox txbBuscar;
  private Button btnBuscar;
  private Button btnNuevoLista;
  private TabPage tabLista;
  private TabControl tabControlMain;
  private TextBox txbPrecioVentaNuevo;
  private Label label9;
  private TextBox txbPrecioCompraNuevo;
  private Label label8;
  private NumericUpDown txbCantidadNuevo;
  private Label label10;
  private NumericUpDown txbCantidadEditar;
  private TextBox txbPrecioVentaEditar;
  private TextBox txbDescripcionEditar;
  private Label label4;
  private Label label5;
  private TextBox txbPrecioCompraEditar;
  private ComboBox cbbHabilitado;
  private ComboBox cbbCategoriaEditar;
  private TextBox txbCodigoEditar;
  private Label label6;
  private Label label14;
  private Label label11;
  private Label label12;
  private Label label13;
 }
}