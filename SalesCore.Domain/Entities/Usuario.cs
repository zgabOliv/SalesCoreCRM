using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Domain.Entities
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cargo{ get; set; }
        public int ativo { get; set; }
    }
}
