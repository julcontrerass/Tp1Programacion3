using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using GertorDeArticulos;

namespace service
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            cargarTabla();
            dgvTablaArticulos.Columns["idMarca"].Visible = false;
            dgvTablaArticulos.Columns["idCategoria"].Visible = false;


            // Cargar ComboBox de Filtro Marca y Categoria
            MarcaService marca = new MarcaService();
            List<Marca> listaMarca = marca.listar();
            cbFiltroMarca.DataSource = listaMarca;
            cbFiltroMarca.DisplayMember = "descripcion";
            cbFiltroMarca.ValueMember = "idMarca";

            CategoriaService categoria = new CategoriaService();
            List<Categoria> listaCategoria = categoria.Listar();
            cbFiltroCategoria.DataSource = listaCategoria;
            cbFiltroCategoria.DisplayMember = "descripcion";
            cbFiltroCategoria.ValueMember = "idCategoria";




        }
        private void cargarTabla()
        {
            ArticuloService articulo = new ArticuloService();
            List<Articulo> listaArticulo = articulo.listar();
            dgvTablaArticulos.DataSource = listaArticulo;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar Articulo seleccionado
            if (dgvTablaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
                ArticuloService servicio = new ArticuloService();
                try
                {
                    servicio.eliminar(seleccionado.id);
                    MessageBox.Show("Eliminado exitosamente");
                    // Recargar DataGridView
                    dgvTablaArticulos.DataSource = servicio.listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Seleccione un artículo para eliminar.");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarTabla();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (dgvTablaArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un artículo para modificar.");
                return;
            }
            seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo editar = new frmAltaArticulo(seleccionado);
            editar.ShowDialog();
            cargarTabla();
        }

        private void cbFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
    
   
}
