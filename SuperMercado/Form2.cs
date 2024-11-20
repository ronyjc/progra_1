using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((txt_codigo.Text != string.Empty) && (txt_nombre.Text != string.Empty) && (txt_marca.Text != string.Empty) && (txt_precio.Text != string.Empty) && (txt_existencia.Text != string.Empty))
            {
                string codigo = txt_codigo.Text;
                string nombre = txt_nombre.Text;
                string marca = txt_marca.Text;
                double precio = Convert.ToDouble(txt_precio.Text);
                int existencia = Convert.ToInt32(txt_existencia.Text);

                Productos nuevo_producto = new Productos(nombre, codigo, marca, precio, existencia);
                MessageBox.Show("El producto " + nuevo_producto.nombre + " fue creado exitosamente");
                    

            }

            else {

                MessageBox.Show("Debe completar todos los campos");
            
            
            }




        }
    }
}
