using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisica
{
    internal class PessoaFisica
    {
        [Key]
        public Int64 Cpf { get; set; }

        [Required]
        [StringLength(45)]
        public String Nome { get; set; }
    }
}
