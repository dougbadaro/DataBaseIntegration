using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Cpf = 99999999999;
            pessoaFisica.Nome = "Douglas";

            PessoaFisicaRepository.Save(pessoaFisica);
        }
    }
}
