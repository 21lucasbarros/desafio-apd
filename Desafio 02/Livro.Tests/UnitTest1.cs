using Xunit;
using exercicio2.Core;
namespace Livro.Tests
{
    public class UnitTest1
    {

        private exercicio2.Core.Livro CriarLivroValido()
        {
            exercicio2.Core.Livro livro = new exercicio2.Core.Livro();
            livro.setTitulo("Harry Potter");
            livro.setAutor("J.K. Rowling");
            livro.setEditora("Rocco");
            livro.setAnoEdicao("1994");
            livro.setLocal("Inglaterra");
            return livro;
        }

        [Fact]
        public void ValidaLivro_TituloVazio_DeveGerarErro() // o nome do funcao colocado dessa forma e uma convencao
        {
            var livro = CriarLivroValido();
            livro.setTitulo("");

            LivroBLL.ValidaLivro(livro);

            Assert.True(Erro.getErro()); // checa se tem erro
            Assert.Equal("Insira o título do livro", Erro.getMens()); // checa se a mensagem de erro e essa
        }

        [Fact]
        public void ValidaLivro_AutorVazio_DeveGerarErro()
        {
            var livro = CriarLivroValido();
            livro.setAutor("");

            LivroBLL.ValidaLivro(livro);

            Assert.True(Erro.getErro());
            Assert.Equal("Insira o autor do livro.", Erro.getMens());
        }

        [Fact]
        public void ValidaLivro_EditoraVazia_DeveGerarErro()
        {
            var livro = CriarLivroValido();
            livro.setEditora("");

            LivroBLL.ValidaLivro(livro);

            Assert.True(Erro.getErro());
            Assert.Equal("Insira a editora do livro.", Erro.getMens());
        }

        [Fact]
        public void ValidaLivro_AnoEdicaoVazio_DeveGerarErro()
        {
            var livro = CriarLivroValido();
            livro.setAnoEdicao("");

            LivroBLL.ValidaLivro(livro);

            Assert.True(Erro.getErro());
            Assert.Equal("Insira o ano do livro", Erro.getMens());
        }

        [Fact]
        public void ValidaLivro_AnoEdicaoNaoNumerico_DeveGerarErro()
        {
            var livro = CriarLivroValido();
            livro.setAnoEdicao("anoABC");

            LivroBLL.ValidaLivro(livro);

            Assert.True(Erro.getErro());
            Assert.Equal("O campo ano deve ser numerico", Erro.getMens());
        }

        [Fact]
        public void ValidaLivro_LocalVazio_DeveGerarErro()
        {
            var livro = CriarLivroValido();
            livro.setLocal("");

            LivroBLL.ValidaLivro(livro);

            Assert.True(Erro.getErro());
            Assert.Equal("Insira o local do livro", Erro.getMens());
        }

        [Fact]
        public void ValidaLivro_LivroValido_NaoDeveGerarErro() 
        {
            var livro = CriarLivroValido();

            LivroBLL.ValidaLivro(livro);

            Assert.False(Erro.getErro());
            Assert.Empty(Erro.getMens());
        }
    }
}