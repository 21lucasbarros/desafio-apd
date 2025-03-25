using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2.Core
{
    public class LivroBLL
    {
        public static void ValidaLivro(Livro livro)
        {
            Erro.Clear();

            if (string.IsNullOrEmpty(livro.getTitulo()))
            {
                Erro.setErro("Insira o título do livro");
                return;
            }

            if (string.IsNullOrEmpty(livro.getAutor()))
            {
                Erro.setErro("Insira o autor do livro.");
                return;
            }

            if (string.IsNullOrEmpty(livro.getEditora()))
            {
                Erro.setErro("Insira a editora do livro.");
                return;
            }

            if (string.IsNullOrEmpty(livro.getAnoEdicao()))
            {
                Erro.setErro("true");
                Erro.setErro("Insira o ano do livro");
                return;
            }

            if (!int.TryParse(livro.getAnoEdicao(), out _))
            {
                Erro.setErro("O campo ano deve ser numerico");
                return;
            }

            if (string.IsNullOrEmpty(livro.getLocal()))
            {
                Erro.setErro("Insira o local do livro");
                return;
            }

            return;
        }
    }
}