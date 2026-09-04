using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Domain.Entities
{
    internal class Oportunidade
    {
        public int idOportunidade { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }

        public int valorEstimado { get; set; }

        public DateTime dataAbertura { get; set; }

        public DateTime dataPrevisaoFechamento { get; set; }

        public int idEmpresa { get; set; }

        public int idEtapa { get; set; }

        public int idUsuarioResponsavel { get; set; }

    }
}
