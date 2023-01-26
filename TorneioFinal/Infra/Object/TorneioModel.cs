using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Object
{
    [Table("Torneio")]
    public class TorneioModel
    {
        public int Id { get; set; }

        public string Vencedor { get; set; }

        public TorneioModel(string vencedor)
        {
            Vencedor = vencedor;
        }
    }
}
