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
           
        }
        private void cargarTabla()
        {
            ArticuloService articulo = new ArticuloService();
            List<Articulo> listaArticulo = articulo.listar();
            dgvTablaArticulos.DataSource = listaArticulo;

            dgvTablaArticulos.Columns["idMarca"].Visible = false;
            dgvTablaArticulos.Columns["idCategoria"].Visible = false;
            dgvTablaArticulos.Columns["id"].Visible = false;


            // Cargar ComboBox de Filtro Marca y Categoria
            MarcaService marca = new MarcaService();
            List<Marca> listaMarca = marca.listar();
            listaMarca.Insert(0, new Marca { idMarca = 0, descripcion = "Todos" });
            cbFiltroMarca.DataSource = listaMarca;
            cbFiltroMarca.DisplayMember = "descripcion";
            cbFiltroMarca.ValueMember = "idMarca";

            CategoriaService categoria = new CategoriaService();
            List<Categoria> listaCategoria = categoria.Listar();
            listaCategoria.Insert(0, new Categoria { idCategoria = 0, descripcion = "Todos" });
            cbFiltroCategoria.DataSource = listaCategoria;
            cbFiltroCategoria.DisplayMember = "descripcion";
            cbFiltroCategoria.ValueMember = "idCategoria";


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

         
            if (cbFiltroMarca.SelectedIndex != 0)
            {
                ArticuloService articulo = new ArticuloService();
                List<Articulo> listaArticulos = articulo.listar();
                List<Articulo> listaFiltrada;
                int idMarca = (int)cbFiltroMarca.SelectedValue;
                listaFiltrada = listaArticulos.FindAll(x => x.idMarca == idMarca);
                dgvTablaArticulos.DataSource = null;
                dgvTablaArticulos.DataSource = listaFiltrada;

                dgvTablaArticulos.Columns["idMarca"].Visible = false;
                dgvTablaArticulos.Columns["idCategoria"].Visible = false;
                dgvTablaArticulos.Columns["id"].Visible = false;

            }
            else
            {
                cargarTabla();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloService articulo = new ArticuloService();
            List<Articulo> listaArticulos = articulo.listar();
            List<Articulo> listaFiltrada;
            listaFiltrada = listaArticulos.FindAll(x => x.nombre.ToUpper().Contains(txtbBuscador.Text.ToUpper()) || x.descripcion.ToUpper().Contains(txtbBuscador.Text.ToUpper()) || x.codigo.ToUpper().Contains(txtbBuscador.Text.ToUpper()));
            dgvTablaArticulos.DataSource = null;
            dgvTablaArticulos.DataSource = listaFiltrada;

            dgvTablaArticulos.Columns["idMarca"].Visible = false;
            dgvTablaArticulos.Columns["idCategoria"].Visible = false;
            dgvTablaArticulos.Columns["id"].Visible = false;

        }

        private void cbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroCategoria.SelectedIndex != 0)
            {
                ArticuloService articulo = new ArticuloService();
                List<Articulo> listaArticulos = articulo.listar();
                List<Articulo> listaFiltrada;
                int idCategoria = (int)cbFiltroCategoria.SelectedValue;
                listaFiltrada = listaArticulos.FindAll(x => x.idCategoria == idCategoria);
                dgvTablaArticulos.DataSource = null;
                dgvTablaArticulos.DataSource = listaFiltrada;
            }
            else
            {
                cargarTabla();
            }

        }

        
    }
    
   
}
