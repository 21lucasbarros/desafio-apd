using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2.Core
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private string editora;
        private string anoEdicao;
        private string local;

        //sets
        public void setTitulo(string titulo) { this.titulo = titulo; }
        public void setAutor(string autor) { this.autor = autor; }
        public void setEditora(string editora) { this.editora = editora; }
        public void setAnoEdicao(string anoEdicao) { this.anoEdicao = anoEdicao; }
        public void setLocal(string local) { this.local = local; }

        //gets
        public string getTitulo() { return titulo; }
        public string getAutor() { return autor; }
        public string getEditora() { return editora; }
        public string getAnoEdicao() { return anoEdicao; }
        public string getLocal() { return local; }
    
    }
}
