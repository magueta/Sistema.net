namespace SVPresentacion.Formularios
{
 partial class frmCategoria
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
   tabControlMain = new TabControl();
   tabLista = new TabPage();
   dgvCategorias = new DataGridView();
   txbBuscar = new TextBox();
   btnBuscar = new Button();
   btnNuevoLista = new Button();
   tabNuevo = new TabPage();
   btnGuardarNuevo = new Button();
   btnVolverNuevo = new Button();
   cbbMedidaNuevo = new ComboBox();
   txbNombreNuevo = new TextBox();
   label3 = new Label();
   label2 = new Label();
   tabEditar = new TabPage();
   cbbHabilitado = new ComboBox();
   label6 = new Label();
   btnGuardarEditar = new Button();
   btnVolverEditar = new Button();
   cbbMedidaEditar = new ComboBox();
   txbNombreEditar = new TextBox();
   label4 = new Label();
   label5 = new Label();
   label1 = new Label();
   tabControlMain.SuspendLayout();
   tabLista.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
   tabNuevo.SuspendLayout();
   tabEditar.SuspendLayout();
   SuspendLayout();
   // 
   // tabControlMain
   // 
   tabControlMain.Controls.Add(tabLista);
   tabControlMain.Controls.Add(tabNuevo);
   tabControlMain.Controls.Add(tabEditar);
   tabControlMain.ItemSize = new Size(80, 20);
   tabControlMain.Location = new Point(12, 51);
   tabControlMain.Name = "tabControlMain";
   tabControlMain.SelectedIndex = 0;
   tabControlMain.Size = new Size(740, 344);
   tabControlMain.SizeMode = TabSizeMode.Fixed;
   tabControlMain.TabIndex = 0;
   // 
   // tabLista
   // 
   tabLista.Controls.Add(dgvCategorias);
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
   // dgvCategorias
   // 
   dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   dgvCategorias.Location = new Point(10, 46);
   dgvCategorias.Name = "dgvCategorias";
   dgvCategorias.Size = new Size(712, 260);
   dgvCategorias.TabIndex = 2;
   dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
   // 
   // txbBuscar
   // 
   txbBuscar.Location = new Point(381, 8);
   txbBuscar.Name = "txbBuscar";
   txbBuscar.Size = new Size(274, 23);
   txbBuscar.TabIndex = 1;
   // 
   // btnBuscar
   // 
   btnBuscar.Cursor = Cursors.Hand;
   btnBuscar.FlatStyle = FlatStyle.Flat;
   btnBuscar.Location = new Point(663, 8);
   btnBuscar.Name = "btnBuscar";
   btnBuscar.Size = new Size(59, 23);
   btnBuscar.TabIndex = 0;
   btnBuscar.Text = "Buscar";
   btnBuscar.UseVisualStyleBackColor = true;
   btnBuscar.Click += btnBuscar_Click;
   // 
   // btnNuevoLista
   // 
   btnNuevoLista.Cursor = Cursors.Hand;
   btnNuevoLista.FlatStyle = FlatStyle.Flat;
   btnNuevoLista.Location = new Point(10, 11);
   btnNuevoLista.Name = "btnNuevoLista";
   btnNuevoLista.Size = new Size(59, 23);
   btnNuevoLista.TabIndex = 0;
   btnNuevoLista.Text = "Nuevo";
   btnNuevoLista.UseVisualStyleBackColor = true;
   btnNuevoLista.Click += btnNuevoLista_Click;
   // 
   // tabNuevo
   // 
   tabNuevo.Controls.Add(btnGuardarNuevo);
   tabNuevo.Controls.Add(btnVolverNuevo);
   tabNuevo.Controls.Add(cbbMedidaNuevo);
   tabNuevo.Controls.Add(txbNombreNuevo);
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
   // btnGuardarNuevo
   // 
   btnGuardarNuevo.Cursor = Cursors.Hand;
   btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
   btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
   btnGuardarNuevo.Location = new Point(663, 287);
   btnGuardarNuevo.Name = "btnGuardarNuevo";
   btnGuardarNuevo.Size = new Size(59, 23);
   btnGuardarNuevo.TabIndex = 4;
   btnGuardarNuevo.Text = "Guardar";
   btnGuardarNuevo.UseVisualStyleBackColor = true;
   btnGuardarNuevo.Click += btnGuardarNuevo_Click;
   // 
   // btnVolverNuevo
   // 
   btnVolverNuevo.Cursor = Cursors.Hand;
   btnVolverNuevo.FlatStyle = FlatStyle.Flat;
   btnVolverNuevo.Location = new Point(14, 287);
   btnVolverNuevo.Name = "btnVolverNuevo";
   btnVolverNuevo.Size = new Size(59, 23);
   btnVolverNuevo.TabIndex = 3;
   btnVolverNuevo.Text = "Volver";
   btnVolverNuevo.UseVisualStyleBackColor = true;
   btnVolverNuevo.Click += btnVolverNuevo_Click;
   // 
   // cbbMedidaNuevo
   // 
   cbbMedidaNuevo.Cursor = Cursors.Hand;
   cbbMedidaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
   cbbMedidaNuevo.FormattingEnabled = true;
   cbbMedidaNuevo.Location = new Point(14, 85);
   cbbMedidaNuevo.Name = "cbbMedidaNuevo";
   cbbMedidaNuevo.Size = new Size(708, 23);
   cbbMedidaNuevo.TabIndex = 2;
   // 
   // txbNombreNuevo
   // 
   txbNombreNuevo.Location = new Point(14, 30);
   txbNombreNuevo.Name = "txbNombreNuevo";
   txbNombreNuevo.Size = new Size(708, 23);
   txbNombreNuevo.TabIndex = 1;
   // 
   // label3
   // 
   label3.AutoSize = true;
   label3.Location = new Point(14, 67);
   label3.Name = "label3";
   label3.Size = new Size(53, 15);
   label3.TabIndex = 0;
   label3.Text = "Medida :";
   // 
   // label2
   // 
   label2.AutoSize = true;
   label2.Location = new Point(12, 12);
   label2.Name = "label2";
   label2.Size = new Size(57, 15);
   label2.TabIndex = 0;
   label2.Text = "Nombre :";
   // 
   // tabEditar
   // 
   tabEditar.Controls.Add(cbbHabilitado);
   tabEditar.Controls.Add(label6);
   tabEditar.Controls.Add(btnGuardarEditar);
   tabEditar.Controls.Add(btnVolverEditar);
   tabEditar.Controls.Add(cbbMedidaEditar);
   tabEditar.Controls.Add(txbNombreEditar);
   tabEditar.Controls.Add(label4);
   tabEditar.Controls.Add(label5);
   tabEditar.Location = new Point(4, 24);
   tabEditar.Name = "tabEditar";
   tabEditar.Padding = new Padding(3);
   tabEditar.Size = new Size(732, 316);
   tabEditar.TabIndex = 2;
   tabEditar.Text = "Editar";
   tabEditar.UseVisualStyleBackColor = true;
   // 
   // cbbHabilitado
   // 
   cbbHabilitado.Cursor = Cursors.Hand;
   cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
   cbbHabilitado.FormattingEnabled = true;
   cbbHabilitado.Location = new Point(12, 143);
   cbbHabilitado.Name = "cbbHabilitado";
   cbbHabilitado.Size = new Size(708, 23);
   cbbHabilitado.TabIndex = 12;
   // 
   // label6
   // 
   label6.AutoSize = true;
   label6.Location = new Point(12, 125);
   label6.Name = "label6";
   label6.Size = new Size(65, 15);
   label6.TabIndex = 11;
   label6.Text = "Habilitado:";
   // 
   // btnGuardarEditar
   // 
   btnGuardarEditar.Cursor = Cursors.Hand;
   btnGuardarEditar.FlatStyle = FlatStyle.Flat;
   btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
   btnGuardarEditar.Location = new Point(662, 284);
   btnGuardarEditar.Name = "btnGuardarEditar";
   btnGuardarEditar.Size = new Size(59, 23);
   btnGuardarEditar.TabIndex = 10;
   btnGuardarEditar.Text = "Guardar";
   btnGuardarEditar.UseVisualStyleBackColor = true;
   btnGuardarEditar.Click += btnGuardarEditar_Click;
   // 
   // btnVolverEditar
   // 
   btnVolverEditar.Cursor = Cursors.Hand;
   btnVolverEditar.FlatStyle = FlatStyle.Flat;
   btnVolverEditar.Location = new Point(13, 284);
   btnVolverEditar.Name = "btnVolverEditar";
   btnVolverEditar.Size = new Size(59, 23);
   btnVolverEditar.TabIndex = 9;
   btnVolverEditar.Text = "Volver";
   btnVolverEditar.UseVisualStyleBackColor = true;
   btnVolverEditar.Click += btnVolverEditar_Click;
   // 
   // cbbMedidaEditar
   // 
   cbbMedidaEditar.Cursor = Cursors.Hand;
   cbbMedidaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
   cbbMedidaEditar.FormattingEnabled = true;
   cbbMedidaEditar.Location = new Point(13, 82);
   cbbMedidaEditar.Name = "cbbMedidaEditar";
   cbbMedidaEditar.Size = new Size(708, 23);
   cbbMedidaEditar.TabIndex = 8;
   // 
   // txbNombreEditar
   // 
   txbNombreEditar.Location = new Point(13, 27);
   txbNombreEditar.Name = "txbNombreEditar";
   txbNombreEditar.Size = new Size(708, 23);
   txbNombreEditar.TabIndex = 7;
   // 
   // label4
   // 
   label4.AutoSize = true;
   label4.Location = new Point(13, 64);
   label4.Name = "label4";
   label4.Size = new Size(53, 15);
   label4.TabIndex = 5;
   label4.Text = "Medida :";
   // 
   // label5
   // 
   label5.AutoSize = true;
   label5.Location = new Point(11, 9);
   label5.Name = "label5";
   label5.Size = new Size(57, 15);
   label5.TabIndex = 6;
   label5.Text = "Nombre :";
   // 
   // label1
   // 
   label1.AutoSize = true;
   label1.Location = new Point(12, 19);
   label1.Name = "label1";
   label1.Size = new Size(122, 15);
   label1.TabIndex = 1;
   label1.Text = "Inventario / Categoria";
   // 
   // frmCategoria
   // 
   AutoScaleDimensions = new SizeF(7F, 15F);
   AutoScaleMode = AutoScaleMode.Font;
   ClientSize = new Size(764, 407);
   Controls.Add(label1);
   Controls.Add(tabControlMain);
   FormBorderStyle = FormBorderStyle.None;
   Name = "frmCategoria";
   StartPosition = FormStartPosition.CenterScreen;
   Text = "frmCategoria";
   Load += frmCategoria_Load;
   tabControlMain.ResumeLayout(false);
   tabLista.ResumeLayout(false);
   tabLista.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
   tabNuevo.ResumeLayout(false);
   tabNuevo.PerformLayout();
   tabEditar.ResumeLayout(false);
   tabEditar.PerformLayout();
   ResumeLayout(false);
   PerformLayout();
  }

  #endregion

  private TabControl tabControlMain;
  private TabPage tabLista;
  private TabPage tabNuevo;
  private Label label1;
  private TextBox txbBuscar;
  private Button btnNuevoLista;
  private TabPage tabEditar;
  private Button btnBuscar;
  private DataGridView dgvCategorias;
  private ComboBox cbbMedidaNuevo;
  private TextBox txbNombreNuevo;
  private Label label3;
  private Label label2;
  private Button btnGuardarNuevo;
  private Button btnVolverNuevo;
  private Button btnGuardarEditar;
  private Button btnVolverEditar;
  private ComboBox cbbMedidaEditar;
  private TextBox txbNombreEditar;
  private Label label4;
  private Label label5;
  private ComboBox cbbHabilitado;
  private Label label6;
 }
}