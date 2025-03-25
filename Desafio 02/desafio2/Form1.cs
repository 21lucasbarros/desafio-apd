using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exercicio2.Core;


namespace exercicio2
{
    public partial class Form1: Form
    {
        Livro livro = new Livro();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            livro.setTitulo(textBox1.Text);
            livro.setAutor(textBox2.Text);
            livro.setEditora(textBox3.Text);
            livro.setAnoEdicao(textBox4.Text);
            livro.setLocal(textBox5.Text);

            LivroBLL.ValidaLivro(livro);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Livro cadastrado com sucesso!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Título do livro cadastrado: {livro.getTitulo()}\n" +
                           $"Autor do livro cadastrado:  {livro.getAutor()}\n" +
                           $"Editora do livro cadastrado: {livro.getEditora()}\n" +
                           $"Ano de Edição do livro cadastrado: {livro.getAnoEdicao()}\n" +
                           $"Local do livro cadastrado: {livro.getLocal()}");
        
        }
    }
}
