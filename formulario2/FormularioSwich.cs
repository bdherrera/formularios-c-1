using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario2
{
    public partial class FormularioSwich : Form
    {
        public FormularioSwich()
        {
            InitializeComponent();
        }

        private void FormularioSwich_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fecha;
            fecha = Convert.ToInt32(textBox1.Text);
            switch (fecha)
            {
                case 1: textBox2.Text = "Enero"; break;
                case 2: textBox2.Text = "Febrero";break;
                case 3: textBox2.Text = "Marzo"; break;
                case 4: textBox2.Text = "Abril"; break;
                case 5: textBox2.Text = "Mayo"; break;
                case 6: textBox2.Text = "Junio"; break;
                case 7: textBox2.Text = "julio"; break;
                case 8: textBox2.Text = "Agosto"; break;
                case 9: textBox2.Text = "Septiembre"; break;
                case 10: textBox2.Text = "Octubre"; break;
                case 11: textBox2.Text = "Noviembre"; break;
                case 12: textBox2.Text = "Diciembre"; break;
                case > 12: textBox2.Text = "error por favor digite el numero dentro del rango";
                        break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
