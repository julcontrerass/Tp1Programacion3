using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using service;

namespace GertorDeArticulos
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        public frmAltaArticulo()
        {

            InitializeComponent();

        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            try
            {

                if (articulo != null)
                    articulo = new Articulo();
                    

                nuevoArticulo.codigo = "23";
                nuevoArticulo.nombre = txtNombre.Text;
                nuevoArticulo.descripcion = txtbDescipcion.Text;
                nuevoArticulo.precio = decimal.Parse(txtPrecio.Text);
                nuevoArticulo.idMarca = (int)cbMarca.SelectedValue;
                nuevoArticulo.idCategoria = (int)cbCategoria.SelectedValue;

                ArticuloService servicio = new ArticuloService();

                if (nuevoArticulo.id != 0)
                {
                    nuevoArticulo.id = articulo.id;
                    servicio.modificar(nuevoArticulo);
                    MessageBox.Show("Articulo modificado exitosamente");
                }
                else
                {
                    servicio.agregar(nuevoArticulo);
                    MessageBox.Show("Articulo agregado exitosamente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Close();


            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            // Cargar ComboBox de Filtro Marca y Categoria
            MarcaService marca = new MarcaService();
            List<Marca> listaMarca = marca.listar();
            cbMarca.DataSource = listaMarca;
            cbMarca.DisplayMember = "descripcion";
            cbMarca.ValueMember = "idMarca";

            CategoriaService categoria = new CategoriaService();
            List<Categoria> listaCategoria = categoria.Listar();
            cbCategoria.DataSource = listaCategoria;
            cbCategoria.DisplayMember = "descripcion";
            cbCategoria.ValueMember = "idCategoria";

            if (articulo != null)
            {
                Text = "Modificar Articulo";
                btnCrear.Text = "Modificar";
                txtNombre.Text = articulo.nombre;
                txtbDescipcion.Text = articulo.descripcion;
                txtPrecio.Text = articulo.precio.ToString();
                cbMarca.SelectedValue = articulo.idMarca;
                cbCategoria.SelectedValue = articulo.idCategoria;
               
            }
        }

        
    }
}
