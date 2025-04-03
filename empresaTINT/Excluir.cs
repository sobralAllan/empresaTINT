using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresaTINT
{
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();
        }//fim do botão excluir

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo código


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        private void Excluir_Load(object sender, EventArgs e)
        {

        }
    }
}
