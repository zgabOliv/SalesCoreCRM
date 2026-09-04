using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Domain.Entities
{
    internal class Etapa
    {
        public int idEtapa { get; set; }

        public string nome { get; set; }

        public int ordem { get; set; }

        public int percentualProbabilidade { get; set; }

        public int ativo { get; set; }
    }
}
