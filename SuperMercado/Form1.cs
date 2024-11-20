namespace SuperMercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Categorias> clasificacion = new List<Categorias>();

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            Categorias nueva = new Categorias(nombre);
            clasificacion.Add(nueva);
            comboBox1.Items.Add(nueva.nombre);


            //Confirmación al usuario
            MessageBox.Show("La categoría se agregó con éxito");
            textBox1.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "Categorias:";

            foreach (Categorias i in clasificacion)
            {

                mensaje += i.nombre + "\n";


            }

            MessageBox.Show(mensaje);


        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (Categorias dato_random in clasificacion)
            {

                MessageBox.Show(dato_random.VerProductos());


            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty)
            {

                Form2 FormAgregarProducto = new Form2();
                FormAgregarProducto.ShowDialog();

            }

            else {
                MessageBox.Show("Debe seleccionar una categoría para agregar un nuevo producto");
            
            }


        }
    }
}
