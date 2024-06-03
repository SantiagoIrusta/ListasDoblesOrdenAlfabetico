namespace ListasDoblesOrdenAlfabetico
{

    public partial class Form1 : Form
    {
        clsLista lista = new clsLista();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "" && txtDescripcion.Text != "" && cboCategoria.Text != "" && txtPrecio.Text != "")
            {
                clsProducto nuevoProducto = new clsProducto(int.Parse(txtID.Text), txtDescripcion.Text,
                    cboCategoria.Text, double.Parse(txtPrecio.Text));

                lista.insertar(nuevoProducto);


                txtID.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                cboCategoria.SelectedIndex = 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            cboCategoria.Items.Clear();
            cboCategoria.Items.Add("A");
            cboCategoria.Items.Add("B");
            cboCategoria.Items.Add("C");
            cboCategoria.SelectedIndex = 0;

            cboCategoriaConsulta.Items.Clear();
            cboCategoriaConsulta.Items.Add("A");
            cboCategoriaConsulta.Items.Add("B");
            cboCategoriaConsulta.Items.Add("C");
            cboCategoriaConsulta.SelectedIndex = 0;

            optTodos.Checked = true;

            grConsulta.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            grConsulta.Rows.Clear();

            if (optTodos.Checked)
            {
                lista.listar(grConsulta);
            }
        }
    }
}