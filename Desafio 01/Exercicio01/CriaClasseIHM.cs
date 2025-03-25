using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Exercicio01
{
    public partial class CriaClasseIHM : Form
    {
        public CriaClasseIHM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.ToLower());
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string className = textBox2.Text;
            string[] propArray = listBox1.Items.Cast<string>().ToArray();

            if (!CriaClasseBLL.validaClass(className, propArray, out string msgErro))
            {
                MessageBox.Show(msgErro, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string propMontada = string.Join("\n  ", propArray.Select(propNome => $"public string {propNome} {{ get; set; }}"));
            string classMontada = $"public class {className}\n{{\n  {propMontada}\n}}";
            File.WriteAllText("../../class/classGerada.txt", classMontada);
            MessageBox.Show("Classe gerada com sucesso! Confira na Pasta Class.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}