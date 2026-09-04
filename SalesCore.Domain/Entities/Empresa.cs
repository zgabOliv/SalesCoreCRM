using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Domain.Entities
{
    internal class Empresa
    {

        public string IdEmpresa { get; set; }

        public string razaoSocial { get; set; }

        public string nomeFantasia { get; set; }

        public string cnpj { get; set; }

        public string email { get; set; }

        public string telefone { get; set; }

        public DateTime dataCadastro { get; set; }    

        public Boolean ativo { get; set; }  
    }
}
