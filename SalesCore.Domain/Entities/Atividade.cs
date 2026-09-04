using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Domain.Entities
{
    internal class Atividade
    {
        public int IdAtividade { get; set; }
        public string tipo { get; set; }
        public string assunto { get; set; }    
        public string descricao { get; set; }

        public DateTime dataAtividade { get; set; }

        public string situacao { get; set; }

        public int idOportunidade { get; set; } 

        public int idUsuarioResponsavel { get; set; }
    }
}
