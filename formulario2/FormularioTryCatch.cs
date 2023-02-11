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
    public partial class FormularioTryCatch : Form
    {
        public FormularioTryCatch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte num;
            
            try
            {
                num = Convert.ToByte(this.textBox1.Text);
                int numero;
                numero = Convert.ToInt32(num);
            }catch(Exception ex) { 
               
                textBox2.Text = ex.Message;
            }
        }
    }
}
