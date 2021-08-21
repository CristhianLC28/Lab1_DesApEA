using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = textDNI.Text;
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string direc = textDireccion.Text;
            string phone = textTelefono.Text;
            string email = textEmail.Text;
            string fecha = Fecha.Text;
            dataGridView1.Rows.Add("", dni, nombre, apellido, direc, phone, email, fecha);
        }
    }
}
