using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosBucles
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NUM = int.Parse(this.txtNumero.Text);
            long resultado = funciones.EjemplosBucles.factorial(NUM);            
            this.txtFactorial.Text = resultado.ToString();

        }
    }
}
