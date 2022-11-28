using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisica
{
    internal class PessoaFisicaRepository
    {

        public static void Save(PessoaFisica pessoaFisica)
        {
            using (Repository repository = new Repository(Repository.GetConnection(), false))
            {
                repository.ListPessoaFisica.Add(pessoaFisica);
                repository.SaveChanges();
            }
        }
    }
}
