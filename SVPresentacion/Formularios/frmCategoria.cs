using SVContenedor.Entidades;
using SVPresentacion.ModelosVista;
using SVPresentation.Utilidades;
using SVPresentation.Utilidades.Objetos;
using SVServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SVPresentacion.Formularios
{
 public partial class frmCategoria : Form
 {
  private readonly IMedidaServicios _medidaServicios;
  private readonly ICategoriaServicios _categoriaServicios;
  public frmCategoria(IMedidaServicios medidaServicios, ICategoriaServicios categoriaServicios)
  {
   InitializeComponent();
   _categoriaServicios = categoriaServicios;
   _medidaServicios = medidaServicios;
  }
  public void MostrarTab(string tabName)
  {
   var TabMenu = new TabPage[] { tabLista, tabNuevo, tabEditar };

   foreach (var tab in TabMenu)
   {
    if (tab.Name != tabName)
    {
     tab.Parent = null;
    }
    else
    {
     tab.Parent = tabControlMain;
    }
   }

  }

  private async Task MostrarCategoria(string buscar = "")
  {
   var listaCategorias = await _categoriaServicios.Listar(buscar);
   var listaVM = listaCategorias.Select(item => new CategoriaVM
   {
    Id = item.Id,
    Nombre = item.Nombre,
    IdMedida = item.RefMedida.Id,
    Medida = item.RefMedida.Nombre,
    Activo = item.Activo,
    Habilitado = item.Activo == 1 ? "Si" : "No",

   }).ToList();

   dgvCategorias.DataSource = listaVM;

   dgvCategorias.Columns["Id"].Visible = false;
   dgvCategorias.Columns["IdMedida"].Visible = false;
   dgvCategorias.Columns["Activo"].Visible = false;
  }
  private async void frmCategoria_Load(object sender, EventArgs e)
  {
   MostrarTab(tabLista.Name);

   dgvCategorias.ImplementarConfiguracion("Editar");
   dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
   await MostrarCategoria();

   OpcionCombo[] itemsHabilitado = new OpcionCombo[] {
    new OpcionCombo{Texto="Si",Valor=1},
    new OpcionCombo{Texto="No",Valor=0}
   };

   var listaMedidas = await _medidaServicios.Listar();
   var items = listaMedidas.Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.Id }).ToArray();
   cbbMedidaEditar.InsertarItems(items);
   cbbMedidaNuevo.InsertarItems(items);
   cbbHabilitado.InsertarItems(itemsHabilitado);
  }

  private async void btnBuscar_Click(object sender, EventArgs e)
  {
   await MostrarCategoria(txbBuscar.Text);

  }

  private void btnNuevoLista_Click(object sender, EventArgs e)
  {
   txbNombreNuevo.Text = "";
   cbbMedidaNuevo.SelectedIndex = 0;
   txbNombreNuevo.Select();
   MostrarTab(tabNuevo.Name);


  }

  private void btnVolverNuevo_Click(object sender, EventArgs e)
  {
   MostrarTab(tabLista.Name);
  }

  private void btnVolverEditar_Click(object sender, EventArgs e)
  {
   MostrarTab(tabLista.Name);
  }

  private async void btnGuardarNuevo_Click(object sender, EventArgs e)
  {

   if (txbNombreNuevo.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar el Nombre de la Categoria");
    return;
   }

   var item = (OpcionCombo)cbbMedidaNuevo.SelectedItem!;
   var objeto = new Categoria
   {
    Nombre = txbNombreNuevo.Text.Trim(),
    RefMedida = new Medida { Id = item.Valor }
   };
   var respuesta = await _categoriaServicios.Crear(objeto);
   if (respuesta != "")
   {
    MessageBox.Show(respuesta);
   }
   else
   {
    await MostrarCategoria();
    MostrarTab(tabLista.Name);

   }

  }

  private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgvCategorias.Columns[e.ColumnIndex].Name == "ColumnaAccion")
   {
    var categoriaSeleccionada = (CategoriaVM)dgvCategorias.CurrentRow.DataBoundItem;
    txbNombreEditar.Text = categoriaSeleccionada.Nombre.ToString();

    cbbMedidaEditar.EstablecerValor(categoriaSeleccionada.IdMedida);
    cbbHabilitado.EstablecerValor(categoriaSeleccionada.Activo);

    MostrarTab(tabEditar.Name);
    txbNombreEditar.Select();
   }



  }

  private async void btnGuardarEditar_Click(object sender, EventArgs e)
  {
   if (txbNombreEditar.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar el Nombre de la Categoria");
    return;
   }

   var categoriaSeleccionada = (CategoriaVM)dgvCategorias.CurrentRow.DataBoundItem;
   var objeto = new Categoria
   {
    Id=categoriaSeleccionada.Id,
    Nombre = txbNombreEditar.Text.Trim(),
    RefMedida = new Medida { Id = ((OpcionCombo)cbbMedidaEditar.SelectedItem!).Valor },
    Activo = ((OpcionCombo)cbbHabilitado.SelectedItem!).Valor,
   }; 
   var respuesta = await _categoriaServicios.Editar(objeto);
   if (respuesta != "")
   {
    MessageBox.Show(respuesta);
   }
   else
   {
    await MostrarCategoria();
    MostrarTab(tabLista.Name);

   }
  }
 }
}
