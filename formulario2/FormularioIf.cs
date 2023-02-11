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
    public partial class FormularioIf : Form
    {
        public FormularioIf()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(textBox1.Text);
            if (num > 0 )
            {
                textBox2.Text = "El número es positivo";
            }else if (num < 0 )
            {
                textBox2.Text = "El número es negativo";
            }
            else
            {
                textBox2.Text = "El número es 0";
            }
        }

        private void numero_if_TextChanged(object sender, EventArgs e)
        {

        }

        private void respuesta_if_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
