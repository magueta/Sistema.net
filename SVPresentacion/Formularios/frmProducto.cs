using SVContenedor.Entidades;
using SVPresentacion.ModelosVista;
using SVPresentacion.ViewModels;
using SVPresentation.Utilidades.Objetos;
using SVPresentation.Utilidades;
using SVServicios.Implementacion;
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
using SVPresentacion.Utilidades;

namespace SVPresentacion.Formularios
{
 public partial class frmProducto : Form
 {
  private IProductoServicios _productoServicios;
  private ICategoriaServicios _categoriaServicios;


  public frmProducto(ICategoriaServicios categoriaServicios, IProductoServicios productoServicios)
  {
   InitializeComponent();
   _categoriaServicios = categoriaServicios;
   _productoServicios = productoServicios;

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
  private async Task MostrarProductos(string buscar = "")
  {
   var listaProductos = await _productoServicios.Listar(buscar);
   var listaVM = listaProductos.Select(item => new ProductoVM
   {
    Id = item.Id,
    Descripcion = item.Descripcion,
    IdCategoria = item.RefCategoria.Id,
    Categoria = item.RefCategoria.Nombre,
    Activo = item.Activo,
    PrecioCompra = item.PrecioCompra.ToString("0.00"),
    PrecioVenta = item.PrecioVenta.ToString("0.00"),
    Cantidad = item.Cantidad,
    Codigo = item.Codigo,
    Habilitado = item.Activo == 1 ? "Si" : "No",

   }).ToList();

   dgvProductos.DataSource = listaVM;

   dgvProductos.Columns["Id"].Visible = false;
   dgvProductos.Columns["IdCategoria"].Visible = false;
   dgvProductos.Columns["Activo"].Visible = false;
   dgvProductos.Columns["Descripcion"].Width = 200;
  }

  private async void frmProducto_Load(object sender, EventArgs e)
  {
   MostrarTab(tabLista.Name);

   dgvProductos.ImplementarConfiguracion("Editar");
   txbPrecioCompraEditar.ValidarNumero();
   txbPrecioCompraNuevo.ValidarNumero();
   txbPrecioVentaEditar.ValidarNumero();
   txbPrecioVentaNuevo.ValidarNumero();

   await MostrarProductos();

   OpcionCombo[] itemsHabilitado = new OpcionCombo[] {
    new OpcionCombo{Texto="Si",Valor=1},
    new OpcionCombo{Texto="No",Valor=0}
   };

   var listaCategorias = await _categoriaServicios.Listar();
   var items = listaCategorias
              .Where(item => item.Activo == 1)
              .Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.Id })
              .ToArray();

   cbbCategoriaNuevo.InsertarItems(items);
   cbbCategoriaEditar.InsertarItems(items);

   cbbHabilitado.InsertarItems(itemsHabilitado);
  }

  private void btnBuscar_Click(object sender, EventArgs e)
  {
   MostrarProductos(txbBuscar.Text);
  }

  private void btnNuevoLista_Click(object sender, EventArgs e)
  {
   MostrarTab(tabNuevo.Name);
   cbbCategoriaNuevo.SelectedIndex = 0;
   txbCantidadNuevo.Value = 0;
   txbCodigoNuevo.Text = "";
   txbDescripcionNuevo.Text = "";
   txbPrecioCompraNuevo.Text = "";
   txbPrecioVentaNuevo.Text = "";
   cbbCategoriaNuevo.Select();

  }

  private void btnVolverNuevo_Click(object sender, EventArgs e)
  {
   MostrarTab(tabLista.Name);
  }

  private async void btnGuardarNuevo_Click(object sender, EventArgs e)
  {
   if (txbCodigoNuevo.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar un codigo");
    return;
   }
   if (txbDescripcionNuevo.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar una Descripcion");
    return;
   }
   if (txbPrecioCompraNuevo.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar un precio de Compra");
    return;
   }
   if (txbCantidadNuevo.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar la cantidad");
    return;
   }
   decimal preciocompra = 0;
   decimal precioventa = 0;

   if (!decimal.TryParse(txbPrecioCompraNuevo.Text, out preciocompra))
   {
    MessageBox.Show("Precio de compra - Formato moneda incorrecto", "Mensaje"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    txbPrecioCompraNuevo.Select();
    return;
   }

   if (!decimal.TryParse(txbPrecioVentaNuevo.Text, out precioventa))
   {
    MessageBox.Show("Precio de compra - Formato moneda incorrecto", "Mensaje"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    txbPrecioVentaNuevo.Select();
    return;
   }
   var objeto = new Producto
   {
    RefCategoria = new Categoria { Id = ((OpcionCombo)cbbCategoriaNuevo.SelectedItem!).Valor },
    Codigo = txbCodigoNuevo.Text.Trim(),
    Descripcion = txbDescripcionNuevo.Text.Trim(),
    PrecioCompra = preciocompra,
    PrecioVenta = precioventa,
    Cantidad = Convert.ToInt32(txbCantidadNuevo.Value)
   };

   var respuesta = await _productoServicios.Crear(objeto);
   if (respuesta != "")
   {
    MessageBox.Show(respuesta);
   }
   else
   {
    await MostrarProductos();
    MostrarTab(tabLista.Name);
   }
  }

  private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgvProductos.Columns[e.ColumnIndex].Name == "ColumnaAccion")
   {
    var productoSeleccionado = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;
    cbbCategoriaEditar.EstablecerValor(productoSeleccionado.IdCategoria);
    txbCodigoEditar.Text = productoSeleccionado.Codigo;
    txbDescripcionEditar.Text = productoSeleccionado.Descripcion;
    txbPrecioCompraEditar.Text = productoSeleccionado.PrecioCompra;
    txbPrecioVentaEditar.Text = productoSeleccionado.PrecioVenta;
    txbCantidadEditar.Value = productoSeleccionado.Cantidad;
    cbbHabilitado.EstablecerValor(productoSeleccionado.Activo);

    MostrarTab(tabEditar.Name);
    cbbCategoriaEditar.Select();
   }


  }

  private void btnVolverEditar_Click(object sender, EventArgs e)
  {
   MostrarTab(tabLista.Name);
  }

  private async void btnGuardarEditar_Click(object sender, EventArgs e)
  {
   if (txbCodigoEditar.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar un codigo");
    return;
   }
   if (txbDescripcionEditar.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar una Descripcion");
    return;
   }
   if (txbPrecioCompraEditar.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar un precio de Compra");
    return;
   }
   if (txbCantidadEditar.Text.Trim() == "")
   {
    MessageBox.Show("Debes ingresar la cantidad");
    return;
   }
   decimal preciocompra = 0;
   decimal precioventa = 0;

   if (!decimal.TryParse(txbPrecioCompraEditar.Text, out preciocompra))
   {
    MessageBox.Show("Precio de compra - Formato moneda incorrecto", "Mensaje"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    txbPrecioCompraEditar.Select();
    return;
   }

   if (!decimal.TryParse(txbPrecioVentaEditar.Text, out precioventa))
   {
    MessageBox.Show("Precio de compra - Formato moneda incorrecto", "Mensaje"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    txbPrecioVentaEditar.Select();
    return;
   }
   var productoSeleccionado = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;
   var objeto = new Producto
   {
    Id = productoSeleccionado.Id,
    RefCategoria = new Categoria { Id = ((OpcionCombo)cbbCategoriaEditar.SelectedItem!).Valor },
    Codigo = txbCodigoEditar.Text.Trim(),
    Descripcion = txbDescripcionEditar.Text.Trim(),
    PrecioCompra = preciocompra,
    PrecioVenta = precioventa,
    Cantidad = Convert.ToInt32(txbCantidadEditar.Value),
    Activo=((OpcionCombo)cbbHabilitado.SelectedItem!).Valor
   };

   var respuesta = await _productoServicios.Editar(objeto);
   if (respuesta != "")
   {
    MessageBox.Show(respuesta);
   }
   else
   {
    await MostrarProductos();
    MostrarTab(tabLista.Name);
   }
  }
 }
}
