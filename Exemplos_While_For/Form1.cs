using System;
using System.Windows.Forms;

namespace Exemplos_While_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2016; contador >= 1950; contador --)
            {
                cboAno.Items.Add(contador);
            }
        }
    }
}
