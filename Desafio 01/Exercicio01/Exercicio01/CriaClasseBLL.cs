using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErrorLib;

namespace Exercicio01
{
    class CriaClasseBLL
    {
        public static bool validaClass(string nomeClasse, string[] propriedades, out string msgErro)
        {

            if (string.IsNullOrEmpty(nomeClasse))
            {
                msgErro = "O nome da classe deve ser preenchido.";
                return false;
            }

            if (propriedades == null || propriedades.Length == 0)
            {
                msgErro = "A classe deve conter AO MENOS uma propriedade válida.";
                return false;
            }

            msgErro = string.Empty;
            return true;

        }


    }
}
